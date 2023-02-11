using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class AnimalDomestico : Animal
    {

        public string Nombre { get; set; }

        //aca sobreescribo el metodo toString.

        public override string ToString()
        {
            //return base.ToString(); //signfica que de mi padre ToString haga algo pero este es lo que hay que cambiar por otra cosa.

            return "Animal: " + Nombre;
        }
    }
}
