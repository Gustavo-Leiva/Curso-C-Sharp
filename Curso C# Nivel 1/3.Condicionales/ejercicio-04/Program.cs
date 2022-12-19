using System;

namespace ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar cuatro números distintos y 
            //luego mostrar por pantalla el menor de ellos.

            //Declaro las variables.
            int numUno;
            int numDos;
            int numTres;
            int numCuatro;

            //Pido los valores
            Console.WriteLine("Ingrese primer numero: ");
            numUno = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese segundo numero: ");
            numDos = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tercer numero: ");
            numTres = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cuarto numero: ");
            numCuatro = int.Parse(Console.ReadLine());

            //realizo el procedimiento para determinar el menor valor y muestro el mensaje.
            if (numUno < numDos)
            {
                if (numUno < numTres)
                {
                    if (numUno < numCuatro)
                    {
                        Console.WriteLine("El numero menor es : " + numUno);
                    }
                }

                else
                {
                    if (numTres < numCuatro)
                    {
                        Console.WriteLine("El numero menor es : " + numTres);
                    }

                    else
                    {
                        Console.WriteLine("El numero menor es : " + numCuatro);

                    }
                }

            }


            else
            {
                if (numDos < numTres)
                {
                    if (numDos < numCuatro)
                    {
                        Console.WriteLine("El numero menor es : " + numDos);
                    }

                    else
                    {
                        Console.WriteLine("El numero menor es : " + numCuatro);
                    }
                }

                else
                {
                    if (numTres < numCuatro)
                    {
                        Console.WriteLine("El numero menor es : " + numTres);
                    }

                    else
                    {
                        Console.WriteLine("El numero menor es : " + numCuatro);
                    }
                }

            }

        }

    }
}







