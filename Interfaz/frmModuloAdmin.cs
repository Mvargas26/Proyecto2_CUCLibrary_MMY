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
    public partial class frmModuloAdmin : Form
    {
        public frmModuloAdmin()
        {
            InitializeComponent();
        }

        private void mnagregarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarLibro pantalla = new frmAgregarLibro();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin agregar libro

        private void mnModificarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                frmModificarLibro pantalla = new frmModificarLibro();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fn modificarlibro

        private void frmModuloAdmin_Load(object sender, EventArgs e)
        {

        }//fin del Load

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }//fin class
}//fin space

