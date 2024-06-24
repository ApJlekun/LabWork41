using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private bool _isMenuOpen = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            double newWidth = _isMenuOpen ? 0 : 200;
            DoubleAnimation widthAnimation = new DoubleAnimation
            {
                From = SideMenu.ActualWidth,
                To = newWidth,
                Duration = new Duration(TimeSpan.FromSeconds(1))
            };
            SideMenu.BeginAnimation(WidthProperty, widthAnimation);
            _isMenuOpen = !_isMenuOpen;
        }
    }
}