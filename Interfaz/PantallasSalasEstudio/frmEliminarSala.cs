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
    public partial class frmEliminarSala : Form
    {
        public frmEliminarSala()
        {
            InitializeComponent();
        }
        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtSalas= new DataTable();
        //--------------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarSala_Load(object sender, EventArgs e)
        {
            try
            {
                dtSalas = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM SalaEstudio");

                foreach (DataRow fila in dtSalas.Rows)
                {
                    this.cmbIDSala.Items.Add(fila["SalaID"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin load

        private void cmbIDSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtSalas.Rows)
                {
                    if (fila["SalaID"].ToString().Equals(cmbIDSala.SelectedItem.ToString()))
                    {
                        this.txtTipoSala.Text = fila["TipoSala"].ToString();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                //validaciones
                if (txtTipoSala.Text == "" || cmbIDSala.Text == "")
                {
                    MessageBox.Show("Selecione Alguna Sala");
                    return;
                }

                string idSalaBorrar = cmbIDSala.Text;

                // Despues Enviamos el Query a Autor 
                objNegocios.QueryGeneralNegocios_DT("DELETE FROM SalaEstudio " +
                    " WHERE " +
                    "SalaID= '" + idSalaBorrar + "';");

                MessageBox.Show("Se elimino la Sala Correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin btn Eliminar

    }//fin class
}//fin space
