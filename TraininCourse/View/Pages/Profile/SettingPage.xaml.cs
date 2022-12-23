using System;
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
using TraininCourse.Core.lib.DB;
using TraininCourse.View.Pages.LoginPages;

namespace TraininCourse.View.Pages.Profile
{
    /// <summary>
    /// Логика взаимодействия для SettingPage.xaml
    /// </summary>
    public partial class SettingPage : Page
    {
        public SettingPage()
        {
            InitializeComponent();

            TbFirstName.Text = MainUtil.MyPerson.FirstName;
            TbLastName.Text = MainUtil.MyPerson.LastName;
            if(MainUtil.MyPerson.Avatar != null)
            {
                TbLinkAvatar.Text = MainUtil.MyPerson.Avatar;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainUtil.goBack();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if(TbFirstName.Text == MainUtil.MyPerson.FirstName && 
                TbLastName.Text == MainUtil.MyPerson.LastName  &&
                TbLinkAvatar.Text == MainUtil.MyPerson.Avatar) 
            {
                MessageBox.Show("Нет изменений, которые требовалось бы сохранить",
                    "Сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            } 
            else
            {
                var updateData = MainUtil.DB.Users
                    .Where(u => u.UserID == MainUtil.MyPerson.UserID)
                    .FirstOrDefault();

                updateData.FirstName = TbFirstName.Text;
                updateData.LastName = TbLastName.Text;
                updateData.Avatar = TbLinkAvatar.Text;

                MainUtil.DB.SaveChanges();

                if (TbLinkAvatar.Text != null)
                {
                    // принудительно обновить автарку пользователя в меню
                    ((MainWindow)Application.Current.MainWindow).ImgUserAva.ImageSource = new ImageLoader(TbLinkAvatar.Text).bitmap; 
                }

                MainUtil.FrameObject.Navigate(new ProfilePage());
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            AuthDB authDB = new AuthDB();
            authDB.logout();
        }
    }
}
