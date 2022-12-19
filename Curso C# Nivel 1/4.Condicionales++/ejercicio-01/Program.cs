namespace ejercicio_01;
class Program
{
    static void Main(string[] args)
    {
        /*
        1.Hacer un programa que solicite el ingreso de dos números y luego calcular:

            La resta si el primero es mayor que el segundo.
            La suma si son iguales.
            El producto si el primero es menor.

            Se deberá emitir un cartel por pantalla con el resultado correspondiente.
        */

        //Declaro las variables
        int num1;
        int num2;
        int resta;
        int suma;
        int multiplicacion;

        //pido los datos que
        Console.WriteLine("Ingrese un numero: ");
        num1 = int.Parse(Console.ReadLine());

        
        Console.WriteLine("Ingrese otro numero: ");
        num2 = int.Parse(Console.ReadLine());

        //calculo aritmetico
        resta= num1 - num2;
        suma = num1 + num2;
        multiplicacion = num1 * num2;

        //logica
        if(num1 > num2)
            Console.WriteLine("La resta de ambos numeros: " +  resta);
        else
        {
            if(num1 == num2)
                Console.WriteLine("La suma de ambos numeros es " + suma);
            
            else
              if(num1 < num2)
                Console.WriteLine("El producto de ambos numeros es " + multiplicacion);


        }






    }
}
