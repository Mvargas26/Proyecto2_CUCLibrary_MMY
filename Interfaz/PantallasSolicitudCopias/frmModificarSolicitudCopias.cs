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

namespace Interfaz.PantallasSolicitudCopias
{
    public partial class frmModificarSolicitudCopias : Form
    {
        public frmModificarSolicitudCopias()
        {
            InitializeComponent();
        }


        //Globales
        Procesos objNegocios = new Procesos();

        DataTable dtUsuariosB = new DataTable();
        DataTable dtLibros = new DataTable();
        DataTable dtSolCopias = new DataTable();

        short idSolictudCopias;
        short idLibroSelecionado;
        short idUsuarioSelecionado;
        int cantCopias;
        short estado;
        //------------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void frmModificarSolicitudCopias_Load(object sender, EventArgs e)
        {
            try
            {
                dtUsuariosB = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM UsuarioBiblioteca;");
                dtLibros = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM Libro;");
                dtSolCopias = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM SolicitudCopias;");

                foreach (DataRow fila in dtSolCopias.Rows)
                {
                    cmbIDSolicitud.Items.Add(fila["SolicitudCopiasID"].ToString());
                }

                foreach (DataRow fila in dtUsuariosB.Rows)
                {
                    cmbUsuario.Items.Add(fila["UserUB"].ToString());
                }

                foreach (DataRow fila in dtLibros.Rows)
                {
                    cmbLibro.Items.Add(fila["LibroNombre"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbIDSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                 foreach (DataRow fila in dtSolCopias.Rows)
                {
                    if (fila["SolicitudCopiasID"].ToString().Equals(cmbIDSolicitud.Text))
                    {
                        //salvamos el id del usuario,del libro y de la solicitud
                        idUsuarioSelecionado = Convert.ToInt16(fila["UsuarioID"].ToString());
                        idLibroSelecionado= Convert.ToInt16(fila["LibroID"].ToString());
                        idSolictudCopias= Convert.ToInt16(fila["SolicitudCopiasID"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtUsuariosB.Rows)
                {
                    if (fila["UserUB"].ToString().Equals(cmbUsuario.Text))
                    {
                        idUsuarioSelecionado = Convert.ToInt16(fila["UsuarioBibliotecaID"].ToString());
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtLibros.Rows)
                {
                    if (fila["LibroNombre"].ToString().Equals(cmbLibro.Text))
                    {
                        idLibroSelecionado = Convert.ToInt16(fila["LibroID"].ToString());
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones
                if (cmbUsuario.Text == "")
                {
                    MessageBox.Show("Se requiere que selecione un Usuario");
                    return;
                }

                if (cmbLibro.Text == "")
                {
                    MessageBox.Show("Se requiere que selecione un Libro");
                    return;
                }

                if (txtPaginas.Text == "")
                {
                    MessageBox.Show("Indique la cantidad de Paginas");
                    return;
                }
                if (cmbEstado.Text == "")
                {
                    MessageBox.Show("Indique si la solicitud de copias esta pendiente o finalizada");
                    return;
                }

                if (!IsNumeric(txtPaginas.Text))
                {

                    MessageBox.Show("la cantidad debe ser numerica");
                    return;
                }
                //FIN VALIDACIONES

                cantCopias = Convert.ToInt32(txtPaginas.Text);

                objNegocios.QueryGeneralNegocios_DT("UPDATE SolicitudCopias " +
                   " SET " +
                   " LibroID= "+idLibroSelecionado+" , "+
                   "UsuarioID = "+ idUsuarioSelecionado+ " , " +
                   " cantPaginas= " +cantCopias+ " , " +
                   " Estado= " +estado+
                   " WHERE SolicitudCopiasID= "+idSolictudCopias);

                MessageBox.Show("Solicitud Modificada Correctamente");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstado.SelectedIndex == 0)//si sleeciono la primer opcion, la solicitud de copias esta finalizada
                {
                    estado = 1;
                }
                else
                {
                    estado = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
