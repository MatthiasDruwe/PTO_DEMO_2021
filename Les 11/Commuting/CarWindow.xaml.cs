using Commuting.Model;
using System;
using System.Windows;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for CarWindow.xaml
    /// </summary>
    public partial class CarWindow : Window
    {
        public CarWindow()
        {
            InitializeComponent();
        }

        public Car CurrentCar { get; set; }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            CreateCarCommute();
        }

        private void CreateCarCommute()
        {
            DateTime selectedDate = (DateTime)datePicker.SelectedDate;

            if (selectedDate != null)
            {
                Content = new Car(fromTextBox.Text, toTextBox.Text, selectedDate, Convert.ToDouble(distanceTextBox.Text));
                DialogResult = true;
            }

            Close();
        }
    }
}
