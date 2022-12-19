namespace ejercicio04bis;
class Program
{
    static void Main(string[] args)
    {
        //(segunda alternativa)
        //4. Hacer un programa para ingresar cuatro números distintos y 
        //luego mostrar por pantalla el menor de ellos. 

        //Declaro las variables.
        int num1;
        int num2;
        int num3;
        int num4;
        int minimo;


        //Pido los valores
        Console.WriteLine("Ingrese primer numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese segundo numero: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese tercer numero: ");
        num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese cuarto numero: ");
        num4 = int.Parse(Console.ReadLine());


        if (num1 < num2)
            minimo = num1;
        if (num2 < num1) ;
        minimo = num2;
        if (num3 < minimo)
            minimo = num3;
        if (num4 < minimo)
            minimo = num4;

        Console.WriteLine("El numero menor es: " + minimo);

    }
}
