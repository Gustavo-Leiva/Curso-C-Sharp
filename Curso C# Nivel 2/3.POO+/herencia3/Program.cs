using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Sobreescritura de metodos
            //La Sobreescritura de metodos es cuando escribo reescribo un metodo que viene por herencia.
            //Polimorfismo es la caracteristica que tienen los objetos de frente a un mismo estimulo responden de manera distinta.

            //Animal a1 = new Animal();
            //AnimalDomestico a1= new AnimalDomestico();
            //a1.nombre = "PEPE";

            //Console.WriteLine(a1.ToString());


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



            //siempre hago el mismo estimulo en este caso comunicarse y cada objeto se comporta de manera diferente.
            //sobreescritura de metodos y polimorfismo van de la mano.

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }


            //Animal a1 = g1; //direcciono el nombre de g1(es un gato) a a1

            //Gato g8 = (Gato)a1; //casteo 
            //g8.Nombre = "Blanquito";

            //Console.WriteLine(g8);

            //Console.WriteLine(g1.comunicarse());
            //Console.WriteLine(p1.comunicarse());

            
            Console.ReadKey();

        
        
        }
    }
}
