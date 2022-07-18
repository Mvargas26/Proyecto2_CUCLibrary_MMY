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
    public partial class frmVerSolicitudesCopias : Form
    {
        public frmVerSolicitudesCopias()
        {
            InitializeComponent();
        }
        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtDatos = new DataTable();
        //----------------------------------------

        private void frmVerSolicitudesCopias_Load(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerSolicitud.DataSource = null;
                dgvVerSolicitud.Columns.Clear();
                dgvVerSolicitud.Rows.Clear();


                dtDatos = objNegocios.QueryGeneralNegocios_DT("SELECT SC.SolicitudCopiasID 'Numero de Solicitud',L.LibroNombre 'Libro'," +
                    "U.NombreUB 'Usuario Solicito',SC.cantPaginas 'Cant Paginas',SC.Estado 'Estado Finalizada' " +
                    "  FROM SolicitudCopias SC,Libro L, USuarioBiblioteca U "+
                    " WHERE  "+
                    "SC.LibroID=L.LIbroID  AND  SC.UsuarioID= U.UsuarioBibliotecaID ");

                dgvVerSolicitud.DataSource = dtDatos;
                dgvVerSolicitud.Update();
                dgvVerSolicitud.ReadOnly = true;
                dgvVerSolicitud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }//FIN LOAD

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtsolicitudID.Text = "";
                this.txtUsuario.Text = "";

                //primero limpiamos el data grid
                dgvVerSolicitud.DataSource = null;
                dgvVerSolicitud.Columns.Clear();
                dgvVerSolicitud.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerSolicitud.DataSource = null;
                dgvVerSolicitud.Columns.Clear();
                dgvVerSolicitud.Rows.Clear();


                string SolicitudIdBuscar = txtsolicitudID.Text;
                string UsuarioNombreBuscar = txtUsuario.Text;

                //columnas manualmente
                dgvVerSolicitud.ColumnCount = 5;

                dgvVerSolicitud.Columns[0].Name = "Numero de Solicitud";
                dgvVerSolicitud.Columns[1].Name = "Libro";
                dgvVerSolicitud.Columns[2].Name = "Usuario Solicito";
                dgvVerSolicitud.Columns[3].Name = "Cant Paginas";
                dgvVerSolicitud.Columns[4].Name = "Estado Finalizada";
               


                foreach (DataRow fila in dtDatos.Rows)
                {
                    if (fila["Numero de Solicitud"].ToString().Equals(SolicitudIdBuscar) || fila["Usuario Solicito"].ToString().Equals(UsuarioNombreBuscar))
                    {
                        dgvVerSolicitud.Rows.Add(fila["Numero de Solicitud"], fila["Libro"], fila["Usuario Solicito"],
                            fila["Cant Paginas"], fila["Estado Finalizada"]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fun buscar
    }//fin class
}//fin space
