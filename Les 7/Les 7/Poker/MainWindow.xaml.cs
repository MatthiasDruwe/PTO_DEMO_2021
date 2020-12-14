using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Poker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Card card = new Card(Suit.Clubs, 1000);
            Card card2 = new Card(Suit.Hearts, 1);
            Card card3 = new Card(Suit.Spades, 1);
            Card card4 = new Card(Suit.Diamonds, 1);
            Card card5 = new Card(Suit.Clubs, 2);
            Card card6 = new Card(Suit.Hearts, 2);
            Card card7 = new Card(Suit.Spades, 2);
            Card card8 = new Card(Suit.Diamonds, 2);

            Debug.WriteLine(card);
            Debug.WriteLine(card2);
            Debug.WriteLine(card3);
            Debug.WriteLine(card4);
            Debug.WriteLine(card5);
            Debug.WriteLine(card6);
            Debug.WriteLine(card7);
            Debug.WriteLine(card8);

            string[] suits = Enum.GetNames(typeof(Suit));
            suitsComboBox.ItemsSource = suits;
            
            
        }
    }
}
