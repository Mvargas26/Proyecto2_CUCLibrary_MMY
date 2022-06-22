
namespace Interfaz
{
    partial class frmModificarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarLibro));
            this.grpAgregarLibro = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.txtEstante = new System.Windows.Forms.TextBox();
            this.txtPasillo = new System.Windows.Forms.TextBox();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtCantDisponible = new System.Windows.Forms.TextBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.lblEstante = new System.Windows.Forms.Label();
            this.lblPasillo = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblUbicacionPasillo = new System.Windows.Forms.Label();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.lblCantidadDisponible = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbIdLibro = new System.Windows.Forms.ComboBox();
            this.lblIdLibro = new System.Windows.Forms.Label();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblMensajeAdmin = new System.Windows.Forms.Label();
            this.grpAgregarLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgregarLibro
            // 
            this.grpAgregarLibro.Controls.Add(this.lblMensajeAdmin);
            this.grpAgregarLibro.Controls.Add(this.dtpFechaPublicacion);
            this.grpAgregarLibro.Controls.Add(this.cmbIdLibro);
            this.grpAgregarLibro.Controls.Add(this.lblIdLibro);
            this.grpAgregarLibro.Controls.Add(this.btnCancelar);
            this.grpAgregarLibro.Controls.Add(this.btnModificar);
            this.grpAgregarLibro.Controls.Add(this.pboxImagen);
            this.grpAgregarLibro.Controls.Add(this.txtEstante);
            this.grpAgregarLibro.Controls.Add(this.txtPasillo);
            this.grpAgregarLibro.Controls.Add(this.txtHabitacion);
            this.grpAgregarLibro.Controls.Add(this.cmbEditorial);
            this.grpAgregarLibro.Controls.Add(this.cmbAutor);
            this.grpAgregarLibro.Controls.Add(this.txtCategoria);
            this.grpAgregarLibro.Controls.Add(this.txtCantDisponible);
            this.grpAgregarLibro.Controls.Add(this.txtNombreLibro);
            this.grpAgregarLibro.Controls.Add(this.lblEstante);
            this.grpAgregarLibro.Controls.Add(this.lblPasillo);
            this.grpAgregarLibro.Controls.Add(this.lblHabitacion);
            this.grpAgregarLibro.Controls.Add(this.lblUbicacionPasillo);
            this.grpAgregarLibro.Controls.Add(this.lblFechaPublicacion);
            this.grpAgregarLibro.Controls.Add(this.lblCantidadDisponible);
            this.grpAgregarLibro.Controls.Add(this.lblEditorial);
            this.grpAgregarLibro.Controls.Add(this.lblAutor);
            this.grpAgregarLibro.Controls.Add(this.lblCategoria);
            this.grpAgregarLibro.Controls.Add(this.lblNombre);
            this.grpAgregarLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAgregarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgregarLibro.Location = new System.Drawing.Point(0, 0);
            this.grpAgregarLibro.Name = "grpAgregarLibro";
            this.grpAgregarLibro.Size = new System.Drawing.Size(835, 748);
            this.grpAgregarLibro.TabIndex = 1;
            this.grpAgregarLibro.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Navy;
            this.btnCancelar.Location = new System.Drawing.Point(331, 675);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.Color.Navy;
            this.btnModificar.Location = new System.Drawing.Point(149, 675);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 48);
            this.btnModificar.TabIndex = 21;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // pboxImagen
            // 
            this.pboxImagen.Image = ((System.Drawing.Image)(resources.GetObject("pboxImagen.Image")));
            this.pboxImagen.Location = new System.Drawing.Point(485, 247);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(256, 256);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 20;
            this.pboxImagen.TabStop = false;
            // 
            // txtEstante
            // 
            this.txtEstante.Location = new System.Drawing.Point(311, 578);
            this.txtEstante.Name = "txtEstante";
            this.txtEstante.Size = new System.Drawing.Size(106, 27);
            this.txtEstante.TabIndex = 18;
            // 
            // txtPasillo
            // 
            this.txtPasillo.Location = new System.Drawing.Point(166, 578);
            this.txtPasillo.Name = "txtPasillo";
            this.txtPasillo.Size = new System.Drawing.Size(106, 27);
            this.txtPasillo.TabIndex = 17;
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Location = new System.Drawing.Point(33, 578);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(106, 27);
            this.txtHabitacion.TabIndex = 16;
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(250, 281);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(156, 28);
            this.cmbEditorial.TabIndex = 14;
            // 
            // cmbAutor
            // 
            this.cmbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(250, 223);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(156, 28);
            this.cmbAutor.TabIndex = 13;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(250, 176);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(156, 27);
            this.txtCategoria.TabIndex = 12;
            // 
            // txtCantDisponible
            // 
            this.txtCantDisponible.Location = new System.Drawing.Point(250, 330);
            this.txtCantDisponible.Name = "txtCantDisponible";
            this.txtCantDisponible.Size = new System.Drawing.Size(156, 27);
            this.txtCantDisponible.TabIndex = 11;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(250, 112);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(156, 27);
            this.txtNombreLibro.TabIndex = 10;
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.Location = new System.Drawing.Point(327, 524);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(79, 20);
            this.lblEstante.TabIndex = 9;
            this.lblEstante.Text = "Estante:";
            // 
            // lblPasillo
            // 
            this.lblPasillo.AutoSize = true;
            this.lblPasillo.Location = new System.Drawing.Point(191, 524);
            this.lblPasillo.Name = "lblPasillo";
            this.lblPasillo.Size = new System.Drawing.Size(72, 20);
            this.lblPasillo.TabIndex = 8;
            this.lblPasillo.Text = "Pasillo:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(43, 524);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(105, 20);
            this.lblHabitacion.TabIndex = 7;
            this.lblHabitacion.Text = "Habitación:";
            // 
            // lblUbicacionPasillo
            // 
            this.lblUbicacionPasillo.AutoSize = true;
            this.lblUbicacionPasillo.Location = new System.Drawing.Point(41, 466);
            this.lblUbicacionPasillo.Name = "lblUbicacionPasillo";
            this.lblUbicacionPasillo.Size = new System.Drawing.Size(156, 20);
            this.lblUbicacionPasillo.TabIndex = 6;
            this.lblUbicacionPasillo.Text = "Ubicacion Pasilo:";
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(41, 395);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(169, 20);
            this.lblFechaPublicacion.TabIndex = 5;
            this.lblFechaPublicacion.Text = "Fecha Publicacion:";
            // 
            // lblCantidadDisponible
            // 
            this.lblCantidadDisponible.AutoSize = true;
            this.lblCantidadDisponible.Location = new System.Drawing.Point(41, 330);
            this.lblCantidadDisponible.Name = "lblCantidadDisponible";
            this.lblCantidadDisponible.Size = new System.Drawing.Size(184, 20);
            this.lblCantidadDisponible.TabIndex = 4;
            this.lblCantidadDisponible.Text = "Cantidad Disponible:";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(41, 281);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(85, 20);
            this.lblEditorial.TabIndex = 3;
            this.lblEditorial.Text = "Editorial:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(44, 223);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(60, 20);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(41, 165);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(96, 20);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 112);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Libro:";
            // 
            // cmbIdLibro
            // 
            this.cmbIdLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdLibro.FormattingEnabled = true;
            this.cmbIdLibro.Location = new System.Drawing.Point(253, 35);
            this.cmbIdLibro.Name = "cmbIdLibro";
            this.cmbIdLibro.Size = new System.Drawing.Size(156, 28);
            this.cmbIdLibro.TabIndex = 24;
            // 
            // lblIdLibro
            // 
            this.lblIdLibro.AutoSize = true;
            this.lblIdLibro.Location = new System.Drawing.Point(44, 35);
            this.lblIdLibro.Name = "lblIdLibro";
            this.lblIdLibro.Size = new System.Drawing.Size(83, 20);
            this.lblIdLibro.TabIndex = 23;
            this.lblIdLibro.Text = "ID Libro:";
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(250, 395);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(156, 27);
            this.dtpFechaPublicacion.TabIndex = 25;
            // 
            // lblMensajeAdmin
            // 
            this.lblMensajeAdmin.AutoSize = true;
            this.lblMensajeAdmin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMensajeAdmin.Location = new System.Drawing.Point(448, 67);
            this.lblMensajeAdmin.Name = "lblMensajeAdmin";
            this.lblMensajeAdmin.Size = new System.Drawing.Size(352, 100);
            this.lblMensajeAdmin.TabIndex = 26;
            this.lblMensajeAdmin.Text = "Señor(a) Administrador(a):\r\nSi las opciones de Autor y Editorial\r\nEstan vacías, a" +
    "greguelas primero en sus\r\n pantallas respectivas.\r\n\r\n";
            // 
            // frmModificarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 748);
            this.Controls.Add(this.grpAgregarLibro);
            this.Name = "frmModificarLibro";
            this.Text = "Modificar Libro";
            this.grpAgregarLibro.ResumeLayout(false);
            this.grpAgregarLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregarLibro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pboxImagen;
        private System.Windows.Forms.TextBox txtEstante;
        private System.Windows.Forms.TextBox txtPasillo;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtCantDisponible;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label lblEstante;
        private System.Windows.Forms.Label lblPasillo;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.Label lblUbicacionPasillo;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.Label lblCantidadDisponible;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbIdLibro;
        private System.Windows.Forms.Label lblIdLibro;
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.Label lblMensajeAdmin;
    }
}