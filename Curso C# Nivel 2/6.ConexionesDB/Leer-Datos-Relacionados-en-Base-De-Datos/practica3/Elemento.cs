using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3
{
    //creo una nueva clase Elemento a modelar
    internal class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public override string ToString() //sobreecribe el id por la descripcion.
        {
            return Descripcion;
        }
    }
}
