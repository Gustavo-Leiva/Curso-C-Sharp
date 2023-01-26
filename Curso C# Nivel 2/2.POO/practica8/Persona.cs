using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica8
{
    internal class Persona
    {

        //Persona: Edad, Sueldo, Nombre
        //Atributos o Miembros

        private int edad;
        private float sueldo;
        private string nombre;

        //constructor
        public Persona (string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad() 
        {
            return edad;
        }

        //Métodos
        public string saludar () 
        {
            return "Hola soy .... " + nombre;
        }


        //sobre carga de métodos (cambia la firma del método)

        public string saludar (string personaje)
        {
            return "Hola " + personaje + ", soy .... " + this.nombre; //este this es el puntero al atributo
        }


    }
}
