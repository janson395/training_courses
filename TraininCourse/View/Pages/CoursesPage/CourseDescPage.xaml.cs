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

namespace TraininCourse.View.Pages.CoursesPage
{
    /// <summary>
    /// Логика взаимодействия для CourseDescPage.xaml
    /// </summary>
    public partial class CourseDescPage : Page
    {
        private int _id = 0;

        public CourseDescPage(int id)
        {
            InitializeComponent();

            _id = id;

            Cours course = MainUtil.DB.Courses.FirstOrDefault(c => c.CoursesID == _id);

            TTitle.Text = course.Title;
            TDesc.Text = course.Description;
            IPreview.Source = new ImageLoader(course.Preview).bitmap;
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
