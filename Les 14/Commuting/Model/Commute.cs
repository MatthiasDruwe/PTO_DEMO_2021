using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Commuting.Model
{
    public abstract class Commute
    {
        private int id;
        private string origin;
        private string destination;
        private DateTime date;

        protected Commute(string origin, string destination, DateTime date)
        {
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        protected Commute()
        {

        }

        [Key]
        public int Id { get => id; set => id = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Destination { get => destination; set => destination = value; }
        public DateTime Date { get => date; set => date = value; }

        public abstract double CalculateRefund();

        public override string ToString()
        {
            return $"{origin} -> {destination} ({date:g}): {CalculateRefund():€#.##}";
        }
    }
}
