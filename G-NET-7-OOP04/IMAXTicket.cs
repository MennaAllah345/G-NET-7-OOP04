using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP04
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"\nIMAX 3D: {(Is3D ? "Yes" : "No")}");
        }
    }
}
