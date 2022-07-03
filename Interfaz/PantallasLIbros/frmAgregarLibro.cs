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

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAgregarLibro_Load(object sender, EventArgs e)
        {
            Procesos objNegocios = new Procesos();

            DataTable dtdatos = new DataTable();
            DataSet dsDatos = new  DataSet();

            //aqui llamamos el sp que trae las tablas:
            //0=CategoriaLibro,1=Autor,2=Libro_Autor,3=Editorial,4=Habitacion,5=Pasillo,6=Estante
            dsDatos = objNegocios.QueryGeneralNegocios_DS("SP_Dataset_frmAgregarLibro");

            try
            {
                foreach (DataRow fila in dsDatos.Tables[0].Rows)
                {
                    this.cmbCategoria.Items.Add(fila["NombreCategoria"].ToString());
                }

                foreach (DataRow fila in dsDatos.Tables[3].Rows)
                {
                    this.cmbEditorial.Items.Add(fila["EditorialNombre"].ToString());
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin metodo load
    }//fn class
}//fin space
