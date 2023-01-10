using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            //int float bool char
            //double, decimal, long, shor, string, datetime

            int a, b, c;
            float d, f;

            Console.WriteLine("Hola como va?");
            Console.WriteLine("ingrese un valor:");
            
            a = int.Parse(Console.ReadLine());
            b = 10;
            c = a + b;

            Console.WriteLine("El resultado es: " + c);
            Console.ReadKey();
        }
    }
}
