namespace ejercicio_01;
class Program
{
    static void Main(string[] args)
    {
        //1. Hacer un programa para ingresar 10 números. 
        //El mismo debe analizar y mostrar 
        //por pantalla cuántos de esos números son primos.

        int num = 0;
        int contPrimos = 0;

        for (int i = 0; i < 10; i++)//aca recorro el ingreso 10 numeros
        {

            Console.WriteLine("Ingrese un numero: ");//aca pido el numero 
            num = int.Parse(Console.ReadLine());

            int cont = 0;
            for (int j = 1; j <= num; j++)
            {

                if (num % j == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {

                contPrimos++;
            }


        }


        Console.WriteLine("La cantidad de numeros primos es: " + contPrimos);
    }
}
