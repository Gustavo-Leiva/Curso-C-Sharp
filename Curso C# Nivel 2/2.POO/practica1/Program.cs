using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2da Clase
            // Clases, Objetos, Propiedades y Encapsulamiento.
            // Objetivo: crear la clase persona con los atributos: Edad, Sueldo, Nombre;
            // utilizar atributos y metodos setters y getters.


            //5to creo los objetos
            Persona pers1 = new Persona();
            Persona pers2 = new Persona();

            //6to seteo el dato.
            pers1.setEdad(20);
            pers2.setEdad(35);

            //7mo muestro info por consola
            Console.WriteLine("La edad de la persona 1 es " + pers1.getEdad() + " años");
            Console.WriteLine("La edad de la persona 2 es " + pers2.getEdad() + " años");


            //cierro el programa
            Console.ReadKey();

        }
    }
}
