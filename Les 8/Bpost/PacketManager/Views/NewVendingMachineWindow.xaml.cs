using BpostClasses.Models;
using System;
using System.Windows;

namespace PacketManager.Views
{
    /// <summary>
    /// Interaction logic for NewVendingMachineWindow.xaml
    /// </summary>
    public partial class NewVendingMachineWindow : Window
    {
        VendingMachine vendingMachine;

        public NewVendingMachineWindow()
        {
            InitializeComponent();
        }

        internal VendingMachine VendingMachine { get => vendingMachine; }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveVendingMachine();
        }

        private void SaveVendingMachine()
        {
            vendingMachine = new VendingMachine(nameTextBox.Text,
                streetTextBox.Text, NumberTextBox.Text, Convert.ToInt32(PostalCodeTextBox.Text), CityTextBox.Text);

            DialogResult = true;

            Close();
        }
    }
}
