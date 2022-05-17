using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    public class TaxiInPropertyInjection
    {
        private IDelivery _injection { get; set; }
        public IDelivery Injection
        {
            get { return _injection; }
            set
            {
                _injection = value;
            }
        }
        public void LetsGo()
        {
            _injection.Transportation();
        }
    }
}
