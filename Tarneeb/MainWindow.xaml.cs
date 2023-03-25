using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tarneeb
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

        //Upon MainWindow loading, open start menu
        private void Load_StartWindow(object sender, RoutedEventArgs e)
        {
            StartWindow window = new StartWindow();
            window.Show();
            window.Topmost = true;
        }


        internal static void DealHand()
        {
            Deck deck = new Deck();
        }
    }

}
