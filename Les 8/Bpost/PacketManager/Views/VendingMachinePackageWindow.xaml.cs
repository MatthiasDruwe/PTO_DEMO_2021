using BpostClasses.Models;
using System;
using System.Collections.Generic;
using System.Windows;
using Size = BpostClasses.Models.Size;

namespace PacketManager.Views
{
    /// <summary>
    /// Interaction logic for VendingMachinePackageWindow.xaml
    /// </summary>
    public partial class VendingMachinePackageWindow : Window
    {
        VendingMachinePackage vendingMachinePackage;

        public VendingMachinePackageWindow(List<VendingMachine> vendingMachines)
        {
            InitializeComponent();
            LoadFormData(vendingMachines);
        }

        public VendingMachinePackage VendingMachinePackage { get => vendingMachinePackage;}

        private void LoadFormData(List<VendingMachine> vendingMachines)
        {
            sizeComboBox.ItemsSource = Enum.GetValues(typeof(Size));
            vendingMachineComboBox.ItemsSource = vendingMachines;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            vendingMachinePackage = new VendingMachinePackage(
                senderTextBox.Text, (Size)sizeComboBox.SelectedItem, (VendingMachine)vendingMachineComboBox.SelectedItem);

            DialogResult = true;

            Close();  
         }
    }
}
