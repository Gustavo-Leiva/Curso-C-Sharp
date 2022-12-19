using System;

namespace Condicionales_Acumulador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acumulador y ContadorConvocados
            int edad = 18;
            int contador = 0;
            int acumulador =0;
            float promedio;
            int e1 =20, e2 =13, e3 = 30;
            

            if(e1 > edad )
            {
                contador++;
                acumulador += e1;

            }

            if(e2 > edad)
            {
               contador++;  
               acumulador += e2;   
            }

            if(e3 > edad)
            {
                contador++;
                acumulador += e3; 
            }

            promedio = acumulador/contador;
            Console.WriteLine("El conteo de edades mayores " + edad + " anios es de " + contador);
            Console.WriteLine("El promedio es " + promedio.ToString("0.00"));




        }
    }
}
