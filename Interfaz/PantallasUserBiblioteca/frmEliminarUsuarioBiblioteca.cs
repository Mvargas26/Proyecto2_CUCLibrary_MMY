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
    public partial class frmEliminarUsuarioBiblioteca : Form
    {
        public frmEliminarUsuarioBiblioteca()
        {
            InitializeComponent();
        }

        //Globales
        Usuario_Biblioteca_Procesos objnegociosUB = new Usuario_Biblioteca_Procesos();
        Procesos objNegociosProcesos = new Procesos();
        clUsuarioBibliteca newUB = new clUsuarioBibliteca();
        DataTable dtUsuarioUB = new DataTable();

        //----------------------------------------

        private void frmEliminarUsuarioBiblioteca_Load(object sender, EventArgs e)
        {
            try
            {
                dtUsuarioUB = objNegociosProcesos.QueryGeneralNegocios_DT("SELECT * FROM USuarioBiblioteca");

                foreach (DataRow fila in dtUsuarioUB.Rows)
                {
                    cmbIdUserUB.Items.Add(fila["UsuarioBibliotecaID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//fin frmModificarUserBiblioteca_Load
        }//fin load

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fin cancelar

        private void cmbIdUserUB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtUsuarioUB.Rows)
                {
                    if (fila["UsuarioBibliotecaID"].ToString().Equals(cmbIdUserUB.SelectedItem))
                    {
                        txtUsuario.Text = fila["UserUB"].ToString();
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
            try { 
            //validaciones
            if(cmbIdUserUB.Text=="" || txtUsuario.Text == "")
            {
                MessageBox.Show("Seleccione un Usuario para Borrar");

            }
                //fin validaciones

                //El unico valor que necesitamos cargar al objeto
                //para borrarlo es el ID
                newUB.userBiId = Convert.ToInt16(cmbIdUserUB.Text);
                newUB.nombreUB = "";
                newUB.apellidosUB = "";
                newUB.UserUB = "";
                newUB.passwordUB = "";
                newUB.edadUB = 0;
                newUB.estado = 0;
               

                //con este objeto de negocios llamamos el SP
                objnegociosUB.GrabarUserBiblio(3, newUB);
                MessageBox.Show("Usuario Biblioteca Borrado Correctamente");
                this.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
