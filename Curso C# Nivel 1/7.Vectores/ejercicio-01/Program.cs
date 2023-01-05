namespace ejercicio_01;
class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
        //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        
        int[] numeros = new int[10];
        int n;
        int mayor = 0;        
        int posicion = 0;

        //aca guardo cada numero en el vector.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            numeros[i] = n;
        }


     for (int i = 0; i < 10; i++)
     {
        if(i == 0 || numeros[i]> mayor)
        {
            mayor = numeros[i];
            posicion = i;
        }
        
     }


     Console.WriteLine("El numero mayor es: " + mayor + " y se encuentra en la posicion: " + posicion);

    }
}
