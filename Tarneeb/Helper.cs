using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Tarneeb
{
    //Public static
    public static class Helper
    {
        
        public static BitmapImage GetImage(string path)
        {
            //Converts image to bitmap image when path is passed
            BitmapImage img = new BitmapImage();

            //Begin Initialization
            img.BeginInit();
            //Assign new uniform resource identifier
            img.UriSource = new Uri(path, UriKind.RelativeOrAbsolute);
            //End Initialization
            img.EndInit();

            return img;
        }
    }
}
