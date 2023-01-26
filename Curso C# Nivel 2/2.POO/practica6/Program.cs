using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace practica6
{
    internal class Program
    {
        //5.Metodos - ejemplo 1
        //metodos son funciones que aplican pura y exlcusivamente a una clase 
        static void Main(string[] args)
        {
            Persona p1 = new Persona("PEPE");

            Console.WriteLine(p1.saludar());
            Console.ReadKey();
        }
    }
}
