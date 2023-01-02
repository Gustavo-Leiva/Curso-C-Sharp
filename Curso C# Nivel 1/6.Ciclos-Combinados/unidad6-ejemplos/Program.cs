namespace unidad6_ejemplos;
class Program
{
    static void Main(string[] args)
    {
        //Ciclos combinados


        //For con For

        /*
        //pedir 20 edades de 10 equipos diferentes y calcular su promedio.
        float promedio;
        int num;

        for (int i = 0; i < 10; i++ )//vuelta por cada equipo
        
        {
            int acum = 0;
            //cargo edad de cada persona
            for( int j = 0; j < 20; j ++)
            {
                Console.WriteLine("ingrese la edad:");
                num = int.Parse(Console.ReadLine());
                acum += num;

            }

            promedio = acum/3;
            Console.WriteLine("El promedio es: " +  promedio.ToString("0.00"));
        }

        */

        //combinacion For con While

        //cargo la cantidad de personas hasta que no haya mas (desconozco la cantidad) para 10 equipos.

        /*
        int edad;
        float promedio;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Ingrese la edad");
            edad = int.Parse(Console.ReadLine());

            int acum = 0;
            int cont = 0;

            while (edad != 0)
            {
                acum += edad;
                cont++;
                Console.WriteLine("Ingrese la edad");
                edad = int.Parse(Console.ReadLine());
            }

            promedio = acum / cont;
            Console.WriteLine("El promedio es: " + promedio.ToString("0.00"));

      


        }
          */


        //combinacion  While con FOR

        //cargo la cantidad de personas hasta que no haya mas (desconozco la cantidad) para 10 equipos.

        /*
        int n;
        int acum;
        float promedio;

       
           
        Console.WriteLine("Ingrese 1 para continuar o 0 para terminar");
        n = int.Parse(Console.ReadLine());

        while (n != 0)
        {
            acum = 0;

            for (int i = 0; i < 20; i++)
            {
             
                Console.WriteLine("Ingrese la edad");
                n = int.Parse(Console.ReadLine());
                acum += n;

            }

            
            promedio = acum / 20;

            Console.WriteLine("El promedio es: " + promedio.ToString("0.00"));
            Console.WriteLine("Ingrese 1 para continuar o 0 para terminar");
            n= int.Parse(Console.ReadLine());

        }
        */



        //combinacion  While con While

        //cargo la cantidad de personas hasta que no haya mas (desconozco la cantidad de jugadores y equipos) .

        int n = 0;
        int acum = 0;
        int cont = 0;
        float promedio;


        Console.WriteLine("Ingrese la edad");
        n = int.Parse(Console.ReadLine());


        while (n > 0)

        {
            while (n != 0)
            {
                acum += n;
                cont++;

                Console.WriteLine("Ingrese la edad");
                n = int.Parse(Console.ReadLine());

            }


            promedio = acum / cont;
            Console.WriteLine("El promedio es: " + promedio.ToString("0.00"));

            Console.WriteLine("Ingrese la edad para continuar o un negativo para continuar");
            n = int.Parse(Console.ReadLine());

        }




    }
}
