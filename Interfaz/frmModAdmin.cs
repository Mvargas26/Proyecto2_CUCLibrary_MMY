using Interfaz.PantallasAutores;
using Interfaz.PantallasEditoriales;
using Interfaz.PantallasLIbros;
using Interfaz.PantallasReservas;
using Interfaz.PantallasSalasEstudio;
using Interfaz.PantallasUserBiblioteca;
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

        private void mnVerEditoriales_Click(object sender, EventArgs e)
        {
            try
            {
                frmVerEditoriales pantalla = new frmVerEditoriales();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void mnAgregarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarReserva pantalla = new frmAgregarReserva();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void mnModificarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                frmModificarReserva pantalla = new frmModificarReserva();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void mnEliminarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                frmEliminarReserva pantalla = new frmEliminarReserva();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void mnVerReservas_Click(object sender, EventArgs e)
        {
            try
            {
                frmVerReservas pantalla = new frmVerReservas();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void mnAgregarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarUsuarioBiblioteca pantalla = new frmAgregarUsuarioBiblioteca();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fn agregar user biblio

        private void mnModificarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmModificarUserBiblioteca pantalla = new frmModificarUserBiblioteca();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fin moficiar user biblio

        private void mnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmEliminarUsuarioBiblioteca pantalla = new frmEliminarUsuarioBiblioteca();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fn elim user biblio

        private void mnVerUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                frmVerUserBiblioteca pantalla = new frmVerUserBiblioteca();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fn ver user biblio

        private void agregarSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAgregarSala pantalla = new frmAgregarSala();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fn agregar sala


        private void modificarSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmModificarSala pantalla = new frmModificarSala();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fn modificar sala

        private void eliminarSalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmEliminarSala pantalla = new frmEliminarSala();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fn eliminarSala

        private void verSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmVerSala pantalla = new frmVerSala();
                pantalla.MdiParent = this;
                pantalla.Show();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }//fn ver sala



    }//fin class
}//fin space
