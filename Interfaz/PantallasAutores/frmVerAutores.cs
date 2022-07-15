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

namespace Interfaz.PantallasAutores
{
    public partial class frmVerAutores : Form
    {
        public frmVerAutores()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtDatos = new DataTable();
   
        private void frmVerAutores_Load(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerAutores.DataSource = null;
                dgvVerAutores.Columns.Clear();
                dgvVerAutores.Rows.Clear();


                dtDatos = objNegocios.QueryGeneralNegocios_DT("SELECT A.AutorID 'Identificacion del Autor',A.AutorNombre 'Nombre del Autor',"+
                    "A.AutorLugarorigen 'Lugar de origen' "+
                    " FROM Autor A");

                dgvVerAutores.DataSource = dtDatos;
                dgvVerAutores.Update();
                dgvVerAutores.ReadOnly = true;
                dgvVerAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin frmVerAutores_Load

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerAutores.DataSource = null;
                dgvVerAutores.Columns.Clear();
                dgvVerAutores.Rows.Clear();


                string AutorIdBuscar = txtAutorID.Text;
                string AutorNombreBuscar = txtAutorNombre.Text;

                //columnas manualmente
                dgvVerAutores.ColumnCount = 8;

                dgvVerAutores.Columns[0].Name = "Identificacion del Autor";
                dgvVerAutores.Columns[1].Name = "Nombre del Autor";
                dgvVerAutores.Columns[2].Name = "Lugar de origen";
             

                foreach (DataRow fila in dtDatos.Rows)
                {
                    if (fila["Identificacion del Autor"].ToString().Equals(AutorIdBuscar) || fila["Nombre del Autor"].ToString().Equals(AutorNombreBuscar))
                    {
                        dgvVerAutores.Rows.Add(fila["Identificacion del Autor"], fila["Nombre del Autor"], fila["Lugar de origen"]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin btnBuscar_Click

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtAutorNombre.Text = "";
                this.txtAutorID.Text = "";

                //primero limpiamos el data grid
                dgvVerAutores.DataSource = null;
                dgvVerAutores.Columns.Clear();
                dgvVerAutores.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin limpiarCampos
    }//fin class
    
}//fin space
