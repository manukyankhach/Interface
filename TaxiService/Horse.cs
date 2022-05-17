using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    public class Horse : IDelivery
    {
        public void Transportation()
        {
            Console.WriteLine("Horse");
        }
    }
}
