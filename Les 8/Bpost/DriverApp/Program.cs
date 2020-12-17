using BpostClasses.Helper;
using BpostClasses.Models;
using System;
using System.Collections.Generic;

namespace DriverApp
{
    class Program
    {
        static List<Package> packages;
        static List<VendingMachine> vendingMachines;
        static void Main(string[] args)
        {
            vendingMachines = FileManager.LoadVendingMachines();
            packages = FileManager.LoadPackages(vendingMachines);

            foreach (Package package in packages)
            {
                if (package.Status == PackageStatus.None)
                {
                    ProcessPackage(package);
                }
            }
            FileManager.Save(packages);

            Console.WriteLine("All packages delivered");
            Console.ReadKey();
        }

        private static void ProcessPackage(Package package)
        {
            Console.WriteLine($"Zender: {package.Sender}");
            Console.WriteLine($"Grootte: {package.Size}");
            switch (package)
            {
                case VendingMachinePackage vendingMachinePackage:
                    Display(vendingMachinePackage);
                    break;
            }

            string action = Console.ReadLine();
            Execute(action, package);

            Console.Clear();
        }

        private static void Execute(string action, Package package)
        {
            switch (action.ToUpper())
            {
                case "A":
                    // afgeleverd
                    package.Delivered();
                    break;
                case "X":
                    // Niet thuis
                    package.NotHome();
                    break;
                case "N":
                    //No Action
                    break;
            }
        }

        private static void Display(VendingMachinePackage vendingMachinePackage)
        {
            VendingMachine vendingMachine = vendingMachinePackage.ReceivingVendingMachine;
            Console.WriteLine();
            Console.WriteLine($"### Pakjes Automaat {vendingMachine.Name} ###");
            Console.WriteLine($"address: {vendingMachine.FullAddress}");
        }
    }
}
