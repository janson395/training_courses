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
using TraininCourse.Core.lib;

namespace TraininCourse.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {

        public MainPage()
        {
            InitializeComponent();

            List<CourseList> courseList = new List<CourseList>();

            courseList.Add(new CourseList("Курсы по HTML", "https://sun1-19.userapi.com/impg/17o1LzYO6PI5NEDK2kRcYor0EXI7Flta59ToFQ/Yq2Ka7_t2eM.jpg?size=1280x960&quality=96&sign=235ab3bbbcb2861879346839ba8e0feb&type=album"));

            listbox1.ItemsSource = courseList;
        }
    }
}
