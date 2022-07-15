using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clEditorial
    {
        #region Variables
        private short sht_EditorialId;
        private string str_EditorialNombre;
        private string str_EditorialLugarO;
        #endregion

        #region Properties
        public short EditorialId { get => sht_EditorialId; set => sht_EditorialId = value; }
        public string EditorialNombre { get => str_EditorialNombre; set => str_EditorialNombre = value; }
        public string EditorialLugarO { get => str_EditorialLugarO; set => str_EditorialLugarO = value; }
        #endregion
    }//fin class
}//fin space
