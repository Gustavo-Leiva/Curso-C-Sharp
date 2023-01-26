using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    
    internal class Persona //1ero creo la Clase
    {            
        

        //2do  Creo los atributos (utilizo los modificadores de visibilidad: public, private, internal, protegido)
        private int edad;
        private float sueldo;
        private string nombre;


        //3ero Creo lo setters        
        public void setEdad(int e)
        {
            edad = e;
        }

        public void setSueldo(float s)
        {
            sueldo = s;
        }

        public void setNombre(string n)
        {
            nombre = n;

        }


        //4to crear los getters.
        public int getEdad()
        {
            return edad;
        }

        public float getSueldo()
        {
            return sueldo;
        }

        public string getNombre()
        {
            return nombre;
        }



    }
}
