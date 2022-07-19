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

namespace Interfaz.PantallasReservas
{
    public partial class frmEliminarReserva : Form
    {
        public frmEliminarReserva()
        {
            InitializeComponent();
        }
        //Variables Globales
        DataTable dtReservas = new DataTable();
        DataTable dtUsuarios = new DataTable();

        short idUsuario;
        short idReserva;

        Procesos objnegocios = new Procesos();


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarReserva_Load(object sender, EventArgs e)
        {
            try
            {
                dtReservas = objnegocios.QueryGeneralNegocios_DT("SELECT * FROM Reserva");
                dtUsuarios = objnegocios.QueryGeneralNegocios_DT("SELECT * FROM USuarioBiblioteca");

                foreach (DataRow fila in dtReservas.Rows)
                {
                    cmbIDReserva.Items.Add(fila["ReservaID"].ToString());
                    idUsuario = Convert.ToInt16(fila["IDusuario"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbIDReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtReservas.Rows)
                {
                    if (fila["ReservaID"].ToString().Equals(cmbIDReserva.Text)) { 
                        idUsuario = Convert.ToInt16(fila["IDusuario"].ToString());
                        break;
                    }
                }

                foreach (DataRow fila in dtUsuarios.Rows)
                {
                    if (fila["UsuarioBibliotecaID"].ToString().Equals(idUsuario.ToString()))
                    {
                        txtNombreUser.Text = fila["NombreUB"].ToString();
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
                //validaciones
                if (cmbIDReserva.Text=="" || txtNombreUser.Text=="")
                {
                    MessageBox.Show("Primero Selecione La reserva a Modificar");
                    return;
                }
                //fin validaciones

                idReserva = Convert.ToInt16(cmbIDReserva.Text);


                    objnegocios.QueryGeneralNegocios_DT("DELETE FROM Reserva "+
                        "WHERE ReservaID ="+idReserva);
                    MessageBox.Show("La reserva se elimino Correctamente");
                    this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin btn Eliminar
    }//fin class
}//fin space
