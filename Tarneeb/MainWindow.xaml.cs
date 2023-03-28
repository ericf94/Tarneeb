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

            //Create players
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Player playerThree = new Player();
            Player playerFour = new Player();

            //Select Dealer

            //Deal Cards (starting with player after dealer until all cards dealt)  
        }

        //Deal Cards (starting with player after dealer until all cards dealt)
        internal static void DealCards(Deck deck, Player playerOne, Player playerTwo, Player playerThree, Player playerFour)
        {

            //put players into array
            Player[] players = { playerOne, playerTwo, playerThree, playerFour };
            int playerIndex = 0;

            for (int i = 0; i < 52; i++)
            {
                //add value to new card taken out of deck
                Card card = deck.TakeCard();

                //add card to player list
                players[playerIndex].PlayerHand.Add(card);

                playerIndex++;

                //if playerIndex is above 4, it resets back to first player
                if (playerIndex >= 4)
                {
                    playerIndex = 0;
                }
            }
        }
    }

}
