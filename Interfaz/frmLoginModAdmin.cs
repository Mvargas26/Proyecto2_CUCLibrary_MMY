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

namespace Interfaz
{
    public partial class frmLoginModAdmin : Form
    {
        public frmLoginModAdmin()
        {
            InitializeComponent();
        }
        //Variables Globales
        Procesos objProcesos = new Procesos();
        DataTable dtUsuariosAdmin = new DataTable();
        string usuarioConsultar;
        string passwordConsultar;
        Boolean credencialesValidas=false;
        Boolean edadValida= false;

        //---------------
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioConsultar= txtUsuarioConsultar.Text;
                passwordConsultar = txtPasswordConsultar.Text;

                //primero validamos usuario y contraseña
                foreach(DataRow fila in dtUsuariosAdmin.Rows)
                {
                    if(fila["UserSA"].ToString().Equals(usuarioConsultar) && (fila["PasswordSA"].ToString().Equals(passwordConsultar)))
                        {
                            credencialesValidas = true;
                            break;
                        }
                }

                //luego Validamos la edad
                foreach (DataRow fila in dtUsuariosAdmin.Rows)
                {
                    if (fila["UserSA"].ToString().Equals(usuarioConsultar)) { 
                        if (Convert.ToInt32(fila["EdadSA"].ToString()) >= 18)
                    {
                        edadValida = true;
                        break;
                    }
                    }
                }

                if(credencialesValidas== false)
                {
                    MessageBox.Show("Usuario o Password Incorrecto");
                    return;
                }

                if(edadValida == false)
                {
                    MessageBox.Show("Este usuario es menor de Edad, intente con otro ");
                    return;
                }

                MessageBox.Show("Bienvenido: *** " + usuarioConsultar +" ***");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin entrar

        private void frmLoginModAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                dtUsuariosAdmin = objProcesos.QueryGeneralNegocios_DT("SELECT * FROM UsuarioSistema");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkPassword.Checked == true)
                {
                    txtPasswordConsultar.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPasswordConsultar.UseSystemPasswordChar = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
