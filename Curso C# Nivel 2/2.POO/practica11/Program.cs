using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica11
{
    internal class Program
    {
        //8.Clase String
        static void Main(string[] args)
        {

            string nombre = "Gus";

            nombre = "Hola como estas? " + nombre;

            int cant = nombre.Length;

            nombre = nombre.Replace('a', 'e'); 

            Console.WriteLine(nombre);
            nombre = Console.ReadLine();

        }
    }
}
