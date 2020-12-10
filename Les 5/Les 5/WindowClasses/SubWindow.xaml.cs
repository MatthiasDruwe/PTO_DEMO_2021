using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WindowClasses
{
    /// <summary>
    /// Interaction logic for SubWindow.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        private string choosenButton;

        public string ChoosenButton { get => choosenButton; set => choosenButton = value; }

        public SubWindow(string message)
        {
            InitializeComponent();
            messageLabel.Content = message;
        }

        private void fietsButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
            choosenButton = (string)fietsButton.Content;
        }

        private void autoButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
            choosenButton = (string)autoButton.Content;
        }
    }
}
