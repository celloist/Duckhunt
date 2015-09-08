using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Duckhunt.Models
{
    class Zombie : GameObject
    {

        public Zombie()
        {
            this.image = new BitmapImage(new Uri("pack://application:,,,/resources/kirbyzombie50.png", UriKind.Absolute));
        }
    }
}
