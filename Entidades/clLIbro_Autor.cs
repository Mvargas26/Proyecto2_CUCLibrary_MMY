using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clLIbro_Autor
    {
        #region Variables
        private short sht_Libro_Autor;
        private short sht_LibroID;
        private short sht_AutorID;
        #endregion

        #region Properties
        public short Libro_Autor { get => sht_Libro_Autor; set => sht_Libro_Autor = value; }
        public short LibroID { get => sht_LibroID; set => sht_LibroID = value; }
        public short AutorID { get => sht_AutorID; set => sht_AutorID = value; }

        #endregion




    }//fin class
}//fin space
