using System;

namespace ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
            más una comisión del 5% sobre el total facturado por cada empleado. 
            Hacer un programa para ingresar el total facturado por un empleado 
            y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            */

            //paso 0: declaro las Variables
            int sueldoFijo = 15000;
            float tasaComision = 0.05F;
            float importeComision;
            float totalFacturado;
            float sueldoTotalCobrar;


            //paso 1: pedidos de datos.
            Console.WriteLine("Ingrese monto facturado del empleado: ");
            totalFacturado = float.Parse(Console.ReadLine());



            //paso 2: realizo el calculos
            importeComision = totalFacturado * tasaComision;
            sueldoTotalCobrar = 15000 + importeComision; 


            //paso 3: muestro el resultado.
            Console.WriteLine("El monto total a cobrar por el empleado es: " + sueldoTotalCobrar);






        }
    }
}
