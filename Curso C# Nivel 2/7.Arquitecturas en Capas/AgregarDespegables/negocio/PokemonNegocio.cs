using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class PokemonNegocio
    {

        public List<Pokemon> listar()
        {
            List <Pokemon> lista = new List<Pokemon>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = " server = .\\SQLEXPRESS; database = POKEDEX_DB; integrated security = true";
                comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad";
                comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1";
                comando.Connection = conexion;
                
                conexion.Open();
                lector = comando.ExecuteReader();


                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["Id"];
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];


                    //dos maneras de validar ver video 6
                    //1era forma
                    //if(!(lector.IsDBNull(lector.GetOrdinal("UrlImagen"))))//le digo entre comillas las columnas que quiero que lea.
                    //       aux.UrlImagen = (string)lector["UrlImagen"];


                    //2da forma
                    if (!(lector["UrlImagen"] is DBNull))
                           aux.UrlImagen = (string)lector["UrlImagen"];



                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)lector["IdTipo"]; //ver video 8 trae los valores de tipo.                   
                    aux.Tipo.Descripcion = (string)lector["Tipo"];

                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)lector["IdDebilidad"]; //ver video 8 trae los valores de tipo.
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];


                    lista.Add(aux);

                }

                conexion.Close();
                return lista;



            }
            catch (Exception ex )
            {

                throw ex;
            }

        }


        public void agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //(esto esta en el video 4 de Arq en capas)
                //datos.setearConsulta("insert into POKEMONS (Numero, Nombre, Descripcion, Activo) values (" + nuevo.Numero + ", ' " + nuevo.Nombre + "', '" + nuevo.Descripcion + "', 1)");
                datos.setearConsulta("insert into POKEMONS (Numero, Nombre, Descripcion, Activo,IdTipo, IdDebilidad, UrlImagen) values (" + nuevo.Numero + ", ' " + nuevo.Nombre + "', '" + nuevo.Descripcion + "', 1, @idtipo, @idDebilidad, @urlImagen)"); //video 5 Arq en capaz se agrega campos
                datos.setearParametro("@idTipo", nuevo.Tipo.Id);//ver video 5 de capas cuando se ejecute reemplaza @idTipo x nuevo.Tipo.Id en la sintaxis de arriba donde tenga el @Id.
                datos.setearParametro("@idDebilidad", nuevo.Debilidad.Id); //ver video 5 de capas idem punto anterior.
                datos.setearParametro("@urlImagen", nuevo.UrlImagen); //ver video 8
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }


        //video 8 cap 1 -Metodo modificar-
        public void modificar(Pokemon poke)               
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.setearConsulta("update POKEMONS set numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @IdTipo, IdDebilidad = @IdDebilidad where Id = @id");
                datos.setearConsulta(" update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @IdTipo, IdDebilidad = @IdDebilidad where Id = @id");
                datos.setearParametro("@numero", poke.Numero);
                datos.setearParametro("@nombre", poke.Nombre);
                datos.setearParametro("@desc", poke.Descripcion);
                datos.setearParametro("@img", poke.UrlImagen);
                datos.setearParametro("@IdTipo", poke.Tipo.Id);
                datos.setearParametro("@IdDebilidad", poke.Debilidad.Id);
                datos.setearParametro("@id", poke.Id);


                datos.ejecutarAccion(); //video 8 cap 1

            }
            catch (Exception ex)
            {

                throw ex;
            }


            finally
            {
                datos.cerrarConexion();
            }

        }




        //video 8 cap 2 -Metodo eliminar
        public void eliminar(int id)
        {
            try
            {

                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from POKEMONS where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void eliminarLogico ( int id)
        {
            try
            {

                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("update POKEMONS set Activo = 0 where Id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        //cap 8 video 6
        public object filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.IdTipo, P.IdDebilidad, P.Id From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad And P.Activo = 1 And ";
                if (campo == "Número")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Numero > " + filtro;
                            break;

                        case "Menor a":
                            consulta += "Numero < " + filtro;
                            break;

                        default:
                            consulta += "Numero = " + filtro;
                            break;

                    }
                }

                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' " ;
                            break;

                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;

                    }


                }

                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "P.Descripcion like '" + filtro + "%' ";
                            break;

                        case "Termina con":
                            consulta += "P.Descripcion like '%" + filtro + "'";
                            break;

                        default:
                            consulta += "P.Descripcion like '%" + filtro + "%'";
                            break;

                    }


                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    //2da forma
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];



                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"]; //ver video 8 trae los valores de tipo.                   
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];

                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"]; //ver video 8 trae los valores de tipo.
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];


                    lista.Add(aux);

                }



                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
