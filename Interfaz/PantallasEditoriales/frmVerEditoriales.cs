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

namespace Interfaz.PantallasEditoriales
{
    public partial class frmVerEditoriales : Form
    {
        public frmVerEditoriales()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtDatos = new DataTable();
        //----------------------------------------

        private void frmVerEditoriales_Load(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerEditoriales.DataSource = null;
                dgvVerEditoriales.Columns.Clear();
                dgvVerEditoriales.Rows.Clear();


                dtDatos = objNegocios.QueryGeneralNegocios_DT("SELECT E.EditorialID 'Identificacion de la Editorial',E.EditorialNombre 'Nombre de la Editorial'," +
                    "E.EditorialLugarOrigen 'Lugar de Origen' " +
                    " FROM Editorial E");

                dgvVerEditoriales.DataSource = dtDatos;
                dgvVerEditoriales.Update();
                dgvVerEditoriales.ReadOnly = true;
                dgvVerEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fn

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerEditoriales.DataSource = null;
                dgvVerEditoriales.Columns.Clear();
                dgvVerEditoriales.Rows.Clear();


                string EditorialIdBuscar = txtEditorialID.Text;
                string EditorialNombreBuscar = txtEditorialNombre.Text;

                //columnas manualmente
                dgvVerEditoriales.ColumnCount = 3;

                dgvVerEditoriales.Columns[0].Name = "Identificacion de la Editorial";
                dgvVerEditoriales.Columns[1].Name = "Nombre de la Editorial";
                dgvVerEditoriales.Columns[2].Name = "Lugar de origen";


                foreach (DataRow fila in dtDatos.Rows)
                {
                    if (fila["Identificacion de la Editorial"].ToString().Equals(EditorialIdBuscar) || fila["Nombre de la Editorial"].ToString().Equals(EditorialNombreBuscar))
                    {
                        dgvVerEditoriales.Rows.Add(fila["Identificacion de la Editorial"], fila["Nombre de la Editorial"], fila["Lugar de origen"]);
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
                this.txtEditorialNombre.Text = "";
                this.txtEditorialID.Text = "";

                //primero limpiamos el data grid
                dgvVerEditoriales.DataSource = null;
                dgvVerEditoriales.Columns.Clear();
                dgvVerEditoriales.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
