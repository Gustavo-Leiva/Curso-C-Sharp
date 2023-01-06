namespace ejercicio_03;
class Program
{
    static void Main(string[] args)
    {

        //3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 
        //si el número es primo o cero si no lo es. 
        //Hacer un programa para ingresar números. 
        //El lote corta cuando se ingresa un número cero. 
        //Informar el promedio teniendo en cuenta sólo los números primos.

        int n;
        int valor;
        int contPrimo = 0;
        int acumPrimo = 0;
        float promedio;

        Console.WriteLine("Ingrese un numero:");
        n = int.Parse(Console.ReadLine());

        while (n != 0)
        {
            Console.WriteLine("Ingrese otro numero:");
            n = int.Parse(Console.ReadLine());
            valor = primo(n);
            if (valor == 1)
            {
                contPrimo++;
                acumPrimo += n;
            }

        }

        promedio = acumPrimo / contPrimo;



        
        if (contPrimo > 0)
        {
            Console.WriteLine("La cantidad de numeros primos es: " + contPrimo);
            Console.WriteLine("El promedio de numeros primos es: " + promedio);

        }

        else
        {
            Console.WriteLine("No se ingresaron numeros primos");
        }
    }

    static int primo(int num)
    {
        int cont = 0;
        int resultado;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                cont++;
            }
        }

        if (cont == 2)
        {
            resultado = 1;
        }

        else
        {
            resultado = 0;
        }

        return resultado;
    }
}
