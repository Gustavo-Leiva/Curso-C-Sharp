using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // paso 0

            //tipo de dato: int, float, char, bool
            int n1;
            int n2;
            int resultado;
            



           // paso 1: pedir valores.
           Console.WriteLine ("Ingrese un numero: ");
           n1= int.Parse(Console.ReadLine ());

           Console.WriteLine ("Ingrese otro numero: ");
           n2=int.Parse(Console.ReadLine ());

           // paso 2: realizar cálculo.
           resultado = n1 + n2;
          






           // paso 3: emitir resultado.
           Console.WriteLine ("El resultado de la suma es " + resultado);
        }
    }
}
