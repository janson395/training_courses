using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TraininCourse.Core;
using TraininCourse.Core.lib;
using TraininCourse.Model;

namespace TraininCourse.View.Pages.CoursesPage
{
    /// <summary>
    /// Логика взаимодействия для CourseDescPage.xaml
    /// </summary>
    public partial class CourseDescPage : Page
    {
        private int _id = 0;
        private Subscribe subscribe;
        private bool ignoreSelection = false;

        public CourseDescPage(int id)
        {
            InitializeComponent();

            _id = id;

            Cours course = MainUtil.DB.Courses.FirstOrDefault(c => c.CoursesID == _id);

            TTitle.Text = course.Title;
            TDesc.Text = course.Description;
            IPreview.Source = new ImageLoader(course.Preview).bitmap;

            if (((MainWindow)Application.Current.MainWindow).isAuth)
            {
                subscribe = MainUtil.DB.Subscribes.FirstOrDefault(s => s.UserID == MainUtil.MyPerson.UserID && s.CoursesID == _id);
                if(subscribe != null)
                {
                    ignoreSelection = true;
                    CbCatalog.SelectedIndex = subscribe.Catalog - 1 ;

                    switch (subscribe.Catalog)
                    {
                        case 1:
                            TbBtnStart.Text = "Продолжить";
                            break;
                        case 2:
                            TbBtnStart.Text = "Приступить";
                            break;
                        case 3:
                            TbBtnStart.Text = "Возобновить";
                            break;
                    }
                }
            } 
            else
            {
                CbCatalog.Visibility = Visibility.Collapsed;
                TbBtnStart.Text = "Для продолжения необходимо авторизироваться";
            }
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            if (!MainUtil.isAuth)
            {
                MessageBox.Show("Чтобы начать изучать курс, необходимо авторизироваться!", 
                    "Ошибка", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error);
            } 
            else
            {
                getSubsribe();

                if (subscribe == null)
                {
                    MainUtil.DB.Subscribes.Add(new Subscribe
                    {
                        CoursesID = _id,
                        UserID = MainUtil.MyPerson.UserID,
                        Catalog = 1
                    });
                    MainUtil.DB.SaveChanges();
                } 
                else
                {
                    subscribe.Catalog = 1;
                    MainUtil.DB.SaveChanges();
                }
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ignoreSelection)
            {
                ignoreSelection = false;
                return;
            }

            ComboBox comboBox = sender as ComboBox;
            int selection = comboBox.SelectedIndex + 1;

            getSubsribe();

            if(subscribe == null)
            {
                MainUtil.DB.Subscribes.Add(new Subscribe
                {
                    CoursesID = _id,
                    UserID = MainUtil.MyPerson.UserID,
                    Catalog = selection
                });
                MainUtil.DB.SaveChanges();
                getSubsribe();
            } 
            else
            {
                getSubsribe();
                subscribe.Catalog = selection;
                MainUtil.DB.SaveChanges();
            }
            MainUtil.DB.SaveChanges();

            switch (subscribe.Catalog)
            {
                case 1:
                    TbBtnStart.Text = "Продолжить";
                    break;
                case 2:
                    TbBtnStart.Text = "Приступить";
                    break;
                case 3:
                    TbBtnStart.Text = "Возобновить";
                    break;
            }

            MessageBox.Show("Курс успешно добавлен в вашу библиотеку", 
                "Успешно",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void getSubsribe()
        {
            subscribe = MainUtil.DB.Subscribes.FirstOrDefault(s => s.UserID == MainUtil.MyPerson.UserID && s.CoursesID == _id);
        }
    }
}
