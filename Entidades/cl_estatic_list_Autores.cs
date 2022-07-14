using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public static class cl_estatic_list_Autores
    {
        #region Variables
        private static string str_cadenaAutores;

        public static string cadenaAutores { get => str_cadenaAutores; set => str_cadenaAutores = value; }
        #endregion




    }//fin class
}//fin space
