using Entidades;
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

namespace Interfaz.PantallasLIbros
{
    public partial class frmVerLibros : Form
    {
        public frmVerLibros()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtDatos = new DataTable();
        Libro_Autor_Procesos objLibroAutor = new Libro_Autor_Procesos();
      
        //----------------------------------------

        private void frmVerLibros_Load(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerLibros.DataSource = null;
                dgvVerLibros.Columns.Clear();
                dgvVerLibros.Rows.Clear();

                dgvVerLibros.AutoGenerateColumns = true;
                 dtDatos = objNegocios.QueryGeneralNegocios_DT("Select L.LibroID 'Identificacion del Libro',L.LibroNombre 'Nombre del Libro',"+
                    "L.FechaPublicacion 'Fecha en que se Publico',"+
                    "C.NombreCategoria'Categoria',"+
                    "E.EditorialNombre 'Editorial',"+
                    "H.HabitacionNombre 'Habitacion',P.PasilloNombre 'Pasillo',Est.EstanteNombre 'Estante'"+
                    " FROM "+
                    "Libro L, CategoriaLibro C,Editorial E, Habitacion H, Pasillo P, Estante Est"+
                    " Where "+
                    "L.CategoriaID=C.CategoriaID and L.EditorialID=E.EditorialID and L.HabitacionID=H.HabitacionID"+
                    " and L.PasilloID=P.PasilloID and L.EstanteID=Est.EstanteID;");
                dgvVerLibros.DataSource = dtDatos;
                dgvVerLibros.Update();
                dgvVerLibros.ReadOnly = true;
                dgvVerLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }//fin frmVerLibros_Load

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //primero limpiamos el data grid
                dgvVerLibros.DataSource = null;
                dgvVerLibros.Columns.Clear();
                dgvVerLibros.Rows.Clear();

                
                string libroIdBuscar = txtLibroID.Text;
                string libroNombreBuscar = txtLibroNombre.Text;

                //columnas manualmente
                dgvVerLibros.ColumnCount = 8;

                dgvVerLibros.Columns[0].Name = "Identificacion del Libro";
                dgvVerLibros.Columns[1].Name = "Nombre del Libro";
                dgvVerLibros.Columns[2].Name = "Fecha en que se Publico";
                dgvVerLibros.Columns[3].Name = "Categoria";
                dgvVerLibros.Columns[4].Name = "Editorial";
                dgvVerLibros.Columns[5].Name = "Habitacion";
                dgvVerLibros.Columns[6].Name = "Pasillo";
                dgvVerLibros.Columns[7].Name = "Estante";

                foreach (DataRow fila in dtDatos.Rows)
                {
                    if (fila["Identificacion del Libro"].ToString().Equals(libroIdBuscar) || fila["Nombre del Libro"].ToString().Equals(libroNombreBuscar))
                    {
                        dgvVerLibros.Rows.Add(fila["Identificacion del Libro"], fila["Nombre del Libro"], fila["Fecha en que se Publico"],
                            fila["Categoria"], fila["Editorial"], fila["Habitacion"], fila["Pasillo"],fila["Estante"]);
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
                this.txtLibroNombre.Text = "";
                this.txtLibroID.Text = "";

                //primero limpiamos el data grid
                dgvVerLibros.DataSource = null;
                dgvVerLibros.Columns.Clear();
                dgvVerLibros.Rows.Clear();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
