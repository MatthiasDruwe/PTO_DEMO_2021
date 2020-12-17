using System;
using System.Collections.Generic;
using System.Text;

namespace BpostClasses.Models
{
    public class VendingMachine
    {

        #region private members
        static int new_id = 0;

        private int id;
        private string name;
        private string street;
        private string number;
        private int postalCode;
        private string city;

        #endregion

        #region constructors

        public VendingMachine(string name, string street, string number, int postalCode, string city)
        {
            this.name = name;
            this.street = street;
            this.number = number;
            this.postalCode = postalCode;
            this.city = city;
            id = new_id;
            new_id++;
        }

        public VendingMachine(string line)
        {
            string[] parts = line.Split(";");
            id = Convert.ToInt32(parts[0]);
            name = parts[1];
            street = parts[2];
            number = parts[3];
            postalCode = Convert.ToInt32(parts[4]);
            city = parts[5];

            new_id = id >= new_id ? id + 1 : new_id;
        }
        #endregion

        #region properties

        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public string Number { get => number; set => number = value; }
        public int PostalCode { get => postalCode; set => postalCode = value; }
        public string City { get => city; set => city = value; }
        public int Id { get => id;}
        public string FullAddress {
            get
            {
                return $"{street} {number}, {postalCode} {city}";
            }
        }

        #endregion

        #region public methods

        public string ToCSV()
        {
            return $"{id};{name};{street};{number};{postalCode};{city}";
        }

        public override string ToString()
        {
            return name;
        }
        #endregion
    }
}
