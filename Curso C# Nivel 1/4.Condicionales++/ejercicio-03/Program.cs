namespace ejercicio_03;
class Program
{
    static void Main(string[] args)
    {
        /*
        3. Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
        Para ello existe la siguiente escala de precios:
                 

	                    i5 (1)	     i7 (2)	     i9 (3)
            8 RAM (1)	USD 800	    USD 900	    USD 1200
            16 RAM (2)	USD 900	    USD 1000    USD 1400
            32 RAM (3)	USD 1000	USD 1400	USD 2000


            Además, el equipo viene con un disco que permite almacenar 500 GB de información 
            y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional 
            de USD 300. Hacer un programa que solicite la opción de procesador, la opción de 
            memoria  RAM, y si extiende el disco o no (ingresa 1 para extender y 0 para no
            extender) y calcule y emita por pantalla el monto de la máquina seleccionada.




        */

        //Declaro las variables
        int procesador;
        int memoria;
        int disco;

        Console.WriteLine("Ingrese la opcion de memoria (1.(8ram) -2.(16ram) - 3.(32ram)): ");
        memoria = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la opcion de procesador (1.(i5) - 2(i7) - 3(i9)): ");
        procesador = int.Parse(Console.ReadLine());

        Console.WriteLine("Desea extender disco? (1(si) 0(no)): ");
        disco = int.Parse(Console.ReadLine());


        switch (memoria)
        {
            case 1:

                switch (procesador)
                {
                    case 1:
                        //vale 800
                        if (disco == 1)
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1100);
                        else
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 800);
                        break;
                    case 2:

                        //vale 900
                        if (disco == 1)
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1200);
                        else
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 900);
                        break;

                    case 3:

                        //vale 1200
                        if (disco == 1)
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1500);
                        else
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1200);
                        break;


                }
                break;

            case 2:

                switch (procesador)
                {
                    case 1:
                        //vale 900
                        if (disco == 1)
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1200);
                        else
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 900);
                        break;
                    case 2:
                        //vale 1000
                        if (disco == 1)
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1300);
                        else
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1000);
                        break;

                    case 3:
                        //vale 1400

                        if (disco == 1)
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1700);
                        else
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1400);
                        break;


                }
                break;

            case 3:
                switch (procesador)
                {
                    case 1:
                        //vale 1000
                        if (disco == 1)
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1300);
                        else
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1000);
                        break;
                    case 2:
                        //vale 1400
                          if (disco == 1)
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1700);
                        else
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 1400);
                        break;
                       
                    case 3:
                        //vale 2000
                          if (disco == 1)
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 2300);
                        else
                            Console.WriteLine("El precio total de la maquina seleccionada es: " + 2000);
                        break;

                   
                }
                break;


            default:
                break;
        }

    }
}
