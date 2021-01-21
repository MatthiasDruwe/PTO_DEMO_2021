using System;
using System.Collections.Generic;
using System.Text;

namespace Commuting.Model
{
    class Train: Commute
    {
        private double ticketPrice;

        public Train(string origin, string destination, DateTime date, double ticketPrice):base(origin, destination, date)
        {
            this.ticketPrice = ticketPrice;
        }

        public Train(): base()
        {
                
        }

        public double TicketPrice { get => ticketPrice; set => ticketPrice = value; }

        public override double CalculateRefund()
        {
            return ticketPrice;
        }

        public override string ToString()
        {
            return "Train: " + base.ToString();
        }
    }
}
