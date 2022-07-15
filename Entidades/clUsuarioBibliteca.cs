using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class clUsuarioBibliteca
    {
        #region Variables
        private short sht_userBiId;
        private string str_nombreUB;
        private string str_apellidosUB;
        private string str_UserUB;
        private string str_passwordUB;
        private int int_edadUB;
        private short bo_estado;
        #endregion
        #region Properties
        public short userBiId { get => sht_userBiId; set => sht_userBiId = value; }
        public string nombreUB { get => str_nombreUB; set => str_nombreUB = value; }
        public string apellidosUB { get => str_apellidosUB; set => str_apellidosUB = value; }
        public string UserUB { get => str_UserUB; set => str_UserUB = value; }
        public string passwordUB { get => str_passwordUB; set => str_passwordUB = value; }
        public int edadUB { get => int_edadUB; set => int_edadUB = value; }
        public short estado { get => bo_estado; set => bo_estado = value; }
        #endregion


    }//fin class
}//fin space
