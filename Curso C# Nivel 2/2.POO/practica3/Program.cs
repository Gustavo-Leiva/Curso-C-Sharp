using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2da Clase
            //Clases, Objetos, Propiedades y Encapsulamiento.
            // Objetivo: crear la clase Auto con los atributos: Marca, Modelo, Precio;
            // utilizar atributos y propiedades (metodo corto, no requiere atributos)

            Auto[] autos = new Auto[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("ingrese datos del auto");
                
                Console.WriteLine("Ingrese Marca: ");
                autos[i].marca = (Console.ReadLine());

                Console.WriteLine("Ingrese Modelo (año): ");
                autos[i].modelo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Precio: ");
                autos[i].precio = float.Parse(Console.ReadLine());


            }
        }
    }
}
