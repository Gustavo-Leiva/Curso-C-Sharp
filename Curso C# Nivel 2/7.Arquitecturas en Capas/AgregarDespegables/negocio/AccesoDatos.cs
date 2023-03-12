using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;



namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;


        public SqlDataReader Lector
        {
            get { return lector; }
        }


        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;

        }


        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        public void ejecutarLectura()
        {
            comando.Connection= conexion;


            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

        }



        //video 5 capas (insert tipo y debilidad-Parametros comandos)
        //es para validar la variables embedidas (son los los que agregamos @idTipo y @IdDebilidad)
        public void setearParametro(string nombre, object valor)
        {

            comando.Parameters.AddWithValue(nombre, valor); 

            //comando.Parameters.AddWithValue("@idTipo", 3); 
            //cuando se ejercucte la insercion el ejecutar consulta y agarre el setear consulta lo primero que hace es
            //concatenar los valores y resolver luego los elemento que estan seguido del arroba y los remplaza con los valores que estan 
            //en setearParametro en este caso el numero 3
        }

        public void cerrarConexion()

        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }



    }
}
