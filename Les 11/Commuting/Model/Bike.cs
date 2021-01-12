using System;
using System.Collections.Generic;
using System.Text;

namespace Commuting.Model
{
    class Bike: Commute
    {

        private double distance;

        public Bike(string origin, string destination, DateTime date, double distance):base(origin, destination, date)
        {
            this.distance = distance;
        }

        public override double CalculateRefund()
        {
            double refund = 0.5 * distance;
            refund = Math.Min(refund, 20.0);

            return refund;
        }

        public override string ToString()
        {
            return "Bike: " + base.ToString();
        }
    }
}
