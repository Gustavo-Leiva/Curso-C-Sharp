using System;

namespace ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

            //paso 0 : declaro las variables
            int num1;
            int num2;
            int resultado;

            //paso 1: pido los datos y los guardo en memoria

            Console.WriteLine ("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine ("Ingrese otro numero: ");
            num2 = int.Parse(Console.ReadLine());




            //paso 2: calculo la la operacion de la

            resultado = num1 + num2;


            //paso 3: muestro el resultado.

            Console.WriteLine ("El resultado de la suma es: " + resultado);

        }
    }
}
