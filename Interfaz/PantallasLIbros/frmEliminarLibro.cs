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

namespace Interfaz
{
    public partial class frmEliminarLibro : Form
    {
        public frmEliminarLibro()
        {
            InitializeComponent();
        }
        // VARIABLES GLOBALES -------------------------------

        Procesos obj_Procesos = new Procesos();
        clLibro obj_clLibro = new clLibro();
        Libro_Procesos obj_libro_Procesos = new Libro_Procesos();

        DataTable dtDatos = new DataTable();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarLibro_Load(object sender, EventArgs e)
        {
            try
            {
               
                dtDatos = obj_Procesos.QueryGeneralNegocios_DT("SELECT * FROM Libro");

                foreach(DataRow lineaLeida in dtDatos.Rows)
                {
                    this.cmbIdLibro.Items.Add(lineaLeida["LibroID"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin frmEliminarLibro_Load

        private void cmbIdLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow lineaLeida in dtDatos.Rows)
                {
                    if (cmbIdLibro.Text == lineaLeida["LibroID"].ToString())
                    {
                        this.txtNombreLibro.Text = lineaLeida["LibroNombre"].ToString();
                        break;
                    }
                
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIdLibro.Text == "")
                {
                    MessageBox.Show("Primero seleccione el Libro a Eliminar");
                    return;
                }
                //a este objeto le cargaremos la info del libro a borrar
                

                foreach (DataRow lineaLeida in dtDatos.Rows)
                {
                    //recorremos el dt, si la info de id coincide con la selecciondel usuario
                    // cargamos esa informacion en un objeto de tipo libro
                    if(lineaLeida["LibroID"].ToString() == cmbIdLibro.Text)
                    {
                        obj_clLibro.libroID = Convert.ToInt16(lineaLeida["LibroID"].ToString());
                        obj_clLibro.libroNombre = lineaLeida["LibroNombre"].ToString();
                        obj_clLibro.CategoriaID = Convert.ToInt16(lineaLeida["CategoriaID"].ToString());
                        obj_clLibro.EditorialID = Convert.ToInt16(lineaLeida["EditorialID"].ToString());
                        obj_clLibro.cantDispo = Convert.ToInt32(lineaLeida["CantidadDisponible"].ToString());
                        obj_clLibro.fechaPubli = Convert.ToDateTime(lineaLeida["FechaPublicacion"].ToString());
                        obj_clLibro.habitacionID = Convert.ToInt16(lineaLeida["HabitacionID"].ToString());
                        obj_clLibro.pasilloID = Convert.ToInt16(lineaLeida["PasilloID"].ToString());
                        obj_clLibro.estanteID = Convert.ToInt16(lineaLeida["EstanteID"].ToString());

                        break;
                    }
                }

                // ya con el obj tipo libro, llamamos el sp con el parameto 3(borrar) y este obj 
                obj_libro_Procesos.GrabarLibro(3, obj_clLibro);
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }

        }
    }//fn class
}//fn space
