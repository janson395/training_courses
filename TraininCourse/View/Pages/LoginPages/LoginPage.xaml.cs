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
using TraininCourse.Core.lib.DB;
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
            string pass = TsbPassword.Password;

            if(MainUtil.auth(TbEmail.Text, pass))
            {
                AuthDB authDB = new AuthDB();
                authDB.create(TbEmail.Text, pass);
            }
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            MainUtil.FrameObject.Navigate(new RegPage());
        }
    }
}
