using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica6
{
    //Persona: Edad, Sueldo, Nombre
    //Atributos o Miembros
   
    internal class Persona
    {
        private int edad;
        private float sueldo;
        private string nombre;

        //constructor
        public Persona (string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad( int e)
        {
            edad = e;
        }

        public int getEdad() 
        {
          return edad;
        }

        //Métodos (tiene que se public para que los pueda llamar desde el main)
        public string saludar()
        {
            return "Hola Soy... " + nombre;
        }
    }
}
