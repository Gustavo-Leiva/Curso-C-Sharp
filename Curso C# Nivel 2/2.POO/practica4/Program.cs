using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            3era clase. 
            Clases y Objetos: Ejemplo Ventas
            Primer lote con 10 registros de productos, cada producto tiene:
            **Codigo de articulo(3 digitos no correlativos)
            **Precio
            **Código de marca (1 al 100)

            Segundo lotes con las ventas de la semana. Cada venta tiene: 
            **Codigo de articulo
            **Cantidad
            **Código de cliente

            Este lote corta con Código de Cliente cero.
            
             */

            Articulo[] articulos = new Articulo[10];//vector.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese los datos del producto... ");

                Console.WriteLine("Codigo: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Precio");
                articulos[i].Precio = float.Parse(Console.ReadLine());

                Console.WriteLine("Marca ( 1 a 10)");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
            }

            //termina el ciclo y tengo cargado el vector completo con los 10 articulos.
            
            
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta");

            Console.WriteLine("Ingrese Codigo Cliente");
            venta.CodigoCliente = int.Parse(Console.ReadLine());


            while (venta.CodigoCliente != 0)
            {

                Console.WriteLine("Código Artículo");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Cantidad");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos...

                //pido cliente nuevamente.
                Console.WriteLine("Ingrese la venta");

                Console.WriteLine("Ingrese Codigo Cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }
        }
    }
}
