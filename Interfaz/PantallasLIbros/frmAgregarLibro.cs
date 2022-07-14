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
    public partial class frmAgregarLibro : Form
    {
        public frmAgregarLibro()
        {
            InitializeComponent();
        }
        //Globales
        Procesos objNegocios = new Procesos();
        DataSet dsDatos = new DataSet();


        //----------------------------------------
        private void btnAgregarAutores_Click(object sender, EventArgs e)
        {
            try { 
            frmDGVAutores pantalla = new frmDGVAutores();
            pantalla.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fn btnAgregarAutores

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarLibro_Load(object sender, EventArgs e)
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

        

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin metodo load

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
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            
            }

        }// fn cmbHabitacion_SelectedIndexChanged

        private void cmbPasillo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strPasilloSelec = cmbPasillo.Text;
                int idPasilloSelec = 0;

                cmbEstante.Items.Clear();

                foreach (DataRow fila in dsDatos.Tables[5].Rows)
                {
                    if (fila["PasilloNombre"].ToString().Equals(strPasilloSelec))
                    {
                        //guardamos el id de la habitacion que seleciono el usuario
                        idPasilloSelec = Int32.Parse(fila["PasilloID"].ToString());
                    }
                }

                foreach (DataRow fila2 in dsDatos.Tables[6].Rows)
                {
                    if (fila2["PasilloID"].ToString().Equals(idPasilloSelec.ToString()))
                    {
                        //al como pasillo agregamos solo los pasillos que coincidan con el ID selecionado en habitacion
                        this.cmbEstante.Items.Add(fila2["EstanteNombre"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }// fn cmbPasillo_SelectedIndexChanged

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

      
    }//fn class
}//fin space
