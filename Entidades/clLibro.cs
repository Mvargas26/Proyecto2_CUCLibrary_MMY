using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class clLibro
    {
        #region Variables
        private short sh_libroID;
        private string str_libroNombre;
        private short sh_CategoriaID;
        private short sh_EditorialID;
        private int int_cantDispo;
        private DateTime dt_fechaPubli;
        private short sh_habitacionID;
        private short sh_pasilloID;
        private short sh_estanteID;
        #endregion

        #region Properties

        public short libroID { get => sh_libroID; set => sh_libroID = value; }
        public string libroNombre { get => str_libroNombre; set => str_libroNombre = value; }
        public short CategoriaID { get => sh_CategoriaID; set => sh_CategoriaID = value; }
        public short EditorialID { get => sh_EditorialID; set => sh_EditorialID = value; }
        public int cantDispo { get => int_cantDispo; set => int_cantDispo = value; }
        public DateTime fechaPubli { get => dt_fechaPubli; set => dt_fechaPubli = value; }
        public short habitacionID { get => sh_habitacionID; set => sh_habitacionID = value; }
        public short pasilloID { get => sh_pasilloID; set => sh_pasilloID = value; }
        public short estanteID { get => sh_estanteID; set => sh_estanteID = value; }

        #endregion
    }
}
