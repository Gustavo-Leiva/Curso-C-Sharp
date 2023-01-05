namespace ejemplo;
class Program
{
    static void Main(string[] args)
    {
        //Vectores. Array .Arreglos

        int n;
        int promedio;
        int [] numeros = new int[10];

        //aca lo escribo
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            numeros[i] = n;
        }

        int acum = 0;
        for (int i = 0; i < 10; i++)
        {
          acum += numeros[i];
            
        }

        promedio = acum / 10;
    }
}
