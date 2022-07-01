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
    public partial class frmModificarLibro : Form
    {
        public frmModificarLibro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarAutores_Click(object sender, EventArgs e)
        {
            try
            {
                frmDGVAutores pantalla = new frmDGVAutores();
                pantalla.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
