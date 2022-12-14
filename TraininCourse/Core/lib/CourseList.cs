using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TraininCourse.Core.lib
{
    public class CourseList
    {
        public int Id { get; set; } // id курса
        public string Name { get; set; } // имя курса
        public BitmapImage Path { get; set; } // изображение курса

        public CourseList(int id, string name, string url)
        {
            this.Id = id;
            this.Name = name; // имя курса

            // скачиваем и преобразуем каритнку в bitmap
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(url, UriKind.Absolute);
            bitmap.EndInit();
            Path = bitmap;
        }
    }
}
