using BpostClasses.Helper;
using BpostClasses.Models;
using PacketManager.Views;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace PacketManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<VendingMachine> vendingMachines;
        List<Package> packages;
        public MainWindow()
        {
            InitializeComponent();
            LoadVendingMachines();
            LoadPackages();
        }

        #region VendingMachine

        private void LoadVendingMachines()
        {
            vendingMachines = FileManager.LoadVendingMachines();
            foreach (VendingMachine item in vendingMachines)
            {
                VendingMachineListBox.Items.Add(item);
            }
        }

        private void newVendingMachineButton_Click(object sender, RoutedEventArgs e)
        {
            NewVendingMachineWindow newVendingMachineWindow = new NewVendingMachineWindow();
            
            if(newVendingMachineWindow.ShowDialog() == true)
            {
                VendingMachineListBox.Items.Add(newVendingMachineWindow.VendingMachine);
                FileManager.Save(newVendingMachineWindow.VendingMachine);
            }
        }

        private void editVendingMachineButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void deleteVendingMachineButton_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Packages

        private void LoadPackages()
        {
            packages = FileManager.LoadPackages(vendingMachines);
            foreach (Package item in packages)
            {
                ListBoxItem listBoxItem = CreatePackageItem(item);
                packageListbox.Items.Add(listBoxItem);
            }
        }

        private static ListBoxItem CreatePackageItem(Package item)
        {
            ListBoxItem listBoxItem = new ListBoxItem();
            listBoxItem.Content = item;
            switch (item.Status)
            {
                case PackageStatus.NotHome:
                    listBoxItem.Background = Brushes.Red;
                    break;
                case PackageStatus.Delivered:
                    listBoxItem.Background = Brushes.Green;
                    break;
            }

            return listBoxItem;
        }

        private void newVendingMachinePackageButton_Click(object sender, RoutedEventArgs e)
        {
            VendingMachinePackageWindow vendingMachinePackageWindow = new VendingMachinePackageWindow(vendingMachines);
            if(vendingMachinePackageWindow.ShowDialog() == true)
            {
                packageListbox.Items.Add(CreatePackageItem(vendingMachinePackageWindow.VendingMachinePackage));
                FileManager.Save(vendingMachinePackageWindow.VendingMachinePackage);
            }
        }

        private void newAddressPackageButton_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
