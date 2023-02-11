using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo1
{
    internal class Alumno
    {
        //atributos
        private string nombre;
        private int edad;
        private float nota;

        //metodos (setter y getter)


        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string n)
        {
            nombre = n;
        }

        public int Edad 
        { 
            get { return edad; } 
            set { edad = value; } 
        
        }

        public float Nota
        {
            get { return nota; }
            set { nota = value;}
        }

    }
}
