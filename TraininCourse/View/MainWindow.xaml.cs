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
using TraininCourse.View.Pages;
using TraininCourse.View.Pages.LoginPages;

namespace TraininCourse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public bool isAuth = true;

        public MainWindow()
        {
            InitializeComponent();

            MainUtil.FrameObject = MainWindowFrame;
            MainWindowFrame.Navigate(new MainPage());


            if (!isAuth)
            {
                BtnOpenProfile.Visibility = Visibility.Collapsed;
                SPLogin.Visibility = Visibility.Visible;
            }
            else
            {
                SPLogin.Visibility = Visibility.Collapsed;
                BtnOpenProfile.Visibility = Visibility.Visible;
            }

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
    }
}
