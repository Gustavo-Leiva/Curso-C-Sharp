using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;




namespace negocio
{
    public class AccesoDatos
    {
        //establezco los objetos que necesito para hacer una conexion.
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;


        //con este metodo voy a tener la posibilidad de leer el lector desde el exterior.
        public SqlDataReader Lector
        {
            get { return lector; }
        }


        //creo el constructor
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true");
            comando = new SqlCommand();
        }



        //de esta manera encapsulo para darle un tipo y nombre.
        public void setearConsulta(string consulta)

        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta; 
        }


        //Este metodo realiza la lectura y lo guarda en el lector.
        public void ejecutarLectura()
        {
            comando.Connection = conexion;

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



        public void cerrarConexion()

        {
            if(lector !=  null)
            {
                lector.Close();
            }
            conexion.Close();
        }

    }
}
