using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coleccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo > Auto > AutoDeportivo > AutoUrbano
            //>Camioneta
            //>Moto

            /* Temas vistos de colecciones.
             * Crear coleccion tipo lista
             * Recorrer, agregar, eliminar, modificar (de a uno)
             */

            Vehiculo v1 = new Vehiculo();

            //creo una camioneta
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Color = "Amarillo";
            c2.Color = "Roja";
            c3.Color = "Blanca";

            //Crear una coleccion
            List<Camioneta> listaCamioneta = new List<Camioneta>();

            //agrego las camionetas a listados.
            listaCamioneta.Add(c1);
            listaCamioneta.Add(c2);
            listaCamioneta.Add(c3);

            //contar la cantidad de camionetas 
            //Console.Write("La cantidad de camionetas es: " + listaCamioneta.Count + "\n");

            //listaCamioneta[1].Color = "verde";

            //elegir un elemento
            //Console.Write("El color de la camioneta del segundo lugar es: " + listaCamioneta[1].Color + "\n");

            //listaCamioneta.Remove(c3);
            //Console.Write("La cantidad de camionetas es: " + listaCamioneta.Count + "\n");


            //usamos el foreach para recorrer una coleccion.
            foreach (Camioneta item in listaCamioneta)
            {
                Console.WriteLine("Color: " + item.Color);
            }

            Console.ReadKey();
        }
    }
}
