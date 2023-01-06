namespace ejemplo_02;
class Program
{
    static void Main(string[] args)
    {
        int n1;
        int n2;
        int resultado;

        Console.WriteLine("Ingrese un numero");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro numero");
        n2 = int.Parse(Console.ReadLine());

        resultado = sumar(n1,n2);

        Console.WriteLine("La suma es " + resultado);


    }



    static int sumar(int num1, int num2)
    {
        int resultado = 0;
        resultado = num1 + num2;
        return resultado;
    }
}
