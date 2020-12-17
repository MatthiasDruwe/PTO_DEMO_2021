using System;
using System.Collections.Generic;
using System.Text;

namespace BpostClasses.Models
{
    public class VendingMachinePackage: Package
    {
        VendingMachine receivingVendingMachine;

        public VendingMachinePackage(string sender, Size size, VendingMachine receivingVendingMachine):base(sender, size)
        {
            this.receivingVendingMachine = receivingVendingMachine;
        }

        public VendingMachinePackage(string line, List<VendingMachine> vendingMachines):base(line)
        {
            string[] parts = line.Split(";");
            int id = Convert.ToInt32(parts[3]);

            foreach (VendingMachine item in vendingMachines)
            {
                if(item.Id == id)
                {
                    receivingVendingMachine = item;
                }
            }
        }

        public VendingMachine ReceivingVendingMachine { get => receivingVendingMachine; }

        public string ToCSV()
        {
            return $"VMP;{Sender};{Size};{receivingVendingMachine.Id};{Status}";
        }

        public override string ToString()
        {
            return $"{Sender} - {Size} - {receivingVendingMachine}";
        }
    }
}
