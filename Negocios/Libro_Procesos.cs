using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Datos;
using System.Collections;

namespace Negocios
{
  public  class Libro_Procesos
    {

        public static ArrayList arry_listaAutoresGuardar;

        public void GrabarLibro(short accion, Entidades.clLibro libroGrabar)
        {
            try
            {
                string strNombreSP = "SP_Libro";

                List<SqlParameter> lstParametros = new List<SqlParameter> ();

                lstParametros.Add(new SqlParameter("@accion", accion));
                lstParametros.Add(new SqlParameter("@libroID", libroGrabar.libroID));
                lstParametros.Add(new SqlParameter("@libroNombre", libroGrabar.libroNombre));
                lstParametros.Add(new SqlParameter("@categoriaID", libroGrabar.CategoriaID));
                lstParametros.Add(new SqlParameter("@editorialID", libroGrabar.EditorialID));
                lstParametros.Add(new SqlParameter("@cantDispon", libroGrabar.cantDispo));
                lstParametros.Add(new SqlParameter("@fechaPubli", libroGrabar.fechaPubli));
                lstParametros.Add(new SqlParameter("@habitacionID", libroGrabar.habitacionID));
                lstParametros.Add(new SqlParameter("@pasilloID", libroGrabar.pasilloID));
                lstParametros.Add(new SqlParameter("@estanteID", libroGrabar.estanteID));

                SQL_Server objDatos = new SQL_Server();

                objDatos.ExecuteSP(strNombreSP, lstParametros);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }//fin GrabarLibro


    }//fin class
}//fin space
