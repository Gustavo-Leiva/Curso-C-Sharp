using System;

namespace ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades 
            y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo 
            aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados*/


            //paso 0 : declaro las variables
            float kmsDistancia;
            float VelocidadPromedio;
            float resultado;

            //paso 1: pido los datos y los guardo en memoria
           Console.WriteLine("Ingrese los kilometros de distancia que hay entre dos ciudades: ");
           kmsDistancia=float.Parse(Console.ReadLine());

           Console.WriteLine("Ingrese la velocidad promedio(km/h): ");
           VelocidadPromedio=float.Parse(Console.ReadLine());


            

            //paso 2: calculo la la operacion de la
            //resultado = ((kmsDistancia * 60)/VelocidadPromedio)/60;

            //es lo mismo que hacer directamente
            resultado = kmsDistancia/VelocidadPromedio;


            //paso 3: muestro el resultado.
            Console.WriteLine ("El tiempo estimado en recorrer ambos puntos es de: " + resultado.ToString("0.00" + "horas"));




        }
    }
}
