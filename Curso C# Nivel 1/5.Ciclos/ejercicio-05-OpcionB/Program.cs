namespace ejercicio_05_OpcionB;
class Program
{
    static void Main(string[] args)
    {
        //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares 
        //y el mínimo de los números impares.

        //solucion con ciclo While
        int num;
        bool banderaPar = true;
        bool banderaImpar = true;
        int mayorValorPares = 0;
        int menorValorImpares = 0;
        int i = 0;

        while (i < 4)
        {
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                if (banderaPar == true)
                {
                    mayorValorPares = num;
                    banderaPar = false;
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

                if (banderaImpar == true)
                {
                    menorValorImpares = num;
                    banderaImpar = false;
                }

                else
                {
                    if (num < menorValorImpares)
                    {
                        menorValorImpares = num;
                    }

                }


            }

            i++;
        }


        Console.WriteLine("El numero de mayor Par es : " + mayorValorPares);
        Console.WriteLine("El numero de menor Impar es : " + menorValorImpares);

    }
}
