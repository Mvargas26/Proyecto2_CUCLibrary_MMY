using Entidades;
using Interfaz.PantallasLIbros;
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
    public partial class frmModificarLibro : Form
    {
        public frmModificarLibro()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        DataSet dsDatos = new DataSet();
        Libro_Autor_Procesos objLibroAutor = new Libro_Autor_Procesos();
        short idHabitacionGlobal = 0;
        short idPasilloGlobal = 0;
        short idCategoriaGlobal;
        short idEstanteGlobal;
        short idEditorialGlobal;
        clLibro newLibro = new clLibro();

        //----------------------------------------

        private void frmModificarLibro_Load(object sender, EventArgs e)
        {
            try
            {
                //aqui llamamos el sp que trae las tablas:
                //0=CategoriaLibro,1=Autor,2=Libro_Autor,3=Editorial,4=Habitacion,5=Pasillo,6=Estante
                dsDatos = objNegocios.QueryGeneralNegocios_DS("SP_Dataset_frmAgregarLibro");

                foreach (DataRow fila in dsDatos.Tables[0].Rows)
                {
                    this.cmbCategoria.Items.Add(fila["NombreCategoria"].ToString());
                }

                foreach (DataRow fila in dsDatos.Tables[3].Rows)
                {
                    this.cmbEditorial.Items.Add(fila["EditorialNombre"].ToString());
                }

                foreach (DataRow fila in dsDatos.Tables[4].Rows)
                {
                    this.cmbHabitacion.Items.Add(fila["HabitacionNombre"].ToString());
                }

                //Recorremos la tabla Libro
                foreach (DataRow fila in dsDatos.Tables[7].Rows)
                {
                    this.cmbIdLibro.Items.Add(fila["LibroID"].ToString());
                  
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarAutores_Click(object sender, EventArgs e)
        {
            try
            {
                frmDGVAutores pantalla = new frmDGVAutores();
                pantalla.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void cmbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strhabitacionSelec = cmbHabitacion.Text;
                int idhabitacionSelec = 0;

                cmbPasillo.Items.Clear();

                foreach (DataRow fila in dsDatos.Tables[4].Rows)
                {
                    if (fila["HabitacionNombre"].ToString().Equals(strhabitacionSelec))
                    {
                        //guardamos el id de la habitacion que seleciono el usuario
                        idhabitacionSelec = Int32.Parse(fila["HabitacionID"].ToString());
                    }
                }

                foreach (DataRow fila2 in dsDatos.Tables[5].Rows)
                {
                    if (fila2["HabitacionID"].ToString().Equals(idhabitacionSelec.ToString()))
                    {
                        //al como pasillo agregamos solo los pasillos que coincidan con el ID selecionado en habitacion
                        this.cmbPasillo.Items.Add(fila2["PasilloNombre"].ToString());
                    }
                }
                //salvamos el id de la Habitacion
                idHabitacionGlobal = Convert.ToInt16(idhabitacionSelec);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }//fin cmbHabitacion_SelectedIndexChanged

        private void cmbPasillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //0=CategoriaLibro,1=Autor,2=Libro_Autor,3=Editorial,4=Habitacion,5=Pasillo,6=Estante

                string strHabitacionSelec = cmbHabitacion.Text;
                int idHabitacionSelect = 0;
                string strPasilloSelec = cmbPasillo.Text;
                int idPasilloSelec = 0;


                cmbEstante.Items.Clear();

                //guardamos id Habitacion en una Variable
                foreach (DataRow fila in dsDatos.Tables[4].Rows)
                {
                    if (fila["HabitacionNombre"].ToString().Equals(strHabitacionSelec))
                    {
                        //guardamos el id de la habitacion que seleciono el usuario
                        idHabitacionSelect = Int32.Parse(fila["HabitacionID"].ToString());
                    }
                }

                //guardamos id Pasillo en otra Variable
                foreach (DataRow fila in dsDatos.Tables[5].Rows)
                {
                    if (fila["PasilloNombre"].ToString().Equals(strPasilloSelec))
                    {
                        //guardamos el id de la habitacion que seleciono el usuario
                        idPasilloSelec = Int32.Parse(fila["PasilloID"].ToString());
                    }
                }
                //salvamos el idPasillo
                idPasilloGlobal = Convert.ToInt16(idPasilloSelec);

                foreach (DataRow fila in dsDatos.Tables[6].Rows)
                {
                    if (fila["HabitacionID"].ToString().Equals(idHabitacionSelect.ToString()) && fila["PasilloID"].ToString().Equals(idPasilloSelec.ToString()))
                    {
                        this.cmbEstante.Items.Add(fila["EstanteNombre"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dsDatos.Tables[0].Rows)
                {
                    if (fila["NombreCategoria"].ToString().Equals(cmbCategoria.Text))
                    {
                        idCategoriaGlobal = Convert.ToInt16(fila["CategoriaID"]);//salva el id de la categoria en una variable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dsDatos.Tables[3].Rows)
                {
                    if (fila["EditorialNombre"].ToString().Equals(cmbEditorial.Text))
                    {
                        idEditorialGlobal = Convert.ToInt16(fila["EditorialID"]);//slava el id de la categoria en una variable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin cmbEditorial_SelectedIndexChanged

        private void cmbEstante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dsDatos.Tables[6].Rows)
                {
                    if (fila["EstanteNombre"].ToString().Equals(cmbEstante.Text))
                    {
                        idEstanteGlobal = Convert.ToInt16(fila["EstanteID"]);//slava el id de la categoria en una variable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//cmbEstante_SelectedIndexChanged

        private void cmbIdLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dsDatos.Tables[7].Rows)
                {
                    if (fila["LibroID"].ToString().Equals(cmbIdLibro.Text))
                    {
                        newLibro.libroID = Convert.ToInt16(fila["LibroID"]);
                        newLibro.libroNombre = fila["LibroNombre"].ToString();
                        newLibro.CategoriaID= Convert.ToInt16(fila["CategoriaID"]);
                        newLibro.EditorialID = Convert.ToInt16(fila["EditorialID"]);
                        newLibro.cantDispo = Convert.ToInt32(fila["CantidadDisponible"]);
                        newLibro.fechaPubli= Convert.ToDateTime(fila["FechaPublicacion"]);
                        newLibro.habitacionID= Convert.ToInt16(fila["HabitacionID"]);
                        newLibro.pasilloID= Convert.ToInt16(fila["PasilloID"]);
                        newLibro.estanteID= Convert.ToInt16(fila["EstanteID"]);
                    }

                }

                this.txtNombreLibro.Text = newLibro.libroNombre;
                //Cargamos la categoria con la info del selecionado
                foreach (DataRow fila in dsDatos.Tables[0].Rows)
                {
                    if (fila["CategoriaID"].ToString().Equals(newLibro.CategoriaID.ToString()))
                    {
                        this.cmbCategoria.Text=fila["NombreCategoria"].ToString();
                    }
                }
                //Cargamos la Editorial con la info del selecionado
                foreach (DataRow fila in dsDatos.Tables[3].Rows)
                {
                    if (fila["EditorialID"].ToString().Equals(newLibro.EditorialID.ToString()))
                    {
                        this.cmbEditorial.Text=fila["EditorialNombre"].ToString();
                    }
                }

                foreach (DataRow fila in dsDatos.Tables[4].Rows)
                {
                    if (fila["HabitacionID"].ToString().Equals(newLibro.habitacionID.ToString()))
                    {
                        this.cmbHabitacion.Text = fila["HabitacionNombre"].ToString();
                    }
                }

                this.txtCantDisponible.Text = newLibro.cantDispo.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
