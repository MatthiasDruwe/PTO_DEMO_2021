using System;
using System.Collections.Generic;
using System.Text;

namespace Commuting.Model
{
    public abstract class Commute
    {
        private string origin;
        private string destination;
        private DateTime date;

        protected Commute(string origin, string destination, DateTime date)
        {
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public abstract double CalculateRefund();

        public virtual string ToCSVLine()
        {
            // Code om members van Commute over te zetten naar origin;destination;date

            return "";
        }

        public override string ToString()
        {
            return $"{origin} -> {destination} ({date:g}): {CalculateRefund():€#.##}";
        }

        public static Commute CreateCommuteFromCSVLine(string line)
        {

            // Split line op ;
            // Controle type + creeeren juiste object



            return new Car("to", "from", DateTime.Now, 5);
        }
    }
}
