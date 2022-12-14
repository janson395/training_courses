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
using TraininCourse.Core.lib;

namespace TraininCourse.View.Pages.Profile
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();


            List<CourseList> courseList = new List<CourseList>();

            courseList.Add(new CourseList(1, "Курсы по HTML", "https://sun1-19.userapi.com/impg/17o1LzYO6PI5NEDK2kRcYor0EXI7Flta59ToFQ/Yq2Ka7_t2eM.jpg?size=1280x960&quality=96&sign=235ab3bbbcb2861879346839ba8e0feb&type=album"));
            courseList.Add(new CourseList(2, "Курсы по HTML", "https://sun1-19.userapi.com/impg/17o1LzYO6PI5NEDK2kRcYor0EXI7Flta59ToFQ/Yq2Ka7_t2eM.jpg?size=1280x960&quality=96&sign=235ab3bbbcb2861879346839ba8e0feb&type=album"));


            LbMyCoursesList.ItemsSource = courseList;
        }

        private void BtnSetting_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnStudying_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWillStudy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnStudied_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
