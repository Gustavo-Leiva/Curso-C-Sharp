using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica9
{
    internal class Botella
    {
        //constructor de Botella.
        public Botella (string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }


        //Botella: Capacidad, color, material
        private string color;
        private string material;
        private int capacidad;
        private int cantidadActual;


        //Sobrecargar el constructor. cuando quiero crear una botella sin datos iniciales.
        public Botella() { }


        //Destructor
        ~Botella() 
        {
            //la lógica...
        }


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
            get { return cantidadActual; }
        }
        //property lectura y escritura (metodo largo)
        //public int Capacidad 
        //{ 
        //    get { return capacidad} 
        //    set { capacidad = value;
        //    }        
        //}

        //Métodos 

        //este metodo verifica cuanto esta cargado, recarga el 100% y muestra cuanto costo recargar la botella.
        public float recargar()
        {
            if (cantidadActual > 0)
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

        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            float monto =cantidad * 50 / 100;
            //100 50
            //cant  x = ??
            return monto;
        }



    }
}
