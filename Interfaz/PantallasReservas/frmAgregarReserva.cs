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
    public partial class frmAgregarReserva : Form
    {
        public frmAgregarReserva()
        {
            InitializeComponent();
        }

        // Variables Globales
        DataTable dtUsuarios = new DataTable();
        DataTable dtLibro= new DataTable();
        DataTable dtSala= new DataTable();
       

        short idUsuario;
        short idLibro;
        short idSala;
        DateTime fechaRetiro;
        DateTime fechaRegreso;
        short estado;

        Procesos objnegocios = new Procesos();


        //-----------------

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//fin boton cancelar

        private void frmAgregarReserva_Load(object sender, EventArgs e)
        {
            try
            {
                dtUsuarios = objnegocios.QueryGeneralNegocios_DT("SELECT * FROM USuarioBiblioteca");
                dtLibro = objnegocios.QueryGeneralNegocios_DT("SELECT * FROM Libro");
                dtSala = objnegocios.QueryGeneralNegocios_DT("SELECT * FROM SalaEstudio");
               

                foreach (DataRow fila in dtUsuarios.Rows)
                {
                    cmbUsuarioReserva.Items.Add(fila["NombreUB"].ToString());
                }

                foreach (DataRow fila in dtLibro.Rows)
                {
                    cmbLibroReserva.Items.Add(fila["LibroNombre"].ToString());
                }

                foreach (DataRow fila in dtSala.Rows)
                {
                    cmbSalas.Items.Add(fila["SalaID"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin load

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones
                if (cmbUsuarioReserva.Text == "")
                {
                    MessageBox.Show("Elegir el Usuario es Necesario");
                    return;
                }
                if (cmbLibroReserva.Text == "")
                {
                    MessageBox.Show("Elegir el Libro es Necesario");
                    return;
                }
                if (cmbSalas.Text == "")
                {
                    MessageBox.Show("Elegir la Sala es Necesario");
                    return;
                }
                if (cmbEstadoReserva.Text == "")
                {
                    MessageBox.Show("Indique el estado de esta Reserva");
                    return;
                }
                fechaRetiro = dtpFechaRetiro.Value;
                fechaRegreso = dtpFechaRegreso.Value;

                if (fechaRetiro.CompareTo(fechaRegreso) >= 0)
                {
                    MessageBox.Show("La fecha de Regreso debe ser mayor a la de Retiro");
                    return;
                }

                //fin validaciones

                // sE DEBIO CAMBIAR EL FORMATO PARA QUE SQL LO ACEPTARA
                string dateFormatted_fechaRetiro = fechaRetiro.ToString("yyyy-MM-dd");
                string dateFormatted_fechaRegreso = fechaRegreso.ToString("yyyy-MM-dd");

                objnegocios.QueryGeneralNegocios_DT("INSERT INTO Reserva (IDusuario,IDLibro,SalaID,FechaRetiro,FechaRegreso,EstadoReserva)"+
                    " VALUES "+
                    "("+idUsuario+","+idLibro + "," +idSala + "," +
                    "'"+dateFormatted_fechaRetiro+ "'" + "," + "'"+ dateFormatted_fechaRegreso+ "'" + "," +estado+");");

                MessageBox.Show("Su reserva se registro Correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//fin boton agregar

        private void cmbUsuarioReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtUsuarios.Rows)
                {
                    if (fila["NombreUB"].ToString().Equals(cmbUsuarioReserva.Text))
                    {
                        //capturamos el id del usuario elegido
                        idUsuario = Convert.ToInt16(fila["UsuarioBibliotecaID"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbLibroReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtLibro.Rows)
                {
                    if (fila["LibroNombre"].ToString().Equals(cmbLibroReserva.Text))
                    {
                        //capturamos el id del libro elegido
                        idLibro = Convert.ToInt16(fila["LibroID"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataRow fila in dtSala.Rows)
                {
                    if (fila["SalaID"].ToString().Equals(cmbSalas.Text))
                    {
                        //capturamos el id de la sala
                        idSala = Convert.ToInt16(fila["SalaID"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbEstadoReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEstadoReserva.SelectedIndex==0)//si es 0 eligieron la opcion activa
                {
                    estado = 1;
                }
                else //si no eligieron inactiva
                {
                    estado = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }//fin class
}//fin space
