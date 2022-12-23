namespace ejercicio_02;
class Program
{
    static void Main(string[] args)
    {
        //2. Hacer un programa que solicite el ingreso de 10 números y que muestre 
        //el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.


        //resuelto con el ciclo FOR
        
        int num1 =0;
        int mayorValor =0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero:");
            num1 = int.Parse(Console.ReadLine());
            if (num1 > mayorValor)
            {
                mayorValor = num1;
            }
        }

        Console.WriteLine("El numero mayor es: " + mayorValor);

    }
}
