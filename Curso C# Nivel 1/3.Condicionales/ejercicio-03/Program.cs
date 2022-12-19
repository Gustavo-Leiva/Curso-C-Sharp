using System;

namespace ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Una casa de video juegos otorga un descuento dependiendo del importe de la 
            //compra realizada según los siguientes valores:

              //Si el importe es menor a ARS 1000, no hay descuento.
              //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
              //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
              //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

              //paso 1: Declaro las variables.
              int montoMinimo = 1000;
              int montoLimite = 5000;
              float importeSinDescuento;
              float importeDescuentoUno;
              float importeDescuentoDos;
              float descuentoUno =  0.10F;
              float descuentoDos = 0.18F;



              //paso 2: Pido los valores.
              Console.WriteLine("Ingrese el valor del producto: ");
              importeSinDescuento = float.Parse(Console.ReadLine());

              //paso 3: realizo los calculos.
              importeDescuentoUno = importeSinDescuento - (importeSinDescuento * descuentoUno);
              importeDescuentoDos = importeSinDescuento - (importeSinDescuento * descuentoDos);

             // paso 4: preguntar el importe del producto, para ver si amerita o no el descuento.
            if(importeSinDescuento < montoMinimo)
                    Console.WriteLine("El producto no tiene descuento, monto a cobrar: " + importeSinDescuento); 

            else if(importeSinDescuento >= montoMinimo && importeSinDescuento < montoLimite)
                    Console.WriteLine("El valor del producto tiene un descuento del 10% y su valor neto de descuento es de:" + importeDescuentoUno.ToString("0.00"));
            
            else
                    Console.WriteLine("El valor del producto tiene un descuento del 18% y su valor neto de descuento es de:" + importeDescuentoDos.ToString("0.00"));
                        
        }
    }
}
