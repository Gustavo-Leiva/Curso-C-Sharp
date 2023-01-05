namespace ejemplo2;
class Program
{
    static void Main(string[] args)
    {
        //tipos de datos
        //int (long -short)
        //float -double - decimal

        double[] muestraMatutina = new double[31];
        double[] muestraVespertina = new double[31];
        double[] muestraNoctura = new double[31];

        //cruce
        int dia;
        double temperatura;
        Console.WriteLine("cargue registro matutina");

        for (int i = 0; i < 31; i++)
        {
            Console.WriteLine("ingrese dia");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese temperatura registrada");
            temperatura = double.Parse(Console.ReadLine());

            muestraMatutina[dia - 1] = temperatura;

        }

        for (int i = 0; i < 31; i++)
        {

        }

        for (int i = 0; i < 31; i++)
        {

        }

        //leer vectores

        for (int i = 0; i < 31; i++)
        {
            muestraMatutina[i];
        }


        //sueldos
        double[] sueldos = new double[50];
        int[] legajos = new int [50];

        for (int i = 0; i < 50; i++)
        {
            sueldos[i];
            legajos[i];
        }

    }
}
