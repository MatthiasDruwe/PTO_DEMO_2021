using Commuting.Model;
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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for CarWindow.xaml
    /// </summary>
    public partial class TrainWindow : Window
    {
        public TrainWindow()
        {
            InitializeComponent();
        }

        public Commute CurrentTrain { get; internal set; }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            CreateTrainCommute();
        }

        private void CreateTrainCommute()
        {
            DateTime selectedDate = (DateTime)datePicker.SelectedDate;

            if (selectedDate != null)
            {
                Content = new Train(fromTextBox.Text, toTextBox.Text, selectedDate, Convert.ToDouble(ticketPriceTextBox.Text));
                DialogResult = true;
            }

            Close();
        }
    }
}
