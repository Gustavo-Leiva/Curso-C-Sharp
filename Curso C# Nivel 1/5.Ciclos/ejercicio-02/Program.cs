namespace ejercicio_02;
class Program
{
    static void Main(string[] args)
    {
        //2. Hacer un programa que solicite el ingreso de 10 números y que muestre 
        //el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.


        //resuelto con el ciclo FOR

        int num;
        int mayorValor = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero:");
            num = int.Parse(Console.ReadLine());

            if (i == 0)
            {
                mayorValor = num;
            }
            else
            {
                if (num > mayorValor)
                {
                    mayorValor = num;

                }

            }

        }

        Console.WriteLine("El numero mayor es: " + mayorValor);

    }
}
