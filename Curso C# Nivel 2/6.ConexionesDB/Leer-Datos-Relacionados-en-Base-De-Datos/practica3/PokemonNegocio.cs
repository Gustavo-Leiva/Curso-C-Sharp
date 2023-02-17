using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Configuration;

namespace practica3
{
    internal class PokemonNegocio
    {


        public List<Pokemon> listar()
        {
			List<Pokemon> lista = new List<Pokemon>();
			SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;



			try
			{
				conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad From POKEMONS P, ELEMENTOS E, ELEMENTOS D Where E.Id = P.IdTipo And D.Id = P.IdDebilidad";  //modifico la consulta para relacionar las dos tablas.
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

					aux.Tipo = new Elemento(); //creo esta instancia porque si hago Tipo. va a dar referencia nula. porque no exite un objeto de tipo Elemento.
					aux.Tipo.Descripcion = (string)lector["Tipo"]; //agrego en el objeto tipo la columna que corresponda. o sea Tipo.
                    aux.Debilidad = new Elemento(); //creo el objeto debilidad
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"]; //agrego en el objeto la descripcion de debilidad.

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

    }
}
