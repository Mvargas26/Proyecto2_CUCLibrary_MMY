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
    public partial class frmAgregarAutor : Form
    {
        public frmAgregarAutor()
        {
            InitializeComponent();
        }

        //Globales
        Procesos objNegocios = new Procesos();
        clAutor newAutor = new clAutor();

        //----------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones
                if (txtNombreAutor.Text=="")
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

                newAutor.AutorID = 0;// 0 xq este lo pone la BD
                newAutor.AutorNombre = txtNombreAutor.Text;
                newAutor.AutorLugarO = txtLugarOrigen.Text;

                objNegocios.QueryGeneralNegocios_DT("INSERT into Autor(AutorNombre,AutorLugarOrigen) "+
                    " Values "+
                    "('"+ newAutor.AutorNombre+"','" + newAutor.AutorLugarO+"');");

                MessageBox.Show("Autor Agregado Correctamente");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
