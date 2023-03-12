using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


//video 4) en este capitulo agregamos un desplegable de opciones para agregar en el formulario que vienen de la base de datos.
//video 5) en este capitulo se termina la alta de pokemon y tomar el nuevo pokemon e inyectarlo en la base de datos.
//video 6) en este capitulo se ve como validar una columna Nula en la BD y estoy leyendo.
//video 7) en este capitulo se ven truquitos acerca de las grillas.
// * anotacions
// * como agregar un dato y actualice la grilla de datos.
// * como evitar modificar desde la imagen un campo
// * como seleccionar una celda y seleccione toda la fila.
//Video 8) en este capitulo se ve como agregar la imagen del alta del pokemon.

//Unidad 8
// video 1 -Modificar un pokemon
// video 2 -Eliminacion Fisica es eliminar sobre la faz del sistema.
// video 3 -Elimnacion Logica maneja un estado es decir que no elimina realmente sino que pasa a ser un estado inactivo.
// video 4 -Filtro simple y rapido. Usando el metodo FindAll();
// video 5 -Filtro mejorado
// video 6 -Filtro avanzado contra DB
// video 7 -insertar imagen desde una ubicacion local.
// Video 8 -Validaciones -Teorico-
// Video 9 -Validaciones -Practica-
//
//






namespace AgregarDespegables
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPokemon());
        }
    }
}
