using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TraininCourse.Core.lib.DB;
using TraininCourse.Model;
using TraininCourse.View.Pages;

namespace TraininCourse.Core
{
    public static class MainUtil
    {
        public static Frame FrameObject { get; set; }
        public static CourseVestEntities DB { get; set; }
        public static User MyPerson { get; set; }

        public static bool isAuth { get; set; }

        public static bool auth(string email, string pass)
        {
            try
            {
                User userModel = MainUtil.DB.Users.FirstOrDefault(u =>
                u.Email == email &&
                u.Password == pass);

                if (userModel == null)
                {
                    MessageBox.Show("Не удалось авторизироваться.\r\nПрчина: Ошибка данных",
                        "Системное сообщение",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
                else
                {
                    MainUtil.MyPerson = userModel;

                    ((MainWindow)Application.Current.MainWindow).isAuth = true; // ставим флаг, что пользователь авторизирован
                    ((MainWindow)Application.Current.MainWindow).authSuccess(); // вызываем метод успешной авторизации

                    MainUtil.FrameObject.Navigate(new MainPage());


                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Системная ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

            return false;
        }

        public static void goBack()
        {
            MainUtil.FrameObject.GoBack();
        }
    }
}
