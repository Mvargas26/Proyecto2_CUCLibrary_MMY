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

        Procesos objNegocios = new Procesos();

        DataTable dtDatos = new DataTable();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarLibro_Load(object sender, EventArgs e)
        {
            try
            {
               
                dtDatos = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM Libro");

                foreach(DataRow lineaLeida in dtDatos.Rows)
                {
                    this.cmbIdLibro.Items.Add(lineaLeida["LibroID"].ToString());
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                throw new Exception(ex.Message);
            }
        }
    }//fn class
}//fn space
