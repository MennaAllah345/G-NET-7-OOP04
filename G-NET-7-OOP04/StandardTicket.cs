using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP04
{
    internal class StandardTicket : Ticket
    {
        public string SeatNumber { get; set; }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"\nSeat: {SeatNumber}");
        }
    }
}
