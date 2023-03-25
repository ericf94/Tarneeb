using System.Runtime.CompilerServices;
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

        /// <summary>
        /// Loads StartWindow when MainWindow Loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_StartWindow(object sender, RoutedEventArgs e)
        {
            StartWindow window = new StartWindow(this);
            window.Show();
            window.Topmost = true;
        }


        /// <summary>
        /// Launch SettingsWindow when button pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LaunchSettings(object sender, RoutedEventArgs e)
        {
            SettingsWindow window = new SettingsWindow();
            window.Show();
            window.Topmost = true;
        }

        /// <summary>
        /// Launch GameScoreWindow when button pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LaunchScores(object sender, RoutedEventArgs e)
        {
            GameScoreWindow window = new GameScoreWindow();
            window.Show();
            window.Topmost = true;
        }

        /// <summary>
        /// 
        /// </summary>
        internal static void PlayGame()
        {
            //Instantiate deck
            Deck deck = new Deck();

            //Shuffle Cards
            deck.Shuffle();

            //Select Dealer

            //Deal Cards (starting with player after dealer until all cards dealt)  
        }

        internal static void DealCards()
        {

        }
    }

}
