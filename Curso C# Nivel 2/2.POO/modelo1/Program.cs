using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace modelo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Alumno a1 = new Alumno();

            a1.setNombre("Gustavo");
            Console.WriteLine("El nombre del alumno es "+ a1.getNombre());


            a1.Edad = 20;
            Console.WriteLine("La edad del alumno es " + a1.Edad);

            a1.Nota = (float)7.5;
            Console.WriteLine("La nota del alumno es " + a1.Nota);


            Console.ReadKey();



        }
    }
}
