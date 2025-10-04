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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Text1.Foreground = new SolidColorBrush(Color.FromRgb(0x00, 0xA2, 0xE8));
            Text1.HorizontalAlignment = HorizontalAlignment.Center;
            Text1.VerticalAlignment = VerticalAlignment.Center;

            this.Title += " - .NET Core で WPF";
        }
    }
}