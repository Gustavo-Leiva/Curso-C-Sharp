using System;

namespace ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla 
              “Positivo” si el número es mayor a cero, “Negativo” si
              el número es menor a cero o “Cero” si el número es igual a cero.
           */
           
           float num;

           Console.WriteLine("Ingrese un numero: ");
           num = float.Parse(Console.ReadLine()); 
           
           if(num > 0)
                Console.WriteLine("Numero ingresado mayor a cero");
           else if (num < 0 )
                Console.WriteLine("Numero ingresado menor a cero");
           else             
                Console.WriteLine("Numero ingresado igual a cero");

           
            
           





        }
    }
}
