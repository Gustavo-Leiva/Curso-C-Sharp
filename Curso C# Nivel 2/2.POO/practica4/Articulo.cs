using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    internal class Articulo
    {
        /**
         * Son Atributos
         **Codigo de articulo(3 digitos no correlativos)
         **Precio
         ** Código de marca(1 al 100)
        **/

        //artibutos
        private int codMarca;

        //propiedades metodo corto
        public int CodigoArticulo { get; set; }
        //public int CodigoArticulo { get;}  SI ELIMINO EL SETTER LA PROPIEDAD ES SOLO LECTURA.
        public float Precio { get; set; }


        //propiedades metodo largo
        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if(value > 0 && value <11)
                {
                    codMarca = value;
                }
                else
                {
                    codMarca = -1;

                }
            }


        }

    }
}
