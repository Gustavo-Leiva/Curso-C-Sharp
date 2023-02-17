using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica3
{
    internal class Pokemon
    {

        public int Numero { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string  UrlImagen { get; set; }

        public Elemento Tipo { get; set; } //creo la property tipo
        public Elemento Debilidad { get; set; }//creo la property debibilidad

    }

}
