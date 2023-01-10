using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //funciones
            //"texto"
            Console.WriteLine(saludar ("Gus"));
            //Console.ReadKey();

            
            int resultado = sumar(2, 4);
            Console.WriteLine("La suma es : " + resultado);
            Console.ReadKey();



        }

        static int sumar (int a, int b)

        { 
            return a + b; 
        }

        static string saludar (string nombre)
        {
            return "hola " + nombre;
        }
    }
}
