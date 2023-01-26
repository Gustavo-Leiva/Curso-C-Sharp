using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    //6.Sobre carga de Métodos (ejemplo botella)
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella b1= new Botella("Rojo", "Plástico");
            Console.WriteLine("Capacidad Botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad  es " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad  es " + b1.CantidadActual);
            
            Console.ReadKey();


        }
    }
}
