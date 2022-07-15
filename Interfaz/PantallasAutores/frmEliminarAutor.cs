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

namespace Interfaz.PantallasAutores
{
    public partial class frmEliminarAutor : Form
    {
        public frmEliminarAutor()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        clAutor newAutor = new clAutor();
        DataTable dtAutores = new DataTable();
        DataTable dtLibro_Autor = new DataTable();

        //----------------------------------------


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarAutor_Load(object sender, EventArgs e)
        {
            try
            {
                dtAutores = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM Autor");

                foreach (DataRow fila in dtAutores.Rows)
                {
                    this.cmbIdAutor.Items.Add(fila["AutorID"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbIdAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtAutores.Rows)
                {
                    if (fila["AutorID"].ToString().Equals(cmbIdAutor.SelectedItem.ToString()))
                    {
                        this.txtNombreAutor.Text = fila["AutorNombre"].ToString();
                       
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
                
                //validaciones
                if (txtNombreAutor.Text == "" || cmbIdAutor.Text=="")
                {
                    MessageBox.Show("Selecione algun Autor");
                    return;
                }

                string idAutorBorrar = cmbIdAutor.Text;

                //Primero Vemos si en Libro_Autor este este Id del Autor
                dtLibro_Autor = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM Libro_Autor");

                foreach (DataRow fila in dtLibro_Autor.Rows)
                {
                    if (fila["AutorID"].ToString().Equals(cmbIdAutor.SelectedItem.ToString()))
                    {
                        objNegocios.QueryGeneralNegocios_DT("DELETE FROM Libro_Autor " +
                     " WHERE " +
                     "AutorID= '" + idAutorBorrar + "';");

                    }

                }

                // Despues Enviamos el Query a Autor 
                objNegocios.QueryGeneralNegocios_DT("DELETE FROM Autor "+
                    " WHERE "+
                    "AutorID= '"+idAutorBorrar+"';");

                MessageBox.Show("se elimino el Autor Correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
