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

namespace Interfaz.PantallasSalasEstudio
{
    public partial class frmVerSala : Form
    {
        public frmVerSala()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtDatos = new DataTable();
        //----------------------------------------

        private void frmVerSala_Load(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerSala.DataSource = null;
                dgvVerSala.Columns.Clear();
                dgvVerSala.Rows.Clear();


                dtDatos = objNegocios.QueryGeneralNegocios_DT("SELECT S.SalaID 'ID',S.TipoSala 'Tipo de Sala',S.EstadoSala 'Esta Libre'" +
                    " FROM SalaEstudio S");

                dgvVerSala.DataSource = dtDatos;
                dgvVerSala.Update();
                dgvVerSala.ReadOnly = true;
                dgvVerSala.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
                dgvVerSala.DataSource = null;
                dgvVerSala.Columns.Clear();
                dgvVerSala.Rows.Clear();


                string SalaIdBuscar = txtSalaID.Text;
                string SalaNombreBuscar = txtSalaNombre.Text;

                //columnas manualmente
                dgvVerSala.ColumnCount = 3;

                dgvVerSala.Columns[0].Name = "ID";
                dgvVerSala.Columns[1].Name = "Tipo de Sala";
                dgvVerSala.Columns[2].Name = "Esta Libre";


                foreach (DataRow fila in dtDatos.Rows)
                {
                    if (fila["ID"].ToString().Equals(SalaIdBuscar) || fila["Tipo de Sala"].ToString().Equals(SalaNombreBuscar))
                    {
                        dgvVerSala.Rows.Add(fila["ID"], fila["Tipo de Sala"], fila["Esta Libre"]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtSalaID.Text = "";
                this.txtSalaNombre.Text = "";

                //primero limpiamos el data grid
                dgvVerSala.DataSource = null;
                dgvVerSala.Columns.Clear();
                dgvVerSala.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
