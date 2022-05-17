using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    public class Bicycle : IDelivery
    {
        public void Transportation()
        {
            Console.WriteLine("Bicycle");
        }
    }
}
