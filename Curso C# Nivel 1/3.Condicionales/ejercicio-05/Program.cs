using System;

namespace ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla 
            //cuáles son mayores a 100.

            int num1;
            int num2;
            int num3;
            int num4;
            int limite = 100;

            Console.WriteLine("Ingrese un numero:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero:");
            num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero:");
            num4 = int.Parse(Console.ReadLine());

            if (num1 > limite)
                Console.WriteLine("El primer numero ingresado " + num1 + "es mayor a 100");

            if (num2 > limite)
                Console.WriteLine("El segundo numero ingresado " + num2 + "es mayor a 100");

            if (num3 > limite)
                Console.WriteLine("El tercero numero ingresado " + num3 + "es mayor a 100");

            if (num4 > limite)
                Console.WriteLine("El cuarto numero ingresado " + num4 + "es mayor a 100");
        }
    }
}
