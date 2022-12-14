using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TraininCourse.Model;

namespace TraininCourse.Core
{
    public static class MainUtil
    {
        public static Frame FrameObject { get; set; }
        public static CourseVestEntities DB { get; set; }
        public static User MyPerson { get; set; }

    }
}
