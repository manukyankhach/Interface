using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    public class TaxiInConstructorInjection
    {
        private IDelivery _injection;
        public TaxiInConstructorInjection(IDelivery injection)
        {
            _injection = injection;
        }
        public void LetsGo()
        {
            _injection.Transportation();
        }
    }
}
