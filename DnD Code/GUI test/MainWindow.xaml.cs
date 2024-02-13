using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUI_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void weighedSliderEnable(object sender, RoutedEventArgs e)
        {
            weight.IsEnabled = true;
        }

        private void weighedSliderDisable(object sender, RoutedEventArgs e)
        {
            weight.IsEnabled = false;
        }
    }
}