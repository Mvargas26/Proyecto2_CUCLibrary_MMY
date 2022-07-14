using Entidades;
using Negocios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Interfaz.PantallasLIbros
{
    public partial class frmDGVAutores : Form
    {
        public frmDGVAutores()
        {
            InitializeComponent();
        }
        Procesos objNegocios = new Procesos();
        DataTable dtDatos = new DataTable();
       private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach(DataGridViewRow fila in dgvAutoresYaSelec.Rows)
                {
                    string id = fila.Cells["colID"].Value.ToString();
                    cl_estatic_list_Autores.cadenaAutores += id+";";

                }
      

                this.Close();

            }//fn try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmDGVAutores_Load(object sender, EventArgs e)
        {
            try
            {
                cl_estatic_list_Autores.cadenaAutores = "";

                //primero limpiamos el data grid
                dgvAutoresRegistrados.DataSource = null;
                dgvAutoresRegistrados.Columns.Clear();
                dgvAutoresRegistrados.Rows.Clear();

                dgvAutoresYaSelec.Rows.Clear();

               //ya limpio, lo llenamos con lo que nos trae el select
                dgvAutoresRegistrados.AutoGenerateColumns = true;
                dgvAutoresRegistrados.DataSource = objNegocios.QueryGeneralNegocios_DT("Select AutorID 'Identificación', AutorNombre 'Nombre',AutorLugarOrigen 'Lugar de Origen' from Autor;");
                dgvAutoresRegistrados.Update();
                dgvAutoresRegistrados.ReadOnly = true;
                dgvAutoresRegistrados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // guardamos el contenido de la fila selecionada en 3 variables, despues se agregan al otro datagrid
                string id = dgvAutoresRegistrados[0, dgvAutoresRegistrados.CurrentRow.Index].Value.ToString();
                string nombre = dgvAutoresRegistrados[1, dgvAutoresRegistrados.CurrentRow.Index].Value.ToString();
                string lugar = dgvAutoresRegistrados[2, dgvAutoresRegistrados.CurrentRow.Index].Value.ToString();

                dgvAutoresYaSelec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvAutoresYaSelec.Rows.Add(id, nombre, lugar);
                dgvAutoresYaSelec.Update();

                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvAutoresYaSelec.SelectedRows)
                {
                    dgvAutoresYaSelec.Rows.RemoveAt(row.Index);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }//fin class

}//fin space
