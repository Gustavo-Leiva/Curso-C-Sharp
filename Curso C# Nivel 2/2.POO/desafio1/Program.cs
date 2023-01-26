using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace desafio1
{
    internal class Program
    {
        /*
        Vamos a trabajar con lo aprendido en ésta unidad.

        Te voy a dejar una serie de instrucciones para que vayas siguiendo y construyendo con el fin de poner en práctica y ver funcionando lo visto hasta aquí.

        1) Crear un proyecto de consola .Net Framework.
        2) Crear la clase Telefono (recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
        3) Agregale los siguientes atributos:
            a) Modelo string.
            b) Marca string.
            c) NumeroTelefonico string.
            d) CodigoOperador int (1, 2 o 3).
        4) Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
            a) Modelo: solo lectura. Es decir, solo get.
            b) Marca: solo lectura.
            c) NumeroTelefonico: lectura y escritura.
            d) CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
        5) Agregar Constructor que reciba Modelo y Marca.
        6) Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
        7) Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
        8) Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
        9) Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.
        
        Estas cosas son las que hicimos con los ejemplos de Persona, Botella, Ventas; intenta ponerlos en práctica y si hay dudas, repasate lo necesario.También podés consultar al foro de dudas.

        Te propongo pensar alguna clase más, construirla y agregarle atributos, propiedades y métodos y hacer algunas pruebas; siempre teniendo en mente que la idea es representar la realidad en lo digital.

        No te olvides de la importancia de la práctica.

        Saludos.
        */
        static void Main(string[] args)
        {

            Telefono t1 = new Telefono("A30", "Samsung");
            Console.WriteLine("El modelo del telelfono es: " + t1.Modelo);
            Console.WriteLine("La Marca del Telefono es: " + t1.Marca);
            Console.WriteLine(t1.llamar());
            Console.WriteLine(t1.llamar("Pablo"));

            Console.ReadKey();


        }
    }
}
