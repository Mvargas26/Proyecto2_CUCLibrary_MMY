﻿
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblCantidadDisponible = new System.Windows.Forms.Label();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.lblUbicacionPasillo = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.lblPasillo = new System.Windows.Forms.Label();
            this.lblEstante = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpAgregarLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgregarLibro
            // 
            this.grpAgregarLibro.Controls.Add(this.btnCancelar);
            this.grpAgregarLibro.Controls.Add(this.btnAgregar);
            this.grpAgregarLibro.Controls.Add(this.pictureBox1);
            this.grpAgregarLibro.Controls.Add(this.label1);
            this.grpAgregarLibro.Controls.Add(this.textBox7);
            this.grpAgregarLibro.Controls.Add(this.textBox6);
            this.grpAgregarLibro.Controls.Add(this.textBox5);
            this.grpAgregarLibro.Controls.Add(this.textBox4);
            this.grpAgregarLibro.Controls.Add(this.comboBox2);
            this.grpAgregarLibro.Controls.Add(this.comboBox1);
            this.grpAgregarLibro.Controls.Add(this.textBox3);
            this.grpAgregarLibro.Controls.Add(this.textBox2);
            this.grpAgregarLibro.Controls.Add(this.textBox1);
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
            this.grpAgregarLibro.Size = new System.Drawing.Size(824, 684);
            this.grpAgregarLibro.TabIndex = 0;
            this.grpAgregarLibro.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(129, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Libro:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(35, 101);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(96, 20);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(38, 159);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(60, 20);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Autor:";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(35, 217);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(85, 20);
            this.lblEditorial.TabIndex = 3;
            this.lblEditorial.Text = "Editorial:";
            // 
            // lblCantidadDisponible
            // 
            this.lblCantidadDisponible.AutoSize = true;
            this.lblCantidadDisponible.Location = new System.Drawing.Point(35, 266);
            this.lblCantidadDisponible.Name = "lblCantidadDisponible";
            this.lblCantidadDisponible.Size = new System.Drawing.Size(184, 20);
            this.lblCantidadDisponible.TabIndex = 4;
            this.lblCantidadDisponible.Text = "Cantidad Disponible:";
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(35, 331);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(169, 20);
            this.lblFechaPublicacion.TabIndex = 5;
            this.lblFechaPublicacion.Text = "Fecha Publicacion:";
            // 
            // lblUbicacionPasillo
            // 
            this.lblUbicacionPasillo.AutoSize = true;
            this.lblUbicacionPasillo.Location = new System.Drawing.Point(35, 402);
            this.lblUbicacionPasillo.Name = "lblUbicacionPasillo";
            this.lblUbicacionPasillo.Size = new System.Drawing.Size(156, 20);
            this.lblUbicacionPasillo.TabIndex = 6;
            this.lblUbicacionPasillo.Text = "Ubicacion Pasilo:";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(37, 460);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(105, 20);
            this.lblHabitacion.TabIndex = 7;
            this.lblHabitacion.Text = "Habitación:";
            // 
            // lblPasillo
            // 
            this.lblPasillo.AutoSize = true;
            this.lblPasillo.Location = new System.Drawing.Point(185, 460);
            this.lblPasillo.Name = "lblPasillo";
            this.lblPasillo.Size = new System.Drawing.Size(72, 20);
            this.lblPasillo.TabIndex = 8;
            this.lblPasillo.Text = "Pasillo:";
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.Location = new System.Drawing.Point(321, 460);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(79, 20);
            this.lblEstante.TabIndex = 9;
            this.lblEstante.Text = "Estante:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 27);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 27);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(244, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 27);
            this.textBox3.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(244, 217);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 28);
            this.comboBox2.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(244, 331);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 27);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 514);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(106, 27);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(160, 514);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(106, 27);
            this.textBox6.TabIndex = 17;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(305, 514);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(106, 27);
            this.textBox7.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 100);
            this.label1.TabIndex = 19;
            this.label1.Text = "Señor(a) Administrador(a):\r\nSi las opciones de Autor y Editorial\r\nEstan vacías, a" +
    "greguelas primero en sus\r\n pantallas respectivas.\r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(446, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(143, 611);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 48);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(325, 611);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 684);
            this.Controls.Add(this.grpAgregarLibro);
            this.Name = "frmAgregarLibro";
            this.Text = "Agregar Libro";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}