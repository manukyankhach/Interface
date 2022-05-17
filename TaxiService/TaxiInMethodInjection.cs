using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    public class TaxiInMethodInjection
    {
        public void LetsGo(IDelivery delivery)
        {
            delivery.Transportation();
        }
    }
}
