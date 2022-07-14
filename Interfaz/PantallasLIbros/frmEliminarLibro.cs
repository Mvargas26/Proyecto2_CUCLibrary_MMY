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
                    //recorremos la tabla de libros, donde id coincida tomamos el nombre
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


                        //Vamos a verificar antes de borrar el libro si existe en la tabla Libro_Autor para borrarlo
                        DataTable tb_LIbro_Autor = new DataTable();
                        tb_LIbro_Autor = obj_Procesos.QueryGeneralNegocios_DT("SELECT * FROM Libro_Autor");

                        foreach (DataRow lineaLibroAutor in tb_LIbro_Autor.Rows)
                        {
                            if (lineaLibroAutor["LibroID"].ToString() == obj_clLibro.libroID.ToString())
                            {
                                //Si el ID del libro coincidio en la tabla Libro_Autor, guardamos el ID de ese registro en esta variable
                                short save_LA_ID = Convert.ToInt16(lineaLibroAutor["LA_ID"].ToString());

                                //objeto de tipo Libro_Autor necesario para mandarlo como parametro
                                clLIbro_Autor newLibroAutor = new clLIbro_Autor();
                                newLibroAutor.Libro_Autor = save_LA_ID;
                                newLibroAutor.LibroID = obj_clLibro.libroID;
                                newLibroAutor.AutorID = 0; // aqui enviamos un 0, ya que este atributo para borrar (SP opc 3) no es necesario

                                //Objeto que permite lllamar el SP_Libro_Autor
                                Libro_Autor_Procesos ob_Libro_Autor_Procesos = new Libro_Autor_Procesos();
                                ob_Libro_Autor_Procesos.GrabarLibro_Autor(3, newLibroAutor);

                            }
              
                        }
                    }
                 }

                //ya borrrado en TB_LibroAutor podemos borrar en TB_Libro
                obj_libro_Procesos.GrabarLibro(3, obj_clLibro);
                MessageBox.Show("Se elimino el Libro Correctamente");
                this.Close();

            }//fin try
             catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }

        }
    }//fn class
}//fn space
