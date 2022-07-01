using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
  public class SQL_Server
    {
        public static SqlConnection conexionSQLServer()
        {
            try
            {


                StringBuilder StringConexionArmado = new StringBuilder();

                StringConexionArmado.Append("Data Source=");
                StringConexionArmado.Append("(local)");
                StringConexionArmado.Append(";Database=");
                StringConexionArmado.Append("CUC_Library");
                StringConexionArmado.Append(";Integrated Security=True;");
                //StringConexionArmado.Append(";User=");
                //StringConexionArmado.Append("mvargas");
                //StringConexionArmado.Append(";Password=");
                //StringConexionArmado.Append("1234;");


                SqlConnection sqlConector = new SqlConnection(StringConexionArmado.ToString());

                return sqlConector;
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }//fin conexionSQLServer

        public DataTable QuerySQL_Server(String QueryDelUsuario)
        {
            SqlConnection sqlConector = conexionSQLServer();
            try
            {
                SqlCommand cmd = sqlConector.CreateCommand();
                cmd.CommandText = QueryDelUsuario;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dtdatos = new DataTable();

                sqlConector.Open();

                adapter.Fill(dtdatos);

                return dtdatos;
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
            finally
            {
                sqlConector.Close();
            }

        }//fin querySQL_Server
    }//fin class
}//fin namespace
