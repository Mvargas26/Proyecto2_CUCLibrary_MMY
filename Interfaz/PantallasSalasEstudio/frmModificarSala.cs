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

namespace Interfaz.PantallasSalasEstudio
{
    public partial class frmModificarSala : Form
    {
        public frmModificarSala()
        {
            InitializeComponent();
        }


        //Globales
        Procesos objNegocios = new Procesos();
        DataTable dtSalas= new DataTable();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModificarSala_Load(object sender, EventArgs e)
        {
            try
            {
                dtSalas = objNegocios.QueryGeneralNegocios_DT("SELECT * FROM SalaEstudio");

                foreach (DataRow fila in dtSalas.Rows)
                {
                    this.cmbIDSala.Items.Add(fila["SalaID"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }//fin load

        
        private void cmbIDSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtSalas.Rows)
                {
                    if (fila["SalaID"].ToString().Equals(cmbIDSala.SelectedItem.ToString()))
                    {
                        this.txtTipoSala.Text = fila["TipoSala"].ToString();
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
                if (txtTipoSala.Text == "")
                {
                    MessageBox.Show("El Tipo de sala es requerido");
                    return;
                }

                if (cmEstado.Text == "")
                {
                    MessageBox.Show("Indique si esta Libre u Ocupada");
                    return;
                }
                //fin validaciones

                //cargamos el obj con la info nueva
               short IdSala = Convert.ToInt16(cmbIDSala.SelectedItem);
                string SalaTipo = txtTipoSala.Text;
                short estado;
                if (cmEstado.SelectedIndex==0)//si esta en la posi 0 eligieron "Libre"
                {
                    estado = 1;
                }
                else // si no elegieron "Ocupada"
                {
                    estado = 0;
                }

                // Enviamos el Query
                objNegocios.QueryGeneralNegocios_DT("UPDATE SalaEstudio " +
                    " SET " +
                   "TipoSala=' " +
                   SalaTipo + "'," +
                   "EstadoSala='" + estado + "' " +
                   " WHERE " +
                   " SalaID='" + IdSala+ "'");

                MessageBox.Show("Sala Modificada Correctamente");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin btn modificar
    }//fin class
}//fin space
