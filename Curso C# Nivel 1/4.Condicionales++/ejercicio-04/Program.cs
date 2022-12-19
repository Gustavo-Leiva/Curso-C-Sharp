namespace ejercicio_04;
class Program
{
    static void Main(string[] args)
    {
       /*
       4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
       si la suma de los dos primeros es mayor al producto del segundo con el tercero.

       */

        //Declaro las variables 
        int num1;
        int num2;
        int num3;
        int suma;
        int producto;

        // pido los valores
              
        Console.WriteLine("Ingrese un numero: ");
        num1 =int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese otro numero: ");
        num2 =int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese otro numero: ");
        num3 =int.Parse(Console.ReadLine());

        //calculo las operaciones
        suma = num1 + num2;
        producto = num2*num3;

        //logica
        if(suma > producto)
        {
            Console.WriteLine("la suma de los dos primeros es mayor al producto del segundo con el tercero.");
        }



    }
}
