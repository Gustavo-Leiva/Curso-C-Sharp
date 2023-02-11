using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Canario : AnimalDomestico, flyable
    {
        public string volar()
        {
            return "vuela como un canario" ;
        }
    }
}
