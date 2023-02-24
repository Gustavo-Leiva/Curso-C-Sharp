using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitectura_en_Capas
{
    public class Elemento
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }

    }
}
