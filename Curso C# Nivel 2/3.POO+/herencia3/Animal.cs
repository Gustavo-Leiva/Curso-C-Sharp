using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Animal
    {
        //para que el metodo sea sobreescribible necesito agregar la leyenda virtual.....
        public virtual string comunicarse() 
        {
            return "ruido...ruido";
        }
    }
}
