using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Linq.Expressions;

namespace negocio
{
    public class PokemonNegocio
    {

        public List<Pokemon> listar()
        {

            List<Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;



            try
            {
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad";
                comando.Connection= conexion; 
                

                conexion.Open();
                lector = comando.ExecuteReader();


                while(lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    lista.Add(aux);

                }

                conexion.Close(); 
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }




        //esta es la logica para conectar a la base de datos.
        public void agregar(Pokemon nuevo)
        {
            //con este objeto me conecto a la base de datos.
            //como inserta datos y no devuelve nada no necesito crear una lista.
            AccesoDatos datos = new AccesoDatos(); 

            try
            { 
                //particularidades al agregar se inicia con comilla dobles
                //el resto al concatenar se agrega las comillas dobles entre las simples.            {
                datos.setearConsulta("insert into POKEMONS (Numero, Nombre, Descripcion, Activo) values ("+ nuevo.Numero +", ' " + nuevo.Nombre + "', '"+ nuevo.Descripcion +"', 1)");


                //paso siguiente ejecutar la lectura(creo un metodo para ello (ejecutar accion) en Acceso a datos
                //datos.ejecutarLectura(); no me sirve porque es un insert no una consulta.
                // asi que necesito hacer otra accion excuteNonQuery es una ejecucion de no consulta.
                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }


            finally
            {
                datos.cerrarConexion(); //aca cierro la conexion.
            }
        }

        public void modificar(Pokemon modificar)
        {

        }















    }
}
