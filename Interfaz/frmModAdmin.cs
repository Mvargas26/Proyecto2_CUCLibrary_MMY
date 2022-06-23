using Interfaz.PantallasAutores;
using Interfaz.PantallasEditoriales;
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
    public partial class frmModAdmin : Form
    {
        public frmModAdmin()
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
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fin agregaR libro

        private void mnModificarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                frmModificarLibro pantalla = new frmModificarLibro();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fn modificar  libro

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }//fin boton salir

        private void mnEliminarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                frmEliminarLibro pantalla = new frmEliminarLibro();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fin eliminar libro

        private void mnVerLibros_Click(object sender, EventArgs e)
        {
            try
            {
                frmVerLibros pantalla = new frmVerLibros();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fin ver libro

        private void agregarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarAutor pantalla = new frmAgregarAutor();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }


        }//fin agregar autor

        private void mnModificarAutor_Click(object sender, EventArgs e)
        {
            try
            {
                frmModificarAutor pantalla = new frmModificarAutor();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fn modificarAutor

        private void mnEliminarAutor_Click(object sender, EventArgs e)
        {
            try
            {
                frmEliminarAutor pantalla = new frmEliminarAutor();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }

        }//fn elim autor

        private void mnVerAutores_Click(object sender, EventArgs e)
        {
            try
            {
                frmVerAutores pantalla = new frmVerAutores();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }

        }//fn ver autor

        private void mnAgregarEditorial_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarEditorial pantalla = new frmAgregarEditorial();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fin agregarEditorial

        private void mnModificarEditorial_Click(object sender, EventArgs e)
        {
            try
            {
                frmModificarEditorial pantalla = new frmModificarEditorial();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }

        }//fn modif editori

        private void mnEliminarEditorial_Click(object sender, EventArgs e)
        {
            try
            {
                frmEliminarEditorial pantalla = new frmEliminarEditorial();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fn elim editori




    }//fin class
}//fin space
