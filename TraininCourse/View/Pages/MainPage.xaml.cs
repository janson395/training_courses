using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TraininCourse.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        List<CourseList> _courseList;
        public MainPage()
        {
            InitializeComponent();

            _courseList = new List<CourseList>();

            foreach (Cours courses in MainUtil.DB.Courses)
            {
                _courseList.Add(new CourseList(courses.CoursesID, courses.Title, courses.Preview));
            }   


            LbCourseList.ItemsSource = _courseList;
        }

        private void LbCourseList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            MainUtil.FrameObject.Navigate(new CourseDescPage(_courseList[listbox.SelectedIndex].Id));
        }
    }
}
