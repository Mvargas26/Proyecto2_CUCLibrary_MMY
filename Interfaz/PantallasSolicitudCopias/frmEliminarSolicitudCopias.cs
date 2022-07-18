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

namespace Interfaz.PantallasSolicitudCopias
{
    public partial class frmEliminarSolicitudCopias : Form
    {
        public frmEliminarSolicitudCopias()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtSolCopias = new DataTable();
        DataTable dtusuariosB = new DataTable();
        short idSolicitud;
        //-------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarSolicitudCopias_Load(object sender, EventArgs e)
        {
            try
            {
                dtSolCopias = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM SolicitudCopias;");

                foreach (DataRow fila in dtSolCopias.Rows)
                {
                    cmbIDsolicitud.Items.Add(fila["SolicitudCopiasID"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin frmEliminarSolicitudCopias_Load

        private void cmbIDsolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtusuariosB = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM USuarioBiblioteca;");

                foreach (DataRow fila in dtusuariosB.Rows)
                {
                    if (fila["UsuarioBibliotecaID"].ToString().Equals(cmbIDsolicitud.Text))
                    {
                        txtUsuarioSolicia.Text = fila["NombreUB"].ToString();
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin cmbIDsolicitud_SelectedIndexChanged

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones
                if (cmbIDsolicitud.Text == "" || txtUsuarioSolicia.Text=="")
                {
                    MessageBox.Show("Se requiere que selecione una Solicitud de Copias");
                    return;
                }

                idSolicitud = Convert.ToInt16(cmbIDsolicitud.Text);

                objNegocios.QueryGeneralNegocios_DT("DELETE FROM SolicitudCopias"+
                    " WHERE "+
                    "SolicitudCopiasID = "+idSolicitud);

                MessageBox.Show("Solicitud Eliminada Correctamente");
                this.Close();

            }         
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class

}//fin space
