namespace ejercicio_02;
class Program
{
    static void Main(string[] args)
    {

        //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 
        //si es par o cero si no lo es. Hacer un programa para ingresar 20 números y 
        //mostrar por pantalla cuántos son pares.

        int n1;
        int valor;
        int contadorPares = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());

            valor = par(n1);
            if(valor == 1)
            {
                contadorPares++;
            }
            
            
        }

        Console.WriteLine("La cantidad de numeros pares es: " + contadorPares);
    }

    static int par (int num)
    {
        int resultado;

        if(num % 2 == 0)
        {
            resultado =1; //devuelve 1 si es par.
        }

        else
        {
            resultado = 0; // devuelve 0 si no es par.
        }
        return resultado;
    }
}
