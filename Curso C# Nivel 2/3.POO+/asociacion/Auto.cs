using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacion
{
    internal class Auto : Vehiculo
    {
        //constructor

        public Auto() 
        {
            Chasis = new Chasis();
        
        }
        public int Anio { get; set; }
        public int Modelo { get; set; }

        public  string Color { get; set; }




        //asociacion x Composicion
        public Chasis Chasis { get; set; }


        //asociacion x Agregacion
        public Motor Motor { get; set; }

    }
}
