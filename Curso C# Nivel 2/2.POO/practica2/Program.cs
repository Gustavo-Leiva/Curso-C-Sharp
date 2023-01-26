using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2da Clase
            //Clases, Objetos, Propiedades y Encapsulamiento.
            // Objetivo: crear la clase botella con los atributos: Capacidad, Color, Material;
            // utilizar atributos y propiedades (metodo largo)

            Botella b1 = new Botella();

            b1.Capacidad = 200;
            b1.Color = "azul";
            string dato = b1.Color;

            Console.WriteLine("La botella tiene una capacidad de " + b1.Capacidad + " ML  y es de color " + dato);

            Console.ReadKey();
        }
    }
}
