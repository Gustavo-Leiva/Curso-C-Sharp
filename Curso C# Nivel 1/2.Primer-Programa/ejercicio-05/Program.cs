using System;

namespace ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un 
            //alumno y luego calcule y emita por pantalla el promedio final.

            //paso 0: declaro las variables
            float nota1;
            float nota2;
            float nota3;
            float promedio;

            //paso 2: pido datos y guardo en memoria.
            Console.WriteLine("Ingrese nota 1: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nota 2: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nota 3: ");
            nota3 = float.Parse(Console.ReadLine());

            



            //paso 3: calculo los datos para

            promedio = (nota1 + nota2 + nota3)/3;


            //paso 4: muestro el resultado
            Console.WriteLine("El promedio de las notas es " + promedio.ToString("0.00"));

        }
    }
}
