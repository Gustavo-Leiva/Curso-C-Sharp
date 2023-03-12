using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon
    {
        //video 8 cap 1
        public int Id { get; set; }

        //video 7 anotacions
        [DisplayName ("Número")]
        public int Numero { get; set; }

        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public string UrlImagen { get; set; }

        public Elemento Tipo { get; set; }

        public Elemento Debilidad { set; get; }

    }
}
