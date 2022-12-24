namespace ejercicio_03_OpcionC;
class Program
{
    static void Main(string[] args)
    {
        //3. Hacer un programa que solicite 20 edades y luego calcule el promedio 
        //de edad de aquellas personas mayores a 18 años.

        //Resuelto con el ciclo While
        
        int edad = 0;
        int mayorEdad = 18;
        int acumMayorEdad = 0;
        int contMayorEdad = 0;
        float promedio;
        int i = 0;

        do
        {
            Console.WriteLine("Ingrese una edad:");
            edad = int.Parse(Console.ReadLine());
            if (edad > mayorEdad)
            {
                acumMayorEdad = acumMayorEdad + edad;
                contMayorEdad ++;
            }

            i++;
        }
        while (i < 20);

       
        //calculo de promedio
        promedio = acumMayorEdad /contMayorEdad;

        Console.WriteLine("El promedio de las edades de personas mayores a 18 es de :" + promedio.ToString("0.00"));
    }
}
