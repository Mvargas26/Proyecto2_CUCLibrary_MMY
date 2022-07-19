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

namespace Interfaz.PantallasReservas
{
    public partial class frmVerReservas : Form
    {
        public frmVerReservas()
        {
            InitializeComponent();
        }
        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtDatos = new DataTable();
       

        //----------------------------------------


        private void frmVerReservas_Load(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerReservas.DataSource = null;
                dgvVerReservas.Columns.Clear();
                dgvVerReservas.Rows.Clear();

                dgvVerReservas.AutoGenerateColumns = true;
                dtDatos = objNegocios.QueryGeneralNegocios_DT("SELECT R.ReservaID 'Numero Reserva',U.NombreUB 'Nombre Usuario',L.LibroNombre 'Libro',"+
                    "R.SalaID 'Numero Sala',R.FechaRetiro 'Fecha Inicio',"+
                    "R.FechaRegreso 'Fecha Fin',R.EstadoReserva 'Reserva Activa'"+
                    " FROM Reserva R,USuarioBiblioteca U,Libro L "+
                    " WHERE R.IDusuario=U.UsuarioBibliotecaID and R.IDLibro = L.LIbroID");
                dgvVerReservas.DataSource = dtDatos;
                dgvVerReservas.Update();
                dgvVerReservas.ReadOnly = true;
                dgvVerReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }//fin load

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerReservas.DataSource = null;
                dgvVerReservas.Columns.Clear();
                dgvVerReservas.Rows.Clear();


                string ReservaIdBuscar = txtReservaId.Text;
                string libroNombreBuscar = txtReservaNombre.Text;

                //columnas manualmente
                dgvVerReservas.ColumnCount = 7;

                dgvVerReservas.Columns[0].Name = "Numero Reserva";
                dgvVerReservas.Columns[1].Name = "Nombre Usuario";
                dgvVerReservas.Columns[2].Name = "Libro";
                dgvVerReservas.Columns[3].Name = "Numero Sala";
                dgvVerReservas.Columns[4].Name = "Fecha Inicio";
                dgvVerReservas.Columns[5].Name = "Fecha Fin";
                dgvVerReservas.Columns[6].Name = "Reserva Activa";
               

                foreach (DataRow fila in dtDatos.Rows)
                {
                    if (fila["Numero Reserva"].ToString().Equals(ReservaIdBuscar) || fila["Libro"].ToString().Equals(libroNombreBuscar))
                    {
                        dgvVerReservas.Rows.Add(fila["Numero Reserva"], fila["Nombre Usuario"], fila["Libro"],
                            fila["Numero Sala"], fila["Fecha Inicio"], fila["Fecha Fin"], fila["Reserva Activa"]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin buscar

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtReservaNombre.Text = "";
                this.txtReservaId.Text = "";

                //primero limpiamos el data grid
                dgvVerReservas.DataSource = null;
                dgvVerReservas.Columns.Clear();
                dgvVerReservas.Rows.Clear();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
