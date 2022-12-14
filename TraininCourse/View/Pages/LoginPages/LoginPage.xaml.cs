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
using TraininCourse.Core.lib;
using TraininCourse.Model;

namespace TraininCourse.View.Pages.LoginPages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User userModel = MainUtil.DB.Users.FirstOrDefault(u =>
                u.Email == TbEmail.Text &&
                u.Password == TsbPassword.Password);

                if(userModel == null) {
                    MessageBox.Show("Ошибка данных",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                } 
                else
                {
                    MainUtil.MyPerson = userModel;
                    //Application.Current.MainWindow.
                    ((MainWindow)Application.Current.MainWindow).isAuth = true; // ставим флаг, что пользователь авторизирован
                    ((MainWindow)App.Current.MainWindow).authSuccess(); // вызываем метод успешной авторизации
                    MainUtil.FrameObject.Navigate(new MainPage());
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Системная ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            MainUtil.FrameObject.Navigate(new RegPage());
        }
    }
}
