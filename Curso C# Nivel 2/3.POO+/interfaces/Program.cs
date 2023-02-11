using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.INTERFACES

            //herencia multiple es cuando una clase hereda de varias clases al mismo tiempo. no aplica a C# 
            //las interfaces son las herramientas que permiten simular la herencia multiple en lenguajes que no 
            //permitan herencia multiple. eso es porque no permite heredar de muchas clases pero permite implementar varias interfaces.

            //una interface es un contrato que vamos a implementar en alguna clase y esa clase va a tner que cumplir lo que ese
            //contrato define. lo que define es comportamiento, define el "QUE" pero no el "COMO" eso lo define la clase.
            //Esa clase que implementa NO hereda esa interface debe contar un metodo con ese nombre
            //La finalidad del uso de la interface
            //1) hereda metodos de una clase, pero luego implemento interface (comportamiento de otras clases)
            //2) segmentar objetos. clasifico objetos por distinto patrones. 



            Gato g1 = new Gato();
            g1.Nombre = "PEPE";

            Perro p1 = new Perro();
            p1.Nombre = "negrito";

            //creo una lista de animales
            List<Animal> animales = new List<Animal>();

            //agrego animales
            animales.Add(p1);
            animales.Add(new Pez()); //estoy generando instancia directamente y las tiro en las listas
            animales.Add(new Canario()); //estoy generando instancia directamente y las tiro en las listas
            animales.Add(g1);
            animales.Add(new Aguila()); //estoy generando instancia directamente y las tiro en las listas
            animales.Add(new Gato());

            //creo una lista de voladores
            List<flyable> listaVoladores = new List<flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());
            listaVoladores.Add(new Perro()); //aca marca en rojo porque la clase Perro no tiene la interface flyable.








        }
    }
}
