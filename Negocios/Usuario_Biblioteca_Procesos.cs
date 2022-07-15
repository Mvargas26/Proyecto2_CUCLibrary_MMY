using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
   public class Usuario_Biblioteca_Procesos
    {
        public void GrabarUserBiblio(short accion, Entidades.clUsuarioBibliteca UB_Grabar)
        {
            try
            {
                string strNombreSP = "SP_UsuarioBiblioteca";

                List<SqlParameter> lstParametros = new List<SqlParameter>();

                lstParametros.Add(new SqlParameter("@accion", accion));
                lstParametros.Add(new SqlParameter("@userBibli_Id", UB_Grabar.userBiId));
                lstParametros.Add(new SqlParameter("@nombreUB", UB_Grabar.nombreUB));
                lstParametros.Add(new SqlParameter("@apellidosUB", UB_Grabar.apellidosUB));
                lstParametros.Add(new SqlParameter("@userUB", UB_Grabar.UserUB));
                lstParametros.Add(new SqlParameter("@passwordUB", UB_Grabar.passwordUB));
                lstParametros.Add(new SqlParameter("@edadUB", UB_Grabar.edadUB));
                lstParametros.Add(new SqlParameter("@estadoUB", UB_Grabar.estado));
 
                SQL_Server objDatos = new SQL_Server();

                objDatos.ExecuteSP(strNombreSP, lstParametros);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }//fin GrabarUserBiblio

    }//fin class

}//fin space
