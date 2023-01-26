using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica7
{
    internal class Botella
    { 
        //capacidad maxima: 100
        // cantidadActual: inicia en cero
        //método de recarga: carga al 100% y devuelve el costo de recargar. 50 cada 100.


        //creo el constructor ( con datos)
        public Botella (string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100; //arranco con un capacidad de 100 no permito que sea modificada.
            cantidadActual = 0;
        }

        //creo el constructor vacio (esta sobre cargado)
        public Botella() { }


        //destructor
        ~Botella() 
        { 
            //La logica....
        }


        //Botella: capacidad, color, material (estas son las propiedades)
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        //property solo lectura para el material

        public string Material
        {
            get { return material; }
        }


        public int Capacidad
        {
            get { return capacidad; }
        }


        public int CantidadActual
        {
            get { return cantidadActual;}
        }
        //property lectura y escritura (metodo largo)
        //public int Capacidad 
        //{ 
        //    get { return capacidad} 
        //    set { capacidad = value;
        //    }        
        //}

        //Métodos 

        public float recargar()
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual; //calcula cuanto falta para llenar la botella.
                //100 50
                //dif
                float monto = dif * 50 / 100; //costo de cargar la botella al 100%
                cantidadActual += dif; //carga la botella para llevarla al 100%
                return monto; //retorna el monto de la carga de la botella
            }
            cantidadActual = 100;
            return 50;
        }



    }
}
