using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4ta. Constructores y Destructores
            //Son funciones que se ejecutan en un lapso de vida del objeto.
            //son funciones que reciben variables iniciales, cargarlos en mis atributos. 

            //Clases, Objetos, Propiedades y Encapsulamiento.
            // Objetivo: crear la clase botella con los atributos: Capacidad, Color, Material;
            // utilizar atributos y propiedades (metodo largo)


            //aca creo el objeto Botella con el constructor con los valores.
            Botella b1 = new Botella ("rojo", "plástico");//le indico datos al parametro porque en el constructor lo indique.
            b1.Capacidad = 200;


            //aca creo el objeto Botella con el constructor vacio
            Botella b2 = new Botella();

            //Botella b3; //creo una varible de tipo Botella vacia que reserva espacio en memoria.


            Console.WriteLine("La botella tiene una capacidad de " + b1.Capacidad + " ML  y es del material " + b1.Material);

            Console.ReadKey();
        }
    }
}
