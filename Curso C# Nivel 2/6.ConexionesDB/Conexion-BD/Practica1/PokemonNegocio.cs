using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //(*) establecemos las librerias.
using System.Xml.Linq;

namespace Practica1
{

    //esta es la clase en la cual voy a crear los metodos de acceso a datos para los pokemons
    internal class PokemonNegocio
    {

        //creo la funcion(metodo) que lea registro de las bases de datos.
        public List<Pokemon> listar() //metodo listar
        {
            List<Pokemon> lista = new List<Pokemon>();   //** creo una lista
            SqlConnection conexion = new SqlConnection();//** una vez insertado la liberia creo el objeto SqlConnection para conectarse a algun lado.
            SqlCommand comando = new SqlCommand();       //** Una vez conectado necesito hacer acciones, para ello usamos SqlCommand.
            SqlDataReader lector;                        //** una vez conectado, leido necesitamos albergar en algun lado y usamos el comando SqlDataReader
                                                         //** No generamos la instancia porque cuando yo lo lea voy a obtener un resultado un objeto de tipo SqlDataReader


            
            try //dentro de try ponemos todas las funcionalidades que puedan fallar (por ejemplo; la lectura a base de datos, la transformacion a base de datos).
            {


                //una vez creado objeto y variable lo que tenemos que hacer en configuarlo(**)

                //3 Elementos a considerar.
                //(direccion (nombre de la base de datos reemplazamos por punto)
                //( a donde me voy a conectar, Nombre la base de datos.)

                //A)configuro la cadena de coleccion.
                //(indico como me voy a conectar (hay dos maneras, 1ero sql autenticacion y la 2da window autentication (usamos este))
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true"; //donde nos contactamos,

                //B) configuro el comando.(inyecto la secuencia sql que quiero ejecutar.
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre, Descripcion From POKEMONS"; //aca paso el texto que quiere que consulte (siempre primero consulto en sql para evitar errores)
                comando.Connection = conexion; //este comando.Connection va a ejecutar en esa conexion..

                //c) abro la conexion
                conexion.Open(); //abro la conexion


                //d) realizo la lectura.
                lector = comando.ExecuteReader();//realizo la lectura.

                while (lector.Read()) //mientras lo pueda leer ingresa al while
                {
                    Pokemon aux = new Pokemon();//creo un aux para empezar a cargar con el lector de esos registros
                    aux.Numero = lector.GetInt32(0); //1era forma dentro del parentesis va el indice
                    aux.Nombre = (string)lector["Nombre"]; //2da forma entre [] va el nombre de la columna.
                    aux.Descripcion = (string)lector["Descripcion"];                 
                                      
                    lista.Add(aux); //en cada vuelta cuando lea el elemento lo agrega a la lista.

                }


                conexion.Close();
                return lista;

            }
            catch (Exception ex) 
            {

                throw ex;
            }



        }


        



       

    }
}
