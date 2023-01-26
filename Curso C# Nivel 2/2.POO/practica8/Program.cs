using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    //6.Sobre carga de Métodos (ejemplo persona)
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pepe");
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("Gus"));
            Console.ReadKey();

        }
    }
}
