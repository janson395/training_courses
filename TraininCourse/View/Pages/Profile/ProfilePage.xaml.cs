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
using TraininCourse.View.Pages.CoursesPage;
using TraininCourse.View.Pages.LoginPages;

namespace TraininCourse.View.Pages.Profile
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        List<CourseList> _courseList;

        public ProfilePage()
        {
            InitializeComponent();


            if (!((MainWindow)Application.Current.MainWindow).isAuth)
            {
                MainUtil.FrameObject.Navigate(new LoginPage());
            }

            _courseList = new List<CourseList>();

            if (MainUtil.MyPerson.Avatar != null)
            {
                IUserAva.ImageSource = new ImageLoader(MainUtil.MyPerson.Avatar).bitmap;
            }
            TbUserName.Text = MainUtil.MyPerson.FirstName.Trim() + " " + MainUtil.MyPerson.LastName.Trim();
            Role role = MainUtil.DB.Roles.FirstOrDefault(u => u.RoleID == MainUtil.MyPerson.RoleID);
            if (role.RoleName != null)
            {
                TbUserRole.Text = role.RoleName;
            }

            foreach (Subscribe s in MainUtil.DB.Subscribes.Where(s => s.Catalog == 1 && s.UserID == MainUtil.MyPerson.UserID))
            {
                Cours courses = MainUtil.DB.Courses.First(c => c.CoursesID == s.CoursesID);
                _courseList.Add(new CourseList(courses.CoursesID, courses.Title, courses.Preview));
            }

            LbMyCoursesList.ItemsSource = _courseList;
        }

        private void BtnSetting_Click(object sender, RoutedEventArgs e)
        {
            MainUtil.FrameObject.Navigate(new SettingPage());
        }

        private void BtnStudying_Click(object sender, RoutedEventArgs e)
        {
            _courseList.Clear();
            foreach (Subscribe s in MainUtil.DB.Subscribes.Where(s => s.Catalog == 1 && s.UserID == MainUtil.MyPerson.UserID))
            {
                Cours courses = MainUtil.DB.Courses.First(c => c.CoursesID == s.CoursesID);
                _courseList.Add(new CourseList(courses.CoursesID, courses.Title, courses.Preview));
            }
            LbMyCoursesList.ItemsSource = _courseList;
        }

        private void BtnWillStudy_Click(object sender, RoutedEventArgs e)
        {
            _courseList.Clear();
            foreach (Subscribe s in MainUtil.DB.Subscribes.Where(s => s.Catalog == 2 && s.UserID == MainUtil.MyPerson.UserID))
            {
                Cours courses = MainUtil.DB.Courses.First(c => c.CoursesID == s.CoursesID);
                _courseList.Add(new CourseList(courses.CoursesID, courses.Title, courses.Preview));
            }
            LbMyCoursesList.ItemsSource = _courseList;
        }

        private void BtnStudied_Click(object sender, RoutedEventArgs e)
        {
            _courseList.Clear();
            foreach (Subscribe s in MainUtil.DB.Subscribes.Where(s => s.Catalog == 3 && s.UserID == MainUtil.MyPerson.UserID))
            {
                Cours courses = MainUtil.DB.Courses.First(c => c.CoursesID == s.CoursesID);
                _courseList.Add(new CourseList(courses.CoursesID, courses.Title, courses.Preview));
            }
            LbMyCoursesList.ItemsSource = _courseList;
        }

        private void LbMyCoursesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            MainUtil.FrameObject.Navigate(new CourseDescPage(_courseList[listbox.SelectedIndex].Id));
        }
    }
}
