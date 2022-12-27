namespace ejercicio_04;
class Program
{
    static void Main(string[] args)
    {
        //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel 
        //aclaratorio si el mismo es primo o no es primo.  
        //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

        //resulto con el ciclo FOR
        int num = 0;
        int cont =0;

        Console.WriteLine("Ingrese un numero:");
        num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if(num % i == 0)
            {
                cont++;
            }
        }

        if(cont == 2)
        {
              Console.WriteLine("El valor ingresado es un numero primo:");
        }

        else
        {
             Console.WriteLine("El valor ingresado No es un numero primo:");
        }


    }
}
