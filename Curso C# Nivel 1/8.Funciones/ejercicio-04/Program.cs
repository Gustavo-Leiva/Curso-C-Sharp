namespace ejercicio_04;
class Program
{
    static void Main(string[] args)
    {
        //4. Hacer una función de tipo void (porque no va a devolver nada) llamada 
        //“positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
        //Que analice el número y escriba variable recibida por referencia con:

        //a. 1 si el número es positivo.
        //b. -1 si el número es negativo.
        //c. 0 si el número es cero.

        int numero =0, estado = 9;
        Console.WriteLine("Ingrese un numero: ");
        numero = int.Parse(Console.ReadLine());

        positivoNegativoCero(numero, ref estado);

        Console.WriteLine("El estado del valor " + numero + " es " +  estado);





    }

    static void positivoNegativoCero(int num1, ref int num2)
    {
        if (num1 > 0)
            num2 = 1;

        else if (num1 < 0)
            num2 = -1;

        else if (num1 == 0)
            num2 = 0;
    }
}
