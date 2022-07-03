using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
 public  class Procesos
    {
        public DataTable QueryGeneralNegocios_DT(String QueryUserNegociosMySQL)
        {
            try
            {
                SQL_Server objDatos = new SQL_Server();

                DataTable dtDatosNegocios = objDatos.QuerySQL_Server_DT(QueryUserNegociosMySQL);

                return dtDatosNegocios;

            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }// FIN QueryGeneralNegocios_DT

        public DataSet QueryGeneralNegocios_DS(String QueryUserNegociosMySQL)
        {
            try
            {
                SQL_Server objDatos = new SQL_Server();

                DataSet dsDatosNegocios = objDatos.QuerySQL_Server_DS(QueryUserNegociosMySQL);

                return dsDatosNegocios;

            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }// FIN QueryGeneralNegocios_DT




    }//fin class
}//fin space
