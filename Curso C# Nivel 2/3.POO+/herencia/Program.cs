using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //La Herencia es una relacion entre clases (atributos que se repiten en varias clases)
            //como se repiten esos atributos se arman jerarquia(se crea una clase persona)


            //Persona > Lider > Developer > Tester

            //creo objetos

            Persona p1 = new Persona();
            p1.nombre = "Gustavo"; //se crea porque tiene las propiedades creadas en la clase persona.

            Developer d1 = new Developer();
            d1.nombre = "Maria"; //se crea porque tiene las propiedades relacionadas a la clase persona.
            Lider l1 = new Lider();


        }
    }
}
