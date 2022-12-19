namespace ejercicio_05;
class Program
{
    static void Main(string[] args)
    {
        /*
        5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla 
        si los mismos se encuentran ordenados de forma decreciente .
        */

        //Declaro las variables 
        int num1;
        int num2;
        int num3;
        int num4;
      

        // pido los valores
              
        Console.WriteLine("Ingrese un numero: ");
        num1 =int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese otro numero: ");
        num2 =int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese otro numero: ");
        num3 =int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese otro numero: ");
        num4 =int.Parse(Console.ReadLine());

        if(num1 > num2 && num2 > num3 && num3 > num4)
        {
            Console.WriteLine("se encuentran ordenados de forma decreciente .");
        }
        else
        {
            Console.WriteLine("NO, se encuentran ordenados de forma decreciente .");
        }


    }
}
