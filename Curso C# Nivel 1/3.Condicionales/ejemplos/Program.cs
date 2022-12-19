using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 25;

            if (edad > 30)
            {
                Console.WriteLine("30 Off");
            }

            else if (edad > 20)
            {
                Console.WriteLine("21 Off");
            }

            else
            {
                Console.WriteLine("10 Off");
            }

            Console.WriteLine("Fin del programa");

        }
    }
}
