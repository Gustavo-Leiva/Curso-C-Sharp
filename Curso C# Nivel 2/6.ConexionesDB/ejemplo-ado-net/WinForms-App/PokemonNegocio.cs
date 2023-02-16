using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //(*) establecemos las librerias.

namespace WinForms_App
{
    internal class PokemonNegocio 
    //esta es la clase en la cual voy a crear los metodos de acceso a datos para los pokemons
    
    {
        //1ero que creo la funcion(metodo) que lea registro de las bases de datos.
        public List<Pokemon> listar()
        {
            //new List <Pokemon>(); es crear un instancia. 
            List<Pokemon> lista = new List<Pokemon>(); //2do tiene que devolver una lista entonces la creo
            SqlConnection conexion = new SqlConnection(); //una vez insertado la liberia creo el objeto SqlConnection para conectarse a algun lado.
            SqlCommand comando = new SqlCommand();//Una vez conectado necesito hacer acciones, para ello usamos SqlCommand.
            SqlDataReader lector;//una vez conectado, leido necesitamos albergar en algun lado y usamos el comando SqlDataReader
                                 //No generamos la instancia porque cuando yo lo lea voy a obtener un resultado un objeto de tipo SqlDataReader
                                

            //una vez creado objeto y variable lo que tenemos que hacer en configuarlo(**)


            //3ero necesitamos configurar para conectar a base de datos para eso uso excepciones.
            //el uso de try{} catch{} permite que retorne try si todo estuvo bien y catch si algo estuvo mal.
            
            try //dentro de try ponemos todas las funcionalidades que puedan fallar (por ejemplo; la lectura a base de datos, la transformacion a base de datos).
            {
                //(**)
                //A)configuro la cadena de coleccion.
                //(direccion (nombre reemplazamos por punto)
                //( a donde me voy a conectar, Nombre la base de datos.)
                //(indico como me voy a conectar (hay dos maneras, 1ero sql autenticacion y la 2da window autentication (usamos este))
                
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true"; //donde nos contactamos, 

                //B) configuro el comando.(inyecto la secuencia sql que quiero ejecutar.
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad"; //aca paso el texto que quiere que consulte (siempre primero consulto en sql para evitar errores)
                comando.Connection = conexion; //este comando.Connection va a ejecutar en esa conexion.

                conexion.Open(); //abro la conexion                
                lector = comando.ExecuteReader();//realizo la lectura.



                while(lector.Read()) //mientras lo pueda leer ingresa al while
                {
                    Pokemon aux = new Pokemon();//creo un aux para empezar a cargar con el lector de esos registros
                    aux.Numero = lector.GetInt32(0); //1era forma dentro del parentesis va el indice
                    aux.Nombre = (string)lector["Nombre"]; //2da forma entre [] va el nombre de la columna.
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    
                    
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];






                    lista.Add(aux); //en cada vuelta cuando lea el elemento lo agrega a la lista.

                }


                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            //4to necesitamos establecer la conexion y poder leer los datos para eso tenemos declarar ciertos objetos y configuarar los (*). 






        }


    }
}
