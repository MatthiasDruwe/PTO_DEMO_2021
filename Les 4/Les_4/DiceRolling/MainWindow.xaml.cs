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

namespace DiceRolling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dice dice1 = new Dice("Dobbelsteen 1");
        Dice dice2 = new Dice("Dobbelsteen 2");
        Dice dice3 = new Dice("Dobbelsteen 3");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            rollDice(dice1, rolledNumber1Image, rolledNumber1Label);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            rollDice(dice2, rolledNumber2Image, rolledNumber2Label);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            rollDice(dice3, rolledNumber3Image, rolledNumber3Label);
        }

        private void rollDice(Dice dice, Image image, Label label)
        {
            dice.Roll();
            image.Source = dice.Image;
            label.Content = $"{dice.Name}: {dice.RolledNumber}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rollDice(dice1, rolledNumber1Image, rolledNumber1Label);
            rollDice(dice2, rolledNumber2Image, rolledNumber2Label);
            rollDice(dice3, rolledNumber3Image, rolledNumber3Label);
        }
    }
}
