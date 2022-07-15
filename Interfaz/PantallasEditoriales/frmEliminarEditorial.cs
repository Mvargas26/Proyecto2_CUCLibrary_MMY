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
    public partial class frmEliminarEditorial : Form
    {
        public frmEliminarEditorial()
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

        private void frmEliminarEditorial_Load(object sender, EventArgs e)
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
        }// fin frmEliminarEditorial_Load

        private void cmbEditorialID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtEditoriales.Rows)
                {
                    if (fila["EditorialID"].ToString().Equals(cmbEditorialID.SelectedItem.ToString()))
                    {
                        this.txtNombreEditorial.Text = fila["EditorialNombre"].ToString();

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin cmbEditorialID_SelectedIndexChanged

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                //validaciones
                if (txtNombreEditorial.Text == "" || cmbEditorialID.Text == "")
                {
                    MessageBox.Show("Selecione Alguna Editorial");
                    return;
                }

                string idEditorialBorrar = cmbEditorialID.Text;

                // Despues Enviamos el Query a Autor 
                objNegocios.QueryGeneralNegocios_DT("DELETE FROM Editorial " +
                    " WHERE " +
                    "EditorialID= '" + idEditorialBorrar + "';");

                MessageBox.Show("Se elimino la Editorial Correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin main
