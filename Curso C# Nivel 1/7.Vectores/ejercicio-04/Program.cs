namespace ejercicio_04;
class Program
{
    static void Main(string[] args)
    {

        /*
        4.Una empresa comercializa 15 tipos de artículos y por cada venta realizada 
        genera un registro con los siguientes datos:
        -Número de Artículo(1 a 15)
        -Cantidad Vendida

        Puede haber varios registros para el mismo artículo y 
        el último se indica con número de artículo igual a 0.
        Se pide determinar e informar:
        
        a) El número de artículo que más se vendió en total.
        b) Los números de artículos que no registraron ventas.
        c) Cuantas unidades se vendieron del número de artículo 10.

        */

        int nroArticulo = 0;
        int cantidad = 0;
        int[] totalCantidadVendida = new int[15];
        int continuar = 1;

        for (int i = 0; i < 15; i++)
        {
            totalCantidadVendida[i] = 0;

        }



        while (continuar == 1)
        {

            //pedido
            Console.WriteLine("Ingrese el nro del articulo");
            nroArticulo = int.Parse(Console.ReadLine());

            //validacion
            while (nroArticulo <1 || nroArticulo >15)
            {
                Console.WriteLine("Error!! ingrese un articulo del 1 añ 15");
                nroArticulo = int.Parse(Console.ReadLine());

            }

            //pedido
            Console.WriteLine("Ingrese la cantidad vendida");
            cantidad = int.Parse(Console.ReadLine());
            totalCantidadVendida[nroArticulo - 1] += cantidad;

            //validacion    
            while (cantidad < 1)
            {
                Console.WriteLine("Error!! ingrese una cantidad mayor a 0");
                cantidad = int.Parse(Console.ReadLine());
                totalCantidadVendida[nroArticulo - 1] += cantidad;
            }



            Console.WriteLine("Si desea continuar 1; terminar 0");
            continuar = int.Parse(Console.ReadLine());

        }

        //punto A

        int maxCantidad = totalCantidadVendida[0];
        //int nroMaximo = 1;
        for (int i = 0; i < 15; i++)
        {
            if (totalCantidadVendida[i] > maxCantidad)
            {
                maxCantidad = totalCantidadVendida[i];
                nroArticulo = i + 1;
            }

        }

        Console.WriteLine("El producto mas vendido es el : " + nroArticulo + " con la cantidad de : " + maxCantidad);


        //punto B
        for (int i = 0; i < 15; i++)
        {
            if (totalCantidadVendida[i] == 0)
            {
                Console.WriteLine("El producto " + (i + 1) + " no tuvo ventas");
            }
        }


        //punto C
        Console.WriteLine("La cantidad vendida del articulo 10 es: " + totalCantidadVendida[9]);








    }
}
