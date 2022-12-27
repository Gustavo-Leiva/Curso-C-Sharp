namespace ejercicio_04_OpcionB;
class Program
{
    static void Main(string[] args)
    {
        //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel 
        //aclaratorio si el mismo es primo o no es primo.  
        //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

        //resulto con el ciclo WHILE
        int num = 0;
        int i = 2;
        bool band = true;

        Console.WriteLine("Ingrese un numero:");
        num = int.Parse(Console.ReadLine());


        while ((i < num) && (band == true))
        {

            if ((num % i) == 0)
            {
                band = false;
            }
            else
            {
                i++;
            }           

        }


        if (band == true)
        {
            Console.WriteLine("El valor ingresado es un numero primo:");
        }

        else
        {
            Console.WriteLine("El valor ingresado No es un numero primo:");
        }
    }
}
