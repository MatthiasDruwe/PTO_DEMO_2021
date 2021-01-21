using Commuting;
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


        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            CreateCarCommute();
        }

        private void CreateCarCommute()
        {
            DateTime selectedDate = (DateTime)datePicker.SelectedDate;

            if (selectedDate != null)
            {
                Car car = new Car(fromTextBox.Text, toTextBox.Text, selectedDate, Convert.ToDouble(distanceTextBox.Text));
                CommuteRepository commuteRepository = new CommuteRepository();
                commuteRepository.CreateCommute(car);
                DialogResult = true;
            }

            Close();
        }
    }
}
