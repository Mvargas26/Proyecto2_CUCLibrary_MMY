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

namespace Interfaz.PantallasUserBiblioteca
{
    public partial class frmAgregarUsuarioBiblioteca : Form
    {
        public frmAgregarUsuarioBiblioteca()
        {
            InitializeComponent();
        }

        //Globales
        Usuario_Biblioteca_Procesos objnegociosUB = new Usuario_Biblioteca_Procesos();
         clUsuarioBibliteca newUB = new clUsuarioBibliteca();
   
        //----------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //VALIDACIONES
                if (txtNombre.Text=="")
                {
                    MessageBox.Show("El nombre es requerido");
                    return;
                }

                if (txtApellidos.Text == "")
                {
                    MessageBox.Show("Los Apellidos son requerido");
                    return;
                }

                if (txtUser.Text == "")
                {
                    MessageBox.Show("El nombre de Usuario es requerido");
                    return;
                }

                if (txtPassword.Text == "")
                {
                    MessageBox.Show("El Password es requerido");
                    return;
                }

                if (txtPassword.Text != txtConformar.Text)
                {
                    MessageBox.Show("El Password y la confirmacion son Diferentes");
                    return;
                }

                if (txtEdad.Text == "")
                {
                    MessageBox.Show("La edad es requerida");
                    return;
                }

                if (!IsNumeric(txtEdad.Text))
                {
                    MessageBox.Show("La edad debe ser numerica");
                    return;
                }
                // FIN VALIDACIONES

                //Cargamos un onjeto de tipo UserBIblioteca con la info
                newUB.userBiId = 0;//enviamos 0 poruqe la base d edatos s elo va asignar
                newUB.nombreUB = txtNombre.Text;
                newUB.apellidosUB = txtApellidos.Text;
                newUB.UserUB = txtUser.Text;
                newUB.passwordUB = txtPassword.Text;
                newUB.edadUB = Convert.ToInt32(txtEdad.Text);
                if (cmbEstado.SelectedIndex == 0 || cmbEstado.Text=="Activo")// En la posicion 0 el combo tiene "Activo" x eso ponemos true
                {
                    newUB.estado = 1;
                }
                else
                {
                    newUB.estado = 0;
                }

                //con este objeto de negocios llamamos el SP
                objnegociosUB.GrabarUserBiblio(1, newUB);
                MessageBox.Show("Usuario Biblioteca Registrado Correctamente");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin btnAgregar_Click

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

       
    }//fin class
}//fin space
