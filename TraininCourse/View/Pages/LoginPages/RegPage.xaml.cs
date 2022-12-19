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

namespace TraininCourse.View.Pages.LoginPages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private async void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(TbEmail.Text)      ||
                string.IsNullOrEmpty(TbFirstName.Text) ||
                string.IsNullOrEmpty(TbLastName.Text)  ||
                string.IsNullOrEmpty(TsbPassword.Password))
            {
                MessageBox.Show("Заполнены не все поля!", 
                    "Ошибка", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Error);
            } 
            else
            {
                if(MainUtil.DB.Users.Count(u=> u.Email == TbEmail.Text) > 0)
                {
                    MessageBox.Show("Пользователь с такой почтой уже существует",
                        "Ошибка",
                        MessageBoxButton.OK, 
                        MessageBoxImage.Error);
                } 
                else
                {
                    MainUtil.DB.Users.Add(new Model.User 
                    { 
                        Email = TbEmail.Text,
                        FirstName = TbFirstName.Text,
                        LastName = TbLastName.Text,
                        Password = TsbPassword.Password,
                        RoleID = (CbIsTeacher.IsChecked == true) ? 2 : 1,
                        Avatar = null
                    });

                    await MainUtil.DB.SaveChangesAsync();
                    MessageBox.Show("Учетная запись создана", 
                        "Успешно",
                        MessageBoxButton.OK, 
                        MessageBoxImage.Information);

                    MainUtil.FrameObject.Navigate(new LoginPage());
                }
            }

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainUtil.FrameObject.Navigate(new LoginPage());
        }

        private void CbIsTeacher_Click(object sender, RoutedEventArgs e)
        {
            TbBtnReg.Text = (CbIsTeacher.IsChecked == true) ? "Начать обучать" : "К новым знаниям";
        }
    }
}
