using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehiculo > Auto > AutoDeportivo >  AutoUrbano
            //> Camioneta
            //> Moto

            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();

            Vehiculo v2; //con esto creo la variable y no tiene el objeto adentro.
            v2 = new Camioneta(); //puedo guardar un objeto camioneta en una variable dentro de la clase vehiculo
                                  // porque son de las mismas familias.

            Vehiculo v3 = new Auto();
            Camioneta c2 = new Auto(); //tira error porque camioneta no esta dentro de la familia de auto sino de vehiculo
        }
    }
}
