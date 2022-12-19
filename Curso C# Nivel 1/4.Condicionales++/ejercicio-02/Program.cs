namespace ejercicio_02;
class Program
{
    static void Main(string[] args)
    {
        /* 
        2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad 
        de litros vendidos según la siguiente escala:

            Si vende menos de 100 litros, no hay descuento.
            Si vende entre 101 y 300 litros, el descuento es del 10%.
            Si vende entre 301 y 500 litros, el descuento es del 15%.
            Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            Hacer un programa que solicite el ingreso del importe total de la venta y 
            la cantidad de litros vendidos y calcule y emita el importe con el descuento  
            aplicado..

        */


        //datos declaro las variables
        int litros;
        float precio;
        float tasaDesc1 = 0.10F;
        float tasaDesc2 = 0.15F;
        float tasaDesc3 = 0.25F;

        float descuento1;
        float descuento2;
        float descuento3;


        float montoNeto1;
        float montoNeto2;
        float montoNeto3;





        //pedir datos
        Console.WriteLine("Ingrese cantidad de litros vendidos: ");
        litros = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese precio Total de venta: ");
        precio = float.Parse(Console.ReadLine());


        //calculo aritmeticos;

        //calculo de los descuentos
        descuento1 = precio * tasaDesc1;
        descuento2 = precio * tasaDesc2;
        descuento3 = precio * tasaDesc3;

        //calculo el producto con descuento;
        montoNeto1 = precio - descuento1;
        montoNeto2 = precio - descuento2;
        montoNeto3 = precio - descuento3;


        //logica


        if (litros > 500)
        {
            Console.WriteLine("El valor neto con descuento del 25% es de: " + montoNeto3);
        }

        else
        {
            if (litros > 300 && litros < 501)
            {
                Console.WriteLine("El valor neto con descuento del 15% es de :" + montoNeto2);
            }

            else
            {
                if (litros > 100 && litros < 301)
                {
                    Console.WriteLine("El valor neto con descuento del 10% es de : " + montoNeto1);
                }

                else
                {
                    Console.WriteLine("El producto sin descuento es de :" + precio);
                }
            }
        }





       
        

    }
}
