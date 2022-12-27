namespace ejercicio_02_OpcionC;
class Program
{
    static void Main(string[] args)
    {
        //2. Hacer un programa que solicite el ingreso de 10 números y que muestre 
        //el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

        //resuelto con el ciclo Do While

        int i= 0;
        int num1 =0;
        int mayorValor =0;

        do
        {
            Console.WriteLine("Ingrese un numero:");
            num1 = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                mayorValor = num1;
            }
            else
            {
                if (num1 > mayorValor)
                {
                    mayorValor = num1;
                }

            }
            i++;
            
        } while (i < 10);    
              

        Console.WriteLine("El numero mayor es: " + mayorValor);
    }
}
