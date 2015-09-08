using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Duckhunt.Models
{
    abstract class GameObject
    {
        protected BitmapImage image;

        public GameObject()
        {

        }

        public BitmapImage Image()
        {
            return image;
        }
    }
}
