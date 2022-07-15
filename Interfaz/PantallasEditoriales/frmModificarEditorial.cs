using Entidades;
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

namespace Interfaz.PantallasEditoriales
{
    public partial class frmModificarEditorial : Form
    {
        public frmModificarEditorial()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        clEditorial newEditorial = new clEditorial();
        DataTable dtEditoriales = new DataTable();

        //----------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarEditorial_Load(object sender, EventArgs e)
        {
            try
            {
                dtEditoriales = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM Editorial");

                foreach (DataRow fila in dtEditoriales.Rows)
                {
                    this.cmbEditorialID.Items.Add(fila["EditorialID"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin load

        private void cmbEditorialID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtEditoriales.Rows)
                {
                    if (fila["EditorialID"].ToString().Equals(cmbEditorialID.SelectedItem.ToString()))
                    {
                        this.txtNombreEditorial.Text = fila["EditorialNombre"].ToString();
                        this.txtLugarOrigen.Text = fila["EditorialLugarOrigen"].ToString();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin cmbEditorialID_SelectedIndexChanged

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones

                //validaciones
                if (txtNombreEditorial.Text == "")
                {
                    MessageBox.Show("El Nombre de la Editorial es requerido");
                    return;
                }

                if (txtLugarOrigen.Text == "")
                {
                    MessageBox.Show("El lugar de Origen es requerido");
                    return;
                }
                //fin validaciones

                //cargamos el obj con la info nueva
                newEditorial.EditorialId = Convert.ToInt16(cmbEditorialID.SelectedItem);
                newEditorial.EditorialNombre = txtNombreEditorial.Text;
                newEditorial.EditorialLugarO = txtLugarOrigen.Text;

                // Enviamos el Query
                objNegocios.QueryGeneralNegocios_DT("UPDATE Editorial " +
                    " SET " +
                   "EditorialNombre=' " +
                   newEditorial.EditorialNombre + "'," +
                   "EditorialLugarOrigen='" + newEditorial.EditorialLugarO + "' " +
                   " WHERE " +
                   " EditorialID='" + newEditorial.EditorialId + "'");

                MessageBox.Show("Editorial Modificada Correctamente");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin modificar


    }//fin class
}//fin space
