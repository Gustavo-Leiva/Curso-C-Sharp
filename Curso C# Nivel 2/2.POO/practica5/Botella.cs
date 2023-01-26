using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica5
{
    internal class Botella
    {
        //El constructor lo puedo crear al principio tiene el mismo nombre que la clase y puede recibir parametros o no.

        public Botella (string color, string material)
        {
            this.color = color;  //menciono que el color que recibo por parametro apunte al atributo color.
            this.material=  material;    
        }

        //sobre carga del constructor, volver a cargar el constructor con las mismas caracteristicas.

        public Botella ()
        {

        }


        //creacion del destructor.
        ~Botella()
        {
            //La logica
        }



        //Botella: capacidad, Color, Material
        //1er creo los atributos
        private int capacidad;
        private string color; //esta en color girs porque al crear el atributo no menciono que hacer si es de lectura y escritura o solo lectura.
        private string material;

        //2do creo las propiedades

        //creo la propiedad de lectura y escritura.
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }

        //creo las propiedad material solo lectura.
        public string Material 

        {
            get { return material; } 
        }

        

       
    }
}
