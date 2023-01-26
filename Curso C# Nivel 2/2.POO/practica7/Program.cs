using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    internal class Program
    {
        //5. Metodos ejemplo 2
        static void Main(string[] args)
        {
            Botella b1 = new Botella("Rojo", "´Plástico");
            //b1.Capacidad = 200; No me permite la asignacion ya que fue cargado previamente en el constructor.

            Console.WriteLine("Capacidad Botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es " +  b1.CantidadActual);
            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad  es " + b1.CantidadActual);
            Console.ReadKey();


        }
    }
}
