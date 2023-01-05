namespace ejercicio_02;
class Program
{
    static void Main(string[] args)
    {
        
        //Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
        //Luego recorrer ese vector para calcular el promedio. 
        //Mostrar por pantalla los valores que son mayores al promedio.

        int [] numeros = new int[10];
        int n = 0;
        int acum = 0;
        float promedio = 0;
        int [] mayorAlPromedio = new int [10];

        //pido la info y guardo en el vector.
        for (int i = 0; i < 10; i++)
        {
          Console.WriteLine("Ingrese un numero: ");
          n = int.Parse(Console.ReadLine());
          numeros[i] = n;
         

        }

        //recorro y sumo 
        for (int i = 0; i < 10; i++)
        {
             acum += numeros[i]; 
        }
       

        //calculo el promedio
        promedio = acum/10;
        Console.WriteLine("El promedio es : " + promedio);

        for (int i = 0; i < 10; i++)
        {
            if( numeros[i] > promedio)
            {
                Console.WriteLine("Este elemento es mayor al promedio: " + numeros[i]);
            }
            
        }

    }
}
