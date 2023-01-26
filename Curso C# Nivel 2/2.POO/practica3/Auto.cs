using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3
{
    internal class Auto
    {
        //Auto: color, modelo, marca
        //utilizar atributos y propiedades (metodo corto, este metodo no requiere atributos)
        //la forma corta no permite el seteo y el getteo de datos. 


        //private string color;
        //private int modelo;
        //private string marca;

        public string marca { get; set; }
        public int modelo { get; set; }
        public float precio { get; set; }
    }
}
