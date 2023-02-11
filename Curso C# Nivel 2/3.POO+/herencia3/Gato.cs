using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Gato : AnimalDomestico
    {

        //aca sobreescribo el metodo animal de comunicarse.

        public override string comunicarse()
        {
            return "Miau...miau.....";
        }
    }
}
