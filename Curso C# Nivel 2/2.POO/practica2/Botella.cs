using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica2
{
    internal class Botella
    {
        //Botella: capacidad, Color, Material

        //1er creo los atributos
        private int capacidad;
        private string color;
        private string material;

        //2do creo las propiedades
       public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value;}
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Material
        {
            get { return material; }
            set { material = value;}
        }
    }
}
