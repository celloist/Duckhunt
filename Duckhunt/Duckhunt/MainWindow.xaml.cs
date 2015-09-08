using System;
using System.IO;
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
using System.Reflection;
using System.Drawing;

namespace Duckhunt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageBrush ib = new ImageBrush();
            ib.ImageSource = new BitmapImage(new Uri("pack://application:,,,/resources/apocalypse1.jpg", UriKind.Absolute));
            MyGameCanvas.Background = ib;
            ImageBrush zombie = new ImageBrush();
            ZombieImage.Source = new BitmapImage(new Uri("pack://application:,,,/resources/kirbyzombie50.png", UriKind.Absolute));
            
        }
    }
}
