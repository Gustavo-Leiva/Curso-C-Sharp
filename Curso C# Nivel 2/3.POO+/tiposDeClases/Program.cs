using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposDeClases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipos de clases: Estaticas, Abstractas, Selladas.
            //abstract internal class Persona ----- se antepone la palabra abstract a la clase para crear 
            //una clase abastracta de esa manera no se puede instanciar la clase Persona pero si sus clases hijas.
            //abstracta NO instancia


            //sealed internal class Persona ------ cuando se antepone la palabra sealied a la clase estoy indicando que 
            //las propiedades y metodos no puede heredar a otra clase.
            //sealed NO delega

            //La clase static se utiliza directamente nombreDeLaClase.algo();

            Persona p1 = new Persona();
            Developer d1 = new Developer();
            Lider l1 = new Lider();}

            Lider.algo();

            



        }
    }
}
