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
    public partial class frmAgregarSolicitudCopias : Form
    {
        public frmAgregarSolicitudCopias()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtUsuariosB = new DataTable();
        DataTable dtLibros = new DataTable();
        short idLibroSelecionado;
        short estado;
        short idUsuarioSelecionado;
        //------------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarSolicitudCopias_Load(object sender, EventArgs e)
        {
            try
            {
                dtUsuariosB = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM UsuarioBiblioteca;");
                dtLibros = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM Libro;");

                foreach (DataRow fila in dtUsuariosB.Rows)
                {
                    cmbUsuarioSolicita.Items.Add(fila["UserUB"].ToString());
                }

                foreach (DataRow fila in dtLibros.Rows)
                {
                    cmbLibroSolicita.Items.Add(fila["LibroNombre"].ToString());
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin loas

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones
                if (cmbUsuarioSolicita.Text=="")
                {
                    MessageBox.Show("Se requiere que selecione un Usuario");
                    return;
                }

                if (cmbLibroSolicita.Text == "")
                {
                    MessageBox.Show("Se requiere que selecione un Libro");
                    return;
                }

                if (txtCantPaginas.Text == "")
                {
                    MessageBox.Show("Indique la cantidad de Paginas");
                    return;
                }
                if (cmbEstado.Text == "")
                {
                    MessageBox.Show("Indique si la solicitud de copias esta pendiente o finalizada");
                    return;
                }

                if (!IsNumeric(txtCantPaginas.Text))
                {

                    MessageBox.Show("la cantidad debe ser numerica");
                    return;
                }
                //FIN VALIDACIONES
                objNegocios.QueryGeneralNegocios_DT("INSERT INTO SolicitudCopias(LibroID,UsuarioID,cantPaginas,Estado)"+
                   " VALUES "+
                   "("+idLibroSelecionado +" , "+ idUsuarioSelecionado +" , "+ Convert.ToInt32(txtCantPaginas.Text) + " , "+estado+")");

                MessageBox.Show("Solicitud Creada Correctamente");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void cmbUsuarioSolicita_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtUsuariosB.Rows)
                {
                    if (fila["UserUB"].ToString().Equals(cmbUsuarioSolicita.Text))
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

        private void cmbLibroSolicita_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtLibros.Rows)
                {
                    if (fila["LibroNombre"].ToString().Equals(cmbLibroSolicita.Text))
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

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstado.SelectedIndex==0)//si sleeciono la primer opcion, la solicitud de copias esta finalizada
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
