using BpostClasses.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace BpostClasses.Helper
{
    public class FileManager
    {
        static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "bpost");
        static string vendingMachineFile = "vendingMachine.csv";
        static string packageFile = "packages.csv";

        public static void Save(VendingMachine vendingMachine)
        {
            StreamWriter streamWriter = File.AppendText(Path.Combine(path, vendingMachineFile));
            streamWriter.WriteLine(vendingMachine.ToCSV());
            streamWriter.Close();
        }

        public static void Save(VendingMachinePackage vendingMachinePackage)
        {
            StreamWriter streamWriter = File.AppendText(Path.Combine(path, packageFile));
            streamWriter.WriteLine(vendingMachinePackage.ToCSV());
            streamWriter.Close();
        }

        public static void Save(List<Package> packages)
        {
            File.Delete(Path.Combine(path, packageFile));
            foreach (Package package in packages)
            {
                if(package is VendingMachinePackage)
                {
                    Save((VendingMachinePackage)package);
                }
            }
        }

        public static List<VendingMachine> LoadVendingMachines()
        {
            StreamReader streamReader = File.OpenText(Path.Combine(path, vendingMachineFile));
            string line = streamReader.ReadLine();
            List<VendingMachine> vendingMachines = new List<VendingMachine>();

            while (line != null)
            {
                VendingMachine vendingMachine = new VendingMachine(line);
                vendingMachines.Add(vendingMachine);
                line = streamReader.ReadLine();
            }

            streamReader.Close();

            return vendingMachines;
        }

        public static List<Package> LoadPackages(List<VendingMachine> vendingMachines)
        {
            StreamReader streamReader = File.OpenText(Path.Combine(path, packageFile));
            string line = streamReader.ReadLine();
            List<Package> packages = new List<Package>();

            while (line != null)
            {
                if (line.StartsWith("VMP"))
                {
                    VendingMachinePackage vendingMachinePackage = new VendingMachinePackage(line, vendingMachines);
                    packages.Add(vendingMachinePackage);
                }
                else if (line.StartsWith("AP"))
                {

                }

                line = streamReader.ReadLine();
            }

            streamReader.Close();

            return packages;
        }
    }
}
