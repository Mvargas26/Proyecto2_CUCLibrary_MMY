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
    public partial class frmVerUserBiblioteca : Form
    {
        public frmVerUserBiblioteca()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtDatos = new DataTable();
        //----------------------------------------

        private void frmVerUserBiblioteca_Load(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerusuariosBiblioteca.DataSource = null;
                dgvVerusuariosBiblioteca.Columns.Clear();
                dgvVerusuariosBiblioteca.Rows.Clear();


                dtDatos = objNegocios.QueryGeneralNegocios_DT("SELECT  UB.UsuarioBibliotecaID 'ID',UB.NombreUB 'Nombre',UB.ApellidosUB 'Apellidos',UB.UserUB 'Usuario'," +
                    "UB.EdadUB 'Edad',UB.EstadoUB 'Esta Activo' " +
                    " FROM USuarioBiblioteca UB");

                dgvVerusuariosBiblioteca.DataSource = dtDatos;
                dgvVerusuariosBiblioteca.Update();
                dgvVerusuariosBiblioteca.ReadOnly = true;
                dgvVerusuariosBiblioteca.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }//fin load

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtUsuario.Text = "";
                this.txtUserID.Text = "";

                //primero limpiamos el data grid
                dgvVerusuariosBiblioteca.DataSource = null;
                dgvVerusuariosBiblioteca.Columns.Clear();
                dgvVerusuariosBiblioteca.Rows.Clear();

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
                dgvVerusuariosBiblioteca.DataSource = null;
                dgvVerusuariosBiblioteca.Columns.Clear();
                dgvVerusuariosBiblioteca.Rows.Clear();


                string UsuarioIdBuscar = txtUserID.Text;
                string UsuarioNombreBuscar = txtUsuario.Text;

                //columnas manualmente
                dgvVerusuariosBiblioteca.ColumnCount = 6;

                dgvVerusuariosBiblioteca.Columns[0].Name = "ID";
                dgvVerusuariosBiblioteca.Columns[1].Name = "Nombre";
                dgvVerusuariosBiblioteca.Columns[2].Name = "Apellidos";
                dgvVerusuariosBiblioteca.Columns[3].Name = "Usuario";
                dgvVerusuariosBiblioteca.Columns[4].Name = "Edad";
                dgvVerusuariosBiblioteca.Columns[5].Name = "Esta Activo";


                foreach (DataRow fila in dtDatos.Rows)
                {
                    if (fila["ID"].ToString().Equals(UsuarioIdBuscar) || fila["Usuario"].ToString().Equals(UsuarioNombreBuscar))
                    {
                        dgvVerusuariosBiblioteca.Rows.Add(fila["ID"], fila["Nombre"], fila["Apellidos"],
                            fila["Usuario"], fila["Edad"], fila["Esta Activo"]);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin btn buscar

    }//fin class
}//fin space
