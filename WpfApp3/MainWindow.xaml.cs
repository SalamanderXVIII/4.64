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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Sphere sphere;
        private Parallelepiped parallelepiped;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            parallelepiped = new Parallelepiped(double.Parse(Width.Text),
                          double.Parse(Height.Text), double.Parse(Lenght.Text));
            Sol.Text = parallelepiped.Print();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sphere = new Sphere(double.Parse(Radius.Text));
            Sol2.Text = sphere.Print();
        }
    }
    //Гребенюк, 21-ИСП-2, Абстрактные классы, 64-й.
}
