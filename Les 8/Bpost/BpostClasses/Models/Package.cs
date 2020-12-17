using System;
using System.Collections.Generic;
using System.Text;

namespace BpostClasses.Models
{
    public class Package
    {
        string sender;
        Size size;
        PackageStatus status = PackageStatus.None;


        public Package(string sender, Size size)
        {
            this.sender = sender;
            this.size = size;
        }

        public Package(string line)
        {
            string[] parts = line.Split(";");
            sender = parts[1];
            size = (Size)Enum.Parse(typeof(Size), parts[2]);
            status = parts.Length < 5 ? PackageStatus.None : (PackageStatus)Enum.Parse(typeof(PackageStatus), parts[4]);
        }

        public string Sender { get => sender; set => sender = value; }
        public Size Size { get => size; set => size = value; }
        public PackageStatus Status { get => status; set => status = value; }

        public void Delivered()
        {
            status = PackageStatus.Delivered;
        }

        public void NotHome()
        {
            status = PackageStatus.NotHome;
        }
    }
}
