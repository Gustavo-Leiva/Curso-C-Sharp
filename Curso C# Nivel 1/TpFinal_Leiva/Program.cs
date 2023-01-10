namespace TpFinal_Leiva;
class Program
{
    static void Main(string[] args)
    {
        //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
        //A partir de dichos datos informar:

        //a. El mayor de los números pares.
        //b. La cantidad de números impares.
        //c. El menor de los números primos.

        //Nota: evaluar el uso de una función que analice si un número dado es primo o no 
        //y que devuelva true o false según corresponda.

        int n;
        int mayorPar = 0;
        int contImpares = 0;
        int menorPrimos = 0;
        

        Console.WriteLine("Ingrese un numero: ");
        n = int.Parse(Console.ReadLine());




        while (n != 0)
        {

            //a) pares    
            if (n % 2 == 0)
            {
                mayorPar = n;
                if (n > mayorPar)
                    mayorPar = n;
            }


            //b) impares
            else
            {
                if (n % 2 != 0)
                    contImpares++;
            }



            //c) primos
            if (primos(n))
            {
                if (n < menorPrimos || menorPrimos == 0)
                    menorPrimos = n;
            }

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("El mayor de los numeros pares es: " + mayorPar);
        Console.WriteLine("La cantidad la cantidad de numeros impares es " + contImpares);
        Console.WriteLine("El menor de los numeros primos es " + menorPrimos);


    }

    //funcion determinar si un numero es primo o no
    static bool primos(int num)
    {

        int cont = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                cont++;
        }

        if (cont == 2)
            return true;
        else
            return false;

    }
}
