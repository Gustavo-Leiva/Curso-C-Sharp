namespace ejercicio_05;
class Program
{
    static void Main(string[] args)
    {
        //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares 
        //y el mínimo de los números impares.

        //solucion con ciclo FOR
        int num;
        bool banderaPar = true;
        bool banderaImpar = false;
        int mayorValorPares = 0;
        int menorValorImpares = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                //trabajo con pares.
                if (banderaPar == false)

                {
                    mayorValorPares = num;
                    banderaPar = true;

                }
                else
                {
                    if (num > mayorValorPares)
                    {
                        mayorValorPares = num;
                    }
                }

            }
            else
            {
                //trabajo con impares
                if (banderaImpar == false)
                {
                    menorValorImpares = num;
                    banderaImpar = true;
                }

                else
                {
                    if (num < menorValorImpares)
                    {
                        menorValorImpares = num;
                    }

                }


            }
        }

        Console.WriteLine("El numero de mayor Par valor es : " + mayorValorPares);
        Console.WriteLine("El numero de menor Impar es : " + menorValorImpares);

    }
}
