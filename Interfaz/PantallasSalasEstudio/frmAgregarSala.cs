using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.PantallasSalasEstudio
{
    public partial class frmAgregarSala : Form
    {
        public frmAgregarSala()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        //------------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones
                if (txtTipoSala.Text == "")
                {
                    MessageBox.Show("El Nombre de la Sala es requerido");
                    return;
                }

                if (cmEstado.Text == "")
                {
                    MessageBox.Show("seleccione en que estado");
                    return;
                }
                //fin validaciones

                string strTipoSala = txtTipoSala.Text;
                short shtEstadoSala;

                if (cmEstado.SelectedIndex==0)//la posicion 0 es que esta Libre
                {
                    shtEstadoSala = 1;
                }
                else
                {
                    shtEstadoSala = 0;// o esque esta ocupada
                }

                objNegocios.QueryGeneralNegocios_DT("INSERT into SalaEstudio(TipoSala,EstadoSala) " +
                    " Values " +
                    "('" + strTipoSala + "','" + shtEstadoSala+ "');");

                MessageBox.Show("Sala Agregada Correctamente");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
