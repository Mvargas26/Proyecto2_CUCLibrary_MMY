using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clAutor
    {
        #region VAriables
        private short sht_AutorID;
        private string str_AutorNombre;
        private string str_AutorLugar;

        #endregion
        #region Properties

        public short AutorID { get => sht_AutorID; set => sht_AutorID = value; }
        public string AutorNombre { get => str_AutorNombre; set => str_AutorNombre = value; }
        public string AutorLugarO { get => str_AutorLugar; set => str_AutorLugar = value; }
         #endregion


    }//fin class
}//fin space
