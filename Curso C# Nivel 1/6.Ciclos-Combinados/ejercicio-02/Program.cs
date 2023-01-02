namespace ejercicio_02;
class Program
{
    static void Main(string[] args)
    {
        //Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.

        // Se pide determinar e informar:

        //El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        //Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

        int n;
        int contadorNumeros;
        int contImpares;
        int grupoImparesMaximo=0;
        int min;
        int contOrdenados = 0;
        double porcentajeImpares;
        double porcentajeMaximo = -1;
        bool banderaOrdenados;


        for (int i = 0; i < 5; i++)
        {            
            contadorNumeros = 0;
            contImpares = 0;
            banderaOrdenados = true;
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            min = n;


            while (n != 0)
            {
                contadorNumeros++;
                if (n % 2 == 0)
                {
                    contImpares++;
                }

                //punto b
                if (n <= min)
                    min = n;

                else
                    banderaOrdenados = false;



                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }//fin del while

            porcentajeImpares = contImpares * 100 / contadorNumeros;

            if (porcentajeImpares > porcentajeMaximo)
            {
                porcentajeMaximo = porcentajeImpares;
                grupoImparesMaximo = i + 1;
            }

            //punto B

            if (banderaOrdenados)
                contOrdenados++;



        }//fin del for

        Console.WriteLine("El grupo con mayor porcentaje impares es: " + grupoImparesMaximo);
        Console.WriteLine("La cantidad de grupos ordenados es : " + contOrdenados);


    }
}
