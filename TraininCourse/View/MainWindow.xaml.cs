using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using TraininCourse.Model;
using TraininCourse.View.Pages;
using TraininCourse.View.Pages.LoginPages;
using TraininCourse.View.Pages.Profile;

namespace TraininCourse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public bool isAuth = false;
        public AuthDB _authDB;

        public MainWindow()
        {
            InitializeComponent();

            MainUtil.FrameObject = MainWindowFrame;
            MainUtil.DB = new CourseVestEntities();
            MainWindowFrame.Navigate(new MainPage());

            BtnOpenProfile.Visibility = Visibility.Collapsed;
            SPLogin.Visibility = Visibility.Visible;

            _authDB = new AuthDB();
            

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        // кнопка открытия главной страницы
        private void BtnMain_Click(object sender, RoutedEventArgs e)
        {
            MainUtil.FrameObject.Navigate(new MainPage());
        }

        // кнопка открытия страницы "Мои курсы"
        private void BtnMyCourses_Click(object sender, RoutedEventArgs e)
        {
            MainUtil.FrameObject.Navigate(new ProfilePage());
        }


        // кнопка открытия формы атворизации
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainUtil.FrameObject.Navigate(new LoginPage());
        }

        
        // если пользователь авторизирован, то ему доступа кнопка, при нажатии на кторую открывается его профиль
        private void BtnOpenProfile_Click(object sender, RoutedEventArgs e)
        {
            MainUtil.FrameObject.Navigate(new ProfilePage());
        }

        private void BtnAddCourse_Click(object sender, RoutedEventArgs e)
        {

        }

        public void authSuccess()
        {
            if (!isAuth)
            {
                BtnOpenProfile.Visibility = Visibility.Collapsed;
                SPLogin.Visibility = Visibility.Visible;
                
            }
            else
            {
                SPLogin.Visibility = Visibility.Collapsed;
                BtnOpenProfile.Visibility = Visibility.Visible;

                TbUserName.Text = MainUtil.MyPerson.FirstName.Trim() + " " + MainUtil.MyPerson.LastName[0] + ".";


                if(MainUtil.MyPerson.Avatar != null)
                {
                    ImgUserAva.ImageSource = new ImageLoader(MainUtil.MyPerson.Avatar).bitmap;
                }

                if(MainUtil.MyPerson.RoleID > 1)
                {
                    BtnAddCourse.Visibility = Visibility.Visible;
                } 
                else
                {
                    BtnAddCourse.Visibility = Visibility.Collapsed;
                }
            }
            MainUtil.isAuth = isAuth;
        }

        public void logout()
        {
            isAuth = false;
            BtnOpenProfile.Visibility = Visibility.Collapsed;
            SPLogin.Visibility = Visibility.Visible;
            MainUtil.isAuth = isAuth;
        }
    }
}
