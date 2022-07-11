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
        SqlConnection sqlConector = new SqlConnection();
        public SQL_Server()
        {
            try
            {
                StringBuilder StringConexionArmado = new StringBuilder();

                StringConexionArmado.Append("Data Source=");
                StringConexionArmado.Append("DESKTOP-MVARGAS\\SQLEXPRESS");
                StringConexionArmado.Append(";Database=");
                StringConexionArmado.Append("CUC_Library");
                StringConexionArmado.Append(";Integrated Security=True;");

              this.sqlConector = new SqlConnection(StringConexionArmado.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }//fin constructor

        /// <summary>
        /// Funcion que realiza la consulta a una tabla especifica
        /// </summary>
        /// <param name="QueryDelUsuario"> Trae la consulta en un String desde interfaz</param>
        /// <returns>
        /// Devuelve un Data Table
        /// </returns>
        public DataTable QuerySQL_Server_DT(String QueryDelUsuario)
        {
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


        /// <summary>
        /// Funcion que realiza la consulta a Toda la base de Datos
        /// </summary>
        /// <param name="QueryDelUsuario"> Trae la consulta en un String desde interfaz</param>
        /// <returns>
        /// Devuelve un DataSet
        /// </returns>
        public DataSet QuerySQL_Server_DS(String QueryDelUsuario)
        {
           try
            {
                SqlCommand cmd = sqlConector.CreateCommand();
                cmd.CommandText = QueryDelUsuario;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet dsDatos = new DataSet();

                sqlConector.Open();

                adapter.Fill(dsDatos);

                return dsDatos;
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
            finally
            {
                sqlConector.Close();
            }

        }//fin QuerySQL_ServerDataSet

        /// <summary>
        /// Funcion que ejecuta los SP usando lista de parametros
        /// </summary>
        /// <param name="SPNombre">Variable que lleva el nombre del SP</param>
        /// <param name="listParametros">Lista que contiene los paramentros para ejecutar</param>
        public void ExecuteSP(String SPNombre, List<SqlParameter> listParametros)
        {
           try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPNombre;
                cmd.Connection = sqlConector;


                foreach(SqlParameter Param in listParametros)
                {
                    cmd.Parameters.Add(Param);
                }

                sqlConector.Open();

                cmd.ExecuteNonQuery();

                sqlConector.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlConector.Close();
            }
        }//fin ExecuteSP

    }//fin class
}//fin namespace
