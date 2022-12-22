using System;
using System.Collections.Generic;
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
using TraininCourse.Model;

namespace TraininCourse.View.Pages.CoursesPage.Admins
{
    /// <summary>
    /// Логика взаимодействия для AddingCoursePage.xaml
    /// </summary>
    public partial class AddingCoursePage : Page
    {
        public AddingCoursePage()
        {
            InitializeComponent();

            // если у пользователя нет прав и он каким-то образом попал на эту страницу - выкидываем
            if(MainUtil.MyPerson.RoleID < 2)
            {
                MainUtil.FrameObject.GoBack();
            }
        }

        private void BtnAddCourse_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(TbTitle.Text)                ||
                string.IsNullOrEmpty(TbPreview.Text)             || 
                string.IsNullOrEmpty(
                    new TextRange(
                        TbDescription.Document.ContentStart, 
                        TbDescription.Document.ContentEnd).Text) ||
               string.IsNullOrEmpty(TbData.Text))
            {
                MessageBox.Show("Не все поля заполнены",
                    "Ошибка",
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error);
            } 
            else
            {
                if(TbTitle.Text.Length > 50)
                {
                    MessageBox.Show("Длинна заголовка курса не должна превышать 50 симоволов!",
                        "Ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }

                if(MainUtil.DB.Courses.Count(c=> c.Title == TbTitle.Text) > 0)
                {
                    MessageBox.Show("Курс с таким заголовком уже существует",
                        "Ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                } 
                else
                {

                    var course = new Cours
                    {
                        Title = TbTitle.Text,
                        Preview = TbPreview.Text,
                        Description = new TextRange(
                            TbDescription.Document.ContentStart,
                            TbDescription.Document.ContentEnd).Text,
                        PublisherID = MainUtil.MyPerson.UserID,
                        Data = TbData.Text
                    };

                    MainUtil.DB.Courses.Add(course);

                    MainUtil.DB.SaveChanges();
                    MessageBox.Show("Курс успешно добавлен",
                        "Системное сообщение",
                        MessageBoxButton.OK, 
                        MessageBoxImage.Information);

                    MainUtil.FrameObject.Navigate(new CourseDescPage(course.CoursesID));
                }
            }
        }
    }
}
