using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace TraininCourse.Core.lib
{
    public class ImageLoader
    {
        public BitmapImage bitmap { get; set; }

        public ImageLoader(string url) {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(url, UriKind.Absolute);
            bitmap.EndInit();

            this.bitmap = bitmap;
        }


    }
}
