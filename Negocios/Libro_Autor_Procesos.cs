using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
  public  class Libro_Autor_Procesos
    {
        /// <summary>
        /// Metodo que ejecuta el SP en la Tabla Libro_Autor
        /// </summary>
        /// <param name="accion">indica el entero que determina si agrega,actualiza o elimina</param>
        /// <param name="libroAutorGrabar">objeto de tipo Libro_Autor</param>
        public void GrabarLibro_Autor(short accion, Entidades.clLIbro_Autor libroAutorGrabar)
        {
            try
            {
                string strNombreSP = "SP_Libro_Autor";

                List<SqlParameter> lstParametros = new List<SqlParameter>();

                lstParametros.Add(new SqlParameter("@accion", accion));
                lstParametros.Add(new SqlParameter("@libro_AutorID", libroAutorGrabar.Libro_Autor));
                lstParametros.Add(new SqlParameter("@libroID", libroAutorGrabar.LibroID));
                lstParametros.Add(new SqlParameter("@autorID", libroAutorGrabar.AutorID));
               

                SQL_Server objSQL_Server_Datos = new SQL_Server();

                objSQL_Server_Datos.ExecuteSP(strNombreSP, lstParametros);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }//fin GrabarLibro
    }//fin class
}//fin space
