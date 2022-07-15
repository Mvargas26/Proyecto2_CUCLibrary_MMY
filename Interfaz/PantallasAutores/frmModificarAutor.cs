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
    public partial class frmModificarAutor : Form
    {
        public frmModificarAutor()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        clAutor newAutor = new clAutor();
        DataTable dtAutores = new DataTable();

        //----------------------------------------
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarAutor_Load(object sender, EventArgs e)
        {
            try
            {
                dtAutores = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM Autor");

                foreach(DataRow fila in dtAutores.Rows)
                {
                    this.cmbIDAutor.Items.Add(fila["AutorID"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbIDAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtAutores.Rows)
                {
                    if (fila["AutorID"].ToString().Equals(cmbIDAutor.SelectedItem.ToString()))
                    {
                        this.txtNombreAutor.Text = fila["AutorNombre"].ToString();
                        this.txtLugarOrigen.Text = fila["AutorLugarOrigen"].ToString();
                    }
                   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones

                //validaciones
                if (txtNombreAutor.Text == "")
                {
                    MessageBox.Show("El Nombre del Autor es requerido");
                    return;
                }

                if (txtLugarOrigen.Text == "")
                {
                    MessageBox.Show("El lugar de Origen es requerido");
                    return;
                }
                //fin validaciones

                //cargamos el obj con la info nueva
                newAutor.AutorID = Convert.ToInt16(cmbIDAutor.SelectedItem);
                newAutor.AutorNombre = txtNombreAutor.Text;
                newAutor.AutorLugarO = txtLugarOrigen.Text;

                // Enviamos el Query
                objNegocios.QueryGeneralNegocios_DT("UPDATE AUTOR "+
                    " SET "+
                   "AutorNombre=' "+
                   newAutor.AutorNombre+"',"+
                   "AutorLugarOrigen='"+newAutor.AutorLugarO+"' "+
                   " WHERE "+
                   " AutorID='"+newAutor.AutorID+"'");

                MessageBox.Show("Autor Modificado Correctamente");
                this.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin btnModificar_Click
    }//fin class
}//fin space
