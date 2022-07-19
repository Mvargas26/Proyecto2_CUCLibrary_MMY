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
    public partial class frmConsultasExtra : Form
    {
        public frmConsultasExtra()
        {
            InitializeComponent();
        }
        // Globales
        Procesos objNegocios = new Procesos();

        DataTable dtDatos = new DataTable();

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            try
            {
               
                this.cmbConsultas.Text = "";

                //primero limpiamos el data grid
                dgvConsultas.DataSource = null;
                dgvConsultas.Columns.Clear();
                dgvConsultas.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbConsultas.SelectedIndex == 0)
                {
                    txtLeyenda.Text = "Consulta 1:Listado de libros que incluya: Nombre del Libro, Nombre del Autor," +
                        " Fecha de publicación  y  editorial  que  lo  publicó.  Adicionalmente  indicar  el  lugar  de origen" +
                        " del autor y de la editorial.";

                    dtDatos = objNegocios.QueryGeneralNegocios_DT("SELECT L.LibroNombre 'Nombre del Libro',A.AutorNombre 'Nombre del Autor',L.FechaPublicacion 'Fecha Publicacion',"+
                        "E.EditorialNombre 'Editorial que Publico',E.EditorialLugarOrigen 'Lugar Origen Editorial', A.AutorLugarOrigen 'Lugar Origen autor'"+
                        " FROM Libro L, Libro_Autor LB, Editorial E,Autor A"+
                        " WHERE "+
                        "LB.AutorID = A.AutorID AND "+ " LB.LibroID = L.LIbroID AND "+ " L.EditorialID = E.EditorialID ");

                    //primero limpiamos el data grid
                    dgvConsultas.DataSource = null;
                    dgvConsultas.Columns.Clear();
                    dgvConsultas.Rows.Clear();
                    dgvConsultas.AutoGenerateColumns = true;

                    dgvConsultas.DataSource = dtDatos;
                    dgvConsultas.Update();
                    dgvConsultas.ReadOnly = true;
                    dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }

                if (cmbConsultas.SelectedIndex == 4)
                {
                    txtLeyenda.Text = "Consulta 5: Libro  con  más  antigüedad  dentro  de  la  biblioteca  " +
                        "(Nombre  del  Libro, Nombre del Autor, Fecha de publicación y editorial que lo publicó)";

                    dtDatos = objNegocios.QueryGeneralNegocios_DT(" SELECT L.LibroNombre 'Nombre del Libro', A.AutorNombre 'Nombre Autor',L.FechaPublicacion 'Fecha Publicacion',"+
                        " E.EditorialNombre 'Nombre Editorial'"+ " FROM Libro L,Libro_Autor LA,Autor A,Editorial E"+ " WHERE "+
                        " L.LIbroID=LA.LibroID and A.AutorID = LA.AutorID "+ "and L.EditorialID = E.EditorialID "+ " ORDER BY L.FechaPublicacion ASC");

                    //primero limpiamos el data grid
                    dgvConsultas.DataSource = null;
                    dgvConsultas.Columns.Clear();
                    dgvConsultas.Rows.Clear();
                    dgvConsultas.AutoGenerateColumns = true;

                    dgvConsultas.DataSource = dtDatos;
                    dgvConsultas.Update();
                    dgvConsultas.ReadOnly = true;
                    dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
