using Interfaz.PantallasLIbros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class frmAgregarLibro : Form
    {
        public frmAgregarLibro()
        {
            InitializeComponent();
        }

        private void btnAgregarAutores_Click(object sender, EventArgs e)
        {
            try { 
            frmDGVAutores pantalla = new frmDGVAutores();
            pantalla.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fn btnAgregarAutores

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }//fn class
}//fin space
