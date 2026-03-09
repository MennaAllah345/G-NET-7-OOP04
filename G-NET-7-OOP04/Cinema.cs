using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP04
{
    internal class Cinema
    {
        private Ticket[] tickets = new Ticket[10];
        private int count = 0;

        public void OpenCinema()
        {
            Console.WriteLine("======== Cinema Opened ========");
            Console.WriteLine("Projector started.\n");
        }

        public void CloseCinema()
        {
            Console.WriteLine("\n======== Cinema Closed ========");
            Console.WriteLine("Projector stopped.");
        }

        public void AddTicket(Ticket t)
        {
            tickets[count++] = t;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("======== All Tickets ========");

            for (int i = 0; i < count; i++)
            {
                tickets[i].PrintTicket();
                Console.WriteLine();
            }
        }

        public static void ProcessTicket(Ticket t)
        {
            Console.WriteLine("\n======== Process Single Ticket ========");
            t.PrintTicket();
        }
    }
}
