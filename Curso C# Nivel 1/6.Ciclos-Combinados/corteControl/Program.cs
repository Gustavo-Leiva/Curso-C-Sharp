namespace corteControl;
class Program
{
    static void Main(string[] args)
    {
        //Corte de Control (cargar jugadores por codigo de equipos numero entre 1 y 50)
        //legajo, edad, sueldo, codigo equipo

        int legajo;
        int edad;
        int codigoEquipo;
        float sueldo;
        int equipoActual;

        //codigo de equipos
        // 1.River
        // 2.Boca
        // 3.Racing

        Console.WriteLine("Ingrese el legajo: ");
        legajo = int.parse(Console.ReadLine());

        Console.WriteLine("Ingrese el edad: ");
        edad = int.parse(Console.ReadLine());

        Console.WriteLine("Ingrese el sueldo: ");
        sueldo = int.parse(Console.ReadLine());

        Console.WriteLine("Ingrese codigo de equipo: ");
        codigoEquipo = int.parse(Console.ReadLine());

        while (sueldo > 0)
        {
            //esta asignacion hace la diferencia de pasar de ciclos combinados
            // a ciclo combinados con corte de control
            equipoActual = codigoEquipo;

            while (codigoEquipo == equipoActual)
            {
                //aca procesamos
                Console.WriteLine("Ingrese el legajo: ");
                legajo = int.parse(Console.ReadLine());

                Console.WriteLine("Ingrese el edad: ");
                edad = int.parse(Console.ReadLine());

                Console.WriteLine("Ingrese el sueldo: ");
                sueldo = int.parse(Console.ReadLine());

                Console.WriteLine("Ingrese codigo de equipo: ");
                codigoEquipo = int.parse(Console.ReadLine());

                //aca se puede mostrar resultados.

            }
            //aca mostramos resultados
        }
        //aca tambien se puede mostrar resultados
    }
}
