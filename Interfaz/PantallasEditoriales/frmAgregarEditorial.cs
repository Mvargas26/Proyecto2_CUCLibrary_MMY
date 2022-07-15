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
    public partial class frmAgregarEditorial : Form
    {
        public frmAgregarEditorial()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        clEditorial newEditorial = new clEditorial();
     
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
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

                newEditorial.EditorialId = 0;// 0 xq este lo pone la BD
                newEditorial.EditorialNombre = txtNombreEditorial.Text;
                newEditorial.EditorialLugarO = txtLugarOrigen.Text;

                objNegocios.QueryGeneralNegocios_DT("INSERT into Editorial(EditorialNombre,EditorialLugarOrigen) " +
                    " Values " +
                    "('" + newEditorial.EditorialNombre + "','" + newEditorial.EditorialLugarO + "');");

                MessageBox.Show("Editorial Correctamente");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
