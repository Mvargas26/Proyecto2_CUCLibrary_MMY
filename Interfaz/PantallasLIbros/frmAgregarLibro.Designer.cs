
namespace Interfaz
{
    partial class frmAgregarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarLibro));
            this.grpAgregarLibro = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarAutores = new System.Windows.Forms.Button();
            this.cmbEstante = new System.Windows.Forms.ComboBox();
            this.cmbPasillo = new System.Windows.Forms.ComboBox();
            this.cmbHabitacion = new System.Windows.Forms.ComboBox();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.txtCantDisponible = new System.Windows.Forms.TextBox();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMensajeAdmin = new System.Windows.Forms.Label();
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
            this.grpAgregarLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgregarLibro
            // 
            this.grpAgregarLibro.Controls.Add(this.cmbCategoria);
            this.grpAgregarLibro.Controls.Add(this.btnAgregarAutores);
            this.grpAgregarLibro.Controls.Add(this.cmbEstante);
            this.grpAgregarLibro.Controls.Add(this.cmbPasillo);
            this.grpAgregarLibro.Controls.Add(this.cmbHabitacion);
            this.grpAgregarLibro.Controls.Add(this.cmbEditorial);
            this.grpAgregarLibro.Controls.Add(this.txtCantDisponible);
            this.grpAgregarLibro.Controls.Add(this.txtNombreLibro);
            this.grpAgregarLibro.Controls.Add(this.dtpFechaPublicacion);
            this.grpAgregarLibro.Controls.Add(this.btnCancelar);
            this.grpAgregarLibro.Controls.Add(this.btnAgregar);
            this.grpAgregarLibro.Controls.Add(this.pictureBox1);
            this.grpAgregarLibro.Controls.Add(this.lblMensajeAdmin);
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
            this.grpAgregarLibro.Size = new System.Drawing.Size(811, 658);
            this.grpAgregarLibro.TabIndex = 0;
            this.grpAgregarLibro.TabStop = false;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(217, 85);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(172, 28);
            this.cmbCategoria.TabIndex = 22;
            // 
            // btnAgregarAutores
            // 
            this.btnAgregarAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAutores.Location = new System.Drawing.Point(217, 143);
            this.btnAgregarAutores.Name = "btnAgregarAutores";
            this.btnAgregarAutores.Size = new System.Drawing.Size(172, 35);
            this.btnAgregarAutores.TabIndex = 21;
            this.btnAgregarAutores.Text = "Selecionar Autores\r\n";
            this.btnAgregarAutores.UseVisualStyleBackColor = true;
            this.btnAgregarAutores.Click += new System.EventHandler(this.btnAgregarAutores_Click);
            // 
            // cmbEstante
            // 
            this.cmbEstante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstante.FormattingEnabled = true;
            this.cmbEstante.Location = new System.Drawing.Point(518, 460);
            this.cmbEstante.Name = "cmbEstante";
            this.cmbEstante.Size = new System.Drawing.Size(156, 28);
            this.cmbEstante.TabIndex = 9;
            // 
            // cmbPasillo
            // 
            this.cmbPasillo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPasillo.FormattingEnabled = true;
            this.cmbPasillo.Location = new System.Drawing.Point(281, 460);
            this.cmbPasillo.Name = "cmbPasillo";
            this.cmbPasillo.Size = new System.Drawing.Size(156, 28);
            this.cmbPasillo.TabIndex = 8;
            this.cmbPasillo.SelectedIndexChanged += new System.EventHandler(this.cmbPasillo_SelectedIndexChanged);
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.Location = new System.Drawing.Point(50, 460);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.Size = new System.Drawing.Size(156, 28);
            this.cmbHabitacion.TabIndex = 7;
            this.cmbHabitacion.SelectedIndexChanged += new System.EventHandler(this.cmbHabitacion_SelectedIndexChanged);
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(217, 201);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(172, 28);
            this.cmbEditorial.TabIndex = 4;
            // 
            // txtCantDisponible
            // 
            this.txtCantDisponible.Location = new System.Drawing.Point(217, 250);
            this.txtCantDisponible.Name = "txtCantDisponible";
            this.txtCantDisponible.Size = new System.Drawing.Size(172, 27);
            this.txtCantDisponible.TabIndex = 5;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(217, 32);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(172, 27);
            this.txtNombreLibro.TabIndex = 1;
            // 
            // dtpFechaPublicacion
            // 
            this.dtpFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(217, 315);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(172, 27);
            this.dtpFechaPublicacion.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(399, 552);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(217, 552);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 48);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(443, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblMensajeAdmin
            // 
            this.lblMensajeAdmin.AutoSize = true;
            this.lblMensajeAdmin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMensajeAdmin.Location = new System.Drawing.Point(419, 35);
            this.lblMensajeAdmin.Name = "lblMensajeAdmin";
            this.lblMensajeAdmin.Size = new System.Drawing.Size(352, 120);
            this.lblMensajeAdmin.TabIndex = 19;
            this.lblMensajeAdmin.Text = "Señor(a) Administrador(a):\r\nSi las opciones de Autor,Editorial,\r\nHabitacion,Pasil" +
    "lo,Estante\r\nEstan vacías, agreguelas primero en sus\r\n pantallas respectivas.\r\n\r\n" +
    "";
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.Location = new System.Drawing.Point(544, 423);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(79, 20);
            this.lblEstante.TabIndex = 9;
            this.lblEstante.Text = "Estante:";
            // 
            // lblPasillo
            // 
            this.lblPasillo.AutoSize = true;
            this.lblPasillo.Location = new System.Drawing.Point(298, 423);
            this.lblPasillo.Name = "lblPasillo";
            this.lblPasillo.Size = new System.Drawing.Size(72, 20);
            this.lblPasillo.TabIndex = 8;
            this.lblPasillo.Text = "Pasillo:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(65, 423);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(105, 20);
            this.lblHabitacion.TabIndex = 7;
            this.lblHabitacion.Text = "Habitación:";
            // 
            // lblUbicacionPasillo
            // 
            this.lblUbicacionPasillo.AutoSize = true;
            this.lblUbicacionPasillo.Location = new System.Drawing.Point(24, 386);
            this.lblUbicacionPasillo.Name = "lblUbicacionPasillo";
            this.lblUbicacionPasillo.Size = new System.Drawing.Size(156, 20);
            this.lblUbicacionPasillo.TabIndex = 6;
            this.lblUbicacionPasillo.Text = "Ubicacion Pasilo:";
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(24, 315);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(169, 20);
            this.lblFechaPublicacion.TabIndex = 5;
            this.lblFechaPublicacion.Text = "Fecha Publicacion:";
            // 
            // lblCantidadDisponible
            // 
            this.lblCantidadDisponible.AutoSize = true;
            this.lblCantidadDisponible.Location = new System.Drawing.Point(24, 250);
            this.lblCantidadDisponible.Name = "lblCantidadDisponible";
            this.lblCantidadDisponible.Size = new System.Drawing.Size(184, 20);
            this.lblCantidadDisponible.TabIndex = 4;
            this.lblCantidadDisponible.Text = "Cantidad Disponible:";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(24, 201);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(85, 20);
            this.lblEditorial.TabIndex = 3;
            this.lblEditorial.Text = "Editorial:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(27, 143);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(60, 20);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(24, 85);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(96, 20);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Libro:";
            // 
            // frmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 658);
            this.Controls.Add(this.grpAgregarLibro);
            this.Name = "frmAgregarLibro";
            this.Text = "Agregar Libro";
            this.Load += new System.EventHandler(this.frmAgregarLibro_Load);
            this.grpAgregarLibro.ResumeLayout(false);
            this.grpAgregarLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregarLibro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMensajeAdmin;
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
        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.TextBox txtCantDisponible;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.ComboBox cmbEstante;
        private System.Windows.Forms.ComboBox cmbPasillo;
        private System.Windows.Forms.ComboBox cmbHabitacion;
        private System.Windows.Forms.Button btnAgregarAutores;
        private System.Windows.Forms.ComboBox cmbCategoria;
    }
}