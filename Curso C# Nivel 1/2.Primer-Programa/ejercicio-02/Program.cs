using System;

namespace ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

            //paso 0 : declaro las variables
            int num1;
            int resultado;

            //paso 1: pido los datos y los guardo en memoria
            Console.WriteLine ("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());

            

            //paso 2: calculo la la operacion de la
            resultado = num1 * num1 * num1;


            //paso 3: muestro el resultado.
            Console.WriteLine ("El resultado de elevar " + num1 + " al cubo es: " + resultado);
        }
    }
}
