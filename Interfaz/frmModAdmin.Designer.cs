
namespace Interfaz
{
    partial class frmModAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnModuloAdmin = new System.Windows.Forms.MenuStrip();
            this.mnLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnagregarLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminarLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVerLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminarAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVerAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEditoriales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAgregarEditorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarEditorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminarEditorial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVerEditoriales = new System.Windows.Forms.ToolStripMenuItem();
            this.mReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAgregarReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminarReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVerReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUsuariosBiblioteca = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAgregarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVerUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSalasEstudio = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSolicitudCopias = new System.Windows.Forms.ToolStripMenuItem();
            this.mAagregarSolicitud = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModificarSolicitud = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEliminarSolicitud = new System.Windows.Forms.ToolStripMenuItem();
            this.mnVerSolicitudes = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnModuloAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnModuloAdmin
            // 
            this.mnModuloAdmin.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnModuloAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnModuloAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLibros,
            this.mnAutores,
            this.mnEditoriales,
            this.mReservas,
            this.mnUsuariosBiblioteca,
            this.mnSalasEstudio,
            this.mnSolicitudCopias,
            this.sALIRToolStripMenuItem});
            this.mnModuloAdmin.Location = new System.Drawing.Point(0, 0);
            this.mnModuloAdmin.Name = "mnModuloAdmin";
            this.mnModuloAdmin.Size = new System.Drawing.Size(1225, 36);
            this.mnModuloAdmin.TabIndex = 1;
            this.mnModuloAdmin.Text = "menuStrip1";
            // 
            // mnLibros
            // 
            this.mnLibros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnagregarLibro,
            this.mnModificarLibro,
            this.mnEliminarLibro,
            this.mnVerLibros});
            this.mnLibros.Name = "mnLibros";
            this.mnLibros.Size = new System.Drawing.Size(85, 32);
            this.mnLibros.Text = "Libros";
            // 
            // mnagregarLibro
            // 
            this.mnagregarLibro.Name = "mnagregarLibro";
            this.mnagregarLibro.Size = new System.Drawing.Size(257, 32);
            this.mnagregarLibro.Text = "Agregar Libro";
            this.mnagregarLibro.Click += new System.EventHandler(this.mnagregarLibro_Click);
            // 
            // mnModificarLibro
            // 
            this.mnModificarLibro.Name = "mnModificarLibro";
            this.mnModificarLibro.Size = new System.Drawing.Size(257, 32);
            this.mnModificarLibro.Text = "Modificar Libro";
            this.mnModificarLibro.Click += new System.EventHandler(this.mnModificarLibro_Click);
            // 
            // mnEliminarLibro
            // 
            this.mnEliminarLibro.Name = "mnEliminarLibro";
            this.mnEliminarLibro.Size = new System.Drawing.Size(257, 32);
            this.mnEliminarLibro.Text = "Eliminar Libro";
            this.mnEliminarLibro.Click += new System.EventHandler(this.mnEliminarLibro_Click);
            // 
            // mnVerLibros
            // 
            this.mnVerLibros.Name = "mnVerLibros";
            this.mnVerLibros.Size = new System.Drawing.Size(257, 32);
            this.mnVerLibros.Text = "Ver Libros";
            this.mnVerLibros.Click += new System.EventHandler(this.mnVerLibros_Click);
            // 
            // mnAutores
            // 
            this.mnAutores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAutorToolStripMenuItem,
            this.mnModificarAutor,
            this.mnEliminarAutor,
            this.mnVerAutores});
            this.mnAutores.Name = "mnAutores";
            this.mnAutores.Size = new System.Drawing.Size(104, 32);
            this.mnAutores.Text = "Autores";
            // 
            // agregarAutorToolStripMenuItem
            // 
            this.agregarAutorToolStripMenuItem.Name = "agregarAutorToolStripMenuItem";
            this.agregarAutorToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.agregarAutorToolStripMenuItem.Text = "Agregar Autor";
            this.agregarAutorToolStripMenuItem.Click += new System.EventHandler(this.agregarAutorToolStripMenuItem_Click);
            // 
            // mnModificarAutor
            // 
            this.mnModificarAutor.Name = "mnModificarAutor";
            this.mnModificarAutor.Size = new System.Drawing.Size(263, 32);
            this.mnModificarAutor.Text = "Modificar Autor";
            this.mnModificarAutor.Click += new System.EventHandler(this.mnModificarAutor_Click);
            // 
            // mnEliminarAutor
            // 
            this.mnEliminarAutor.Name = "mnEliminarAutor";
            this.mnEliminarAutor.Size = new System.Drawing.Size(263, 32);
            this.mnEliminarAutor.Text = "Eliminar Autor";
            this.mnEliminarAutor.Click += new System.EventHandler(this.mnEliminarAutor_Click);
            // 
            // mnVerAutores
            // 
            this.mnVerAutores.Name = "mnVerAutores";
            this.mnVerAutores.Size = new System.Drawing.Size(263, 32);
            this.mnVerAutores.Text = "Ver Autores";
            this.mnVerAutores.Click += new System.EventHandler(this.mnVerAutores_Click);
            // 
            // mnEditoriales
            // 
            this.mnEditoriales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAgregarEditorial,
            this.mnModificarEditorial,
            this.mnEliminarEditorial,
            this.mnVerEditoriales});
            this.mnEditoriales.Name = "mnEditoriales";
            this.mnEditoriales.Size = new System.Drawing.Size(138, 32);
            this.mnEditoriales.Text = "Editoriales";
            // 
            // mnAgregarEditorial
            // 
            this.mnAgregarEditorial.Name = "mnAgregarEditorial";
            this.mnAgregarEditorial.Size = new System.Drawing.Size(297, 32);
            this.mnAgregarEditorial.Text = "Agregar Editorial";
            this.mnAgregarEditorial.Click += new System.EventHandler(this.mnAgregarEditorial_Click);
            // 
            // mnModificarEditorial
            // 
            this.mnModificarEditorial.Name = "mnModificarEditorial";
            this.mnModificarEditorial.Size = new System.Drawing.Size(297, 32);
            this.mnModificarEditorial.Text = "modificar Editorial";
            this.mnModificarEditorial.Click += new System.EventHandler(this.mnModificarEditorial_Click);
            // 
            // mnEliminarEditorial
            // 
            this.mnEliminarEditorial.Name = "mnEliminarEditorial";
            this.mnEliminarEditorial.Size = new System.Drawing.Size(297, 32);
            this.mnEliminarEditorial.Text = "Eliminar Editorial";
            this.mnEliminarEditorial.Click += new System.EventHandler(this.mnEliminarEditorial_Click);
            // 
            // mnVerEditoriales
            // 
            this.mnVerEditoriales.Name = "mnVerEditoriales";
            this.mnVerEditoriales.Size = new System.Drawing.Size(297, 32);
            this.mnVerEditoriales.Text = "Ver Editoriales";
            this.mnVerEditoriales.Click += new System.EventHandler(this.mnVerEditoriales_Click);
            // 
            // mReservas
            // 
            this.mReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAgregarReserva,
            this.mnModificarReserva,
            this.mnEliminarReserva,
            this.mnVerReservas});
            this.mReservas.Name = "mReservas";
            this.mReservas.Size = new System.Drawing.Size(115, 32);
            this.mReservas.Text = "Reservas";
            // 
            // mnAgregarReserva
            // 
            this.mnAgregarReserva.Name = "mnAgregarReserva";
            this.mnAgregarReserva.Size = new System.Drawing.Size(287, 32);
            this.mnAgregarReserva.Text = "Agregar Reserva";
            this.mnAgregarReserva.Click += new System.EventHandler(this.mnAgregarReserva_Click);
            // 
            // mnModificarReserva
            // 
            this.mnModificarReserva.Name = "mnModificarReserva";
            this.mnModificarReserva.Size = new System.Drawing.Size(287, 32);
            this.mnModificarReserva.Text = "Modificar Reserva";
            this.mnModificarReserva.Click += new System.EventHandler(this.mnModificarReserva_Click);
            // 
            // mnEliminarReserva
            // 
            this.mnEliminarReserva.Name = "mnEliminarReserva";
            this.mnEliminarReserva.Size = new System.Drawing.Size(287, 32);
            this.mnEliminarReserva.Text = "Eliminar Reserva";
            this.mnEliminarReserva.Click += new System.EventHandler(this.mnEliminarReserva_Click);
            // 
            // mnVerReservas
            // 
            this.mnVerReservas.Name = "mnVerReservas";
            this.mnVerReservas.Size = new System.Drawing.Size(287, 32);
            this.mnVerReservas.Text = "Ver Reservas";
            this.mnVerReservas.Click += new System.EventHandler(this.mnVerReservas_Click);
            // 
            // mnUsuariosBiblioteca
            // 
            this.mnUsuariosBiblioteca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAgregarUsuario,
            this.mnModificarUsuario,
            this.mnEliminarUsuario,
            this.mnVerUsuarios});
            this.mnUsuariosBiblioteca.Name = "mnUsuariosBiblioteca";
            this.mnUsuariosBiblioteca.Size = new System.Drawing.Size(229, 32);
            this.mnUsuariosBiblioteca.Text = "Usuarios Biblioteca";
            // 
            // mnAgregarUsuario
            // 
            this.mnAgregarUsuario.Name = "mnAgregarUsuario";
            this.mnAgregarUsuario.Size = new System.Drawing.Size(285, 32);
            this.mnAgregarUsuario.Text = "Agregar Usuario";
            // 
            // mnModificarUsuario
            // 
            this.mnModificarUsuario.Name = "mnModificarUsuario";
            this.mnModificarUsuario.Size = new System.Drawing.Size(285, 32);
            this.mnModificarUsuario.Text = "Modificar Usuario";
            // 
            // mnEliminarUsuario
            // 
            this.mnEliminarUsuario.Name = "mnEliminarUsuario";
            this.mnEliminarUsuario.Size = new System.Drawing.Size(285, 32);
            this.mnEliminarUsuario.Text = "Eliminar Usuario";
            // 
            // mnVerUsuarios
            // 
            this.mnVerUsuarios.Name = "mnVerUsuarios";
            this.mnVerUsuarios.Size = new System.Drawing.Size(285, 32);
            this.mnVerUsuarios.Text = "Ver Usuarios";
            // 
            // mnSalasEstudio
            // 
            this.mnSalasEstudio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSalaToolStripMenuItem,
            this.modificarSalaToolStripMenuItem,
            this.eliminarSalaToolStripMenuItem,
            this.verSalasToolStripMenuItem});
            this.mnSalasEstudio.Name = "mnSalasEstudio";
            this.mnSalasEstudio.Size = new System.Drawing.Size(162, 32);
            this.mnSalasEstudio.Text = "Salas Estudio";
            // 
            // agregarSalaToolStripMenuItem
            // 
            this.agregarSalaToolStripMenuItem.Name = "agregarSalaToolStripMenuItem";
            this.agregarSalaToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.agregarSalaToolStripMenuItem.Text = "Agregar Sala ";
            // 
            // modificarSalaToolStripMenuItem
            // 
            this.modificarSalaToolStripMenuItem.Name = "modificarSalaToolStripMenuItem";
            this.modificarSalaToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.modificarSalaToolStripMenuItem.Text = "Modificar Sala";
            // 
            // eliminarSalaToolStripMenuItem
            // 
            this.eliminarSalaToolStripMenuItem.Name = "eliminarSalaToolStripMenuItem";
            this.eliminarSalaToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.eliminarSalaToolStripMenuItem.Text = "Eliminar Sala";
            // 
            // verSalasToolStripMenuItem
            // 
            this.verSalasToolStripMenuItem.Name = "verSalasToolStripMenuItem";
            this.verSalasToolStripMenuItem.Size = new System.Drawing.Size(252, 32);
            this.verSalasToolStripMenuItem.Text = "Ver Salas";
            // 
            // mnSolicitudCopias
            // 
            this.mnSolicitudCopias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAagregarSolicitud,
            this.mnModificarSolicitud,
            this.mnEliminarSolicitud,
            this.mnVerSolicitudes});
            this.mnSolicitudCopias.Name = "mnSolicitudCopias";
            this.mnSolicitudCopias.Size = new System.Drawing.Size(199, 32);
            this.mnSolicitudCopias.Text = "Solicitud Copias";
            // 
            // mAagregarSolicitud
            // 
            this.mAagregarSolicitud.Name = "mAagregarSolicitud";
            this.mAagregarSolicitud.Size = new System.Drawing.Size(299, 32);
            this.mAagregarSolicitud.Text = "Agregar Solicitud";
            // 
            // mnModificarSolicitud
            // 
            this.mnModificarSolicitud.Name = "mnModificarSolicitud";
            this.mnModificarSolicitud.Size = new System.Drawing.Size(299, 32);
            this.mnModificarSolicitud.Text = "Modificar Solicitud";
            // 
            // mnEliminarSolicitud
            // 
            this.mnEliminarSolicitud.Name = "mnEliminarSolicitud";
            this.mnEliminarSolicitud.Size = new System.Drawing.Size(299, 32);
            this.mnEliminarSolicitud.Text = "Eliminar Solicitud";
            // 
            // mnVerSolicitudes
            // 
            this.mnVerSolicitudes.Name = "mnVerSolicitudes";
            this.mnVerSolicitudes.Size = new System.Drawing.Size(299, 32);
            this.mnVerSolicitudes.Text = "Ver solicitudes";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(80, 32);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // frmModAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 790);
            this.Controls.Add(this.mnModuloAdmin);
            this.IsMdiContainer = true;
            this.Name = "frmModAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo Administrador";
            this.mnModuloAdmin.ResumeLayout(false);
            this.mnModuloAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnModuloAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnLibros;
        private System.Windows.Forms.ToolStripMenuItem mnagregarLibro;
        private System.Windows.Forms.ToolStripMenuItem mnModificarLibro;
        private System.Windows.Forms.ToolStripMenuItem mnEliminarLibro;
        private System.Windows.Forms.ToolStripMenuItem mnVerLibros;
        private System.Windows.Forms.ToolStripMenuItem mnAutores;
        private System.Windows.Forms.ToolStripMenuItem agregarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnModificarAutor;
        private System.Windows.Forms.ToolStripMenuItem mnEliminarAutor;
        private System.Windows.Forms.ToolStripMenuItem mnVerAutores;
        private System.Windows.Forms.ToolStripMenuItem mnEditoriales;
        private System.Windows.Forms.ToolStripMenuItem mnAgregarEditorial;
        private System.Windows.Forms.ToolStripMenuItem mnModificarEditorial;
        private System.Windows.Forms.ToolStripMenuItem mnEliminarEditorial;
        private System.Windows.Forms.ToolStripMenuItem mnVerEditoriales;
        private System.Windows.Forms.ToolStripMenuItem mReservas;
        private System.Windows.Forms.ToolStripMenuItem mnAgregarReserva;
        private System.Windows.Forms.ToolStripMenuItem mnModificarReserva;
        private System.Windows.Forms.ToolStripMenuItem mnEliminarReserva;
        private System.Windows.Forms.ToolStripMenuItem mnVerReservas;
        private System.Windows.Forms.ToolStripMenuItem mnUsuariosBiblioteca;
        private System.Windows.Forms.ToolStripMenuItem mnAgregarUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnModificarUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnEliminarUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnVerUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnSalasEstudio;
        private System.Windows.Forms.ToolStripMenuItem agregarSalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarSalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarSalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verSalasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSolicitudCopias;
        private System.Windows.Forms.ToolStripMenuItem mAagregarSolicitud;
        private System.Windows.Forms.ToolStripMenuItem mnModificarSolicitud;
        private System.Windows.Forms.ToolStripMenuItem mnEliminarSolicitud;
        private System.Windows.Forms.ToolStripMenuItem mnVerSolicitudes;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}