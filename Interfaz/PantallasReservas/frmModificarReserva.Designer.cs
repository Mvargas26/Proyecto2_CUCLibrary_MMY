
namespace Interfaz.PantallasReservas
{
    partial class frmModificarReserva
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
            this.grpModificarReserva = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblIDReserva = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFechaRegreso = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoReserva = new System.Windows.Forms.ComboBox();
            this.cmbLibroReserva = new System.Windows.Forms.ComboBox();
            this.cmbUsuarioReserva = new System.Windows.Forms.ComboBox();
            this.lblEstadoReserva = new System.Windows.Forms.Label();
            this.lblfechaRegreso = new System.Windows.Forms.Label();
            this.lblFechaRetiro = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpModificarReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpModificarReserva
            // 
            this.grpModificarReserva.Controls.Add(this.comboBox1);
            this.grpModificarReserva.Controls.Add(this.lblIDReserva);
            this.grpModificarReserva.Controls.Add(this.button2);
            this.grpModificarReserva.Controls.Add(this.btnModificar);
            this.grpModificarReserva.Controls.Add(this.pictureBox1);
            this.grpModificarReserva.Controls.Add(this.dtpFechaRegreso);
            this.grpModificarReserva.Controls.Add(this.dtpFechaRetiro);
            this.grpModificarReserva.Controls.Add(this.cmbEstadoReserva);
            this.grpModificarReserva.Controls.Add(this.cmbLibroReserva);
            this.grpModificarReserva.Controls.Add(this.cmbUsuarioReserva);
            this.grpModificarReserva.Controls.Add(this.lblEstadoReserva);
            this.grpModificarReserva.Controls.Add(this.lblfechaRegreso);
            this.grpModificarReserva.Controls.Add(this.lblFechaRetiro);
            this.grpModificarReserva.Controls.Add(this.lblLibro);
            this.grpModificarReserva.Controls.Add(this.lblUsuario);
            this.grpModificarReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpModificarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModificarReserva.Location = new System.Drawing.Point(0, 0);
            this.grpModificarReserva.Name = "grpModificarReserva";
            this.grpModificarReserva.Size = new System.Drawing.Size(797, 506);
            this.grpModificarReserva.TabIndex = 1;
            this.grpModificarReserva.TabStop = false;
            this.grpModificarReserva.Text = "Modificar Reserva";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(328, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 28);
            this.comboBox1.TabIndex = 27;
            // 
            // lblIDReserva
            // 
            this.lblIDReserva.AutoSize = true;
            this.lblIDReserva.Location = new System.Drawing.Point(23, 50);
            this.lblIDReserva.Name = "lblIDReserva";
            this.lblIDReserva.Size = new System.Drawing.Size(156, 20);
            this.lblIDReserva.TabIndex = 26;
            this.lblIDReserva.Text = "ID de la Reserva:";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(408, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 48);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.Color.Navy;
            this.btnModificar.Location = new System.Drawing.Point(226, 429);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 48);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.calendar2;
            this.pictureBox1.Location = new System.Drawing.Point(587, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegreso.Location = new System.Drawing.Point(347, 263);
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Size = new System.Drawing.Size(184, 27);
            this.dtpFechaRegreso.TabIndex = 9;
            // 
            // dtpFechaRetiro
            // 
            this.dtpFechaRetiro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRetiro.Location = new System.Drawing.Point(347, 220);
            this.dtpFechaRetiro.Name = "dtpFechaRetiro";
            this.dtpFechaRetiro.Size = new System.Drawing.Size(184, 27);
            this.dtpFechaRetiro.TabIndex = 8;
            // 
            // cmbEstadoReserva
            // 
            this.cmbEstadoReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoReserva.FormattingEnabled = true;
            this.cmbEstadoReserva.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.cmbEstadoReserva.Location = new System.Drawing.Point(328, 314);
            this.cmbEstadoReserva.Name = "cmbEstadoReserva";
            this.cmbEstadoReserva.Size = new System.Drawing.Size(203, 28);
            this.cmbEstadoReserva.TabIndex = 7;
            // 
            // cmbLibroReserva
            // 
            this.cmbLibroReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibroReserva.FormattingEnabled = true;
            this.cmbLibroReserva.Location = new System.Drawing.Point(328, 157);
            this.cmbLibroReserva.Name = "cmbLibroReserva";
            this.cmbLibroReserva.Size = new System.Drawing.Size(203, 28);
            this.cmbLibroReserva.TabIndex = 6;
            // 
            // cmbUsuarioReserva
            // 
            this.cmbUsuarioReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioReserva.FormattingEnabled = true;
            this.cmbUsuarioReserva.Location = new System.Drawing.Point(328, 99);
            this.cmbUsuarioReserva.Name = "cmbUsuarioReserva";
            this.cmbUsuarioReserva.Size = new System.Drawing.Size(203, 28);
            this.cmbUsuarioReserva.TabIndex = 5;
            // 
            // lblEstadoReserva
            // 
            this.lblEstadoReserva.AutoSize = true;
            this.lblEstadoReserva.Location = new System.Drawing.Point(23, 322);
            this.lblEstadoReserva.Name = "lblEstadoReserva";
            this.lblEstadoReserva.Size = new System.Drawing.Size(216, 20);
            this.lblEstadoReserva.TabIndex = 4;
            this.lblEstadoReserva.Text = "Estado de esta Reserva:";
            // 
            // lblfechaRegreso
            // 
            this.lblfechaRegreso.AutoSize = true;
            this.lblfechaRegreso.Location = new System.Drawing.Point(23, 263);
            this.lblfechaRegreso.Name = "lblfechaRegreso";
            this.lblfechaRegreso.Size = new System.Drawing.Size(142, 20);
            this.lblfechaRegreso.TabIndex = 3;
            this.lblfechaRegreso.Text = "Fecha Regreso:";
            // 
            // lblFechaRetiro
            // 
            this.lblFechaRetiro.AutoSize = true;
            this.lblFechaRetiro.Location = new System.Drawing.Point(23, 208);
            this.lblFechaRetiro.Name = "lblFechaRetiro";
            this.lblFechaRetiro.Size = new System.Drawing.Size(123, 20);
            this.lblFechaRetiro.TabIndex = 2;
            this.lblFechaRetiro.Text = "Fecha Retiro:";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(23, 157);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(58, 20);
            this.lblLibro.TabIndex = 1;
            this.lblLibro.Text = "Libro:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(23, 107);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario:";
            // 
            // frmModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 506);
            this.Controls.Add(this.grpModificarReserva);
            this.Name = "frmModificarReserva";
            this.Text = "Modificar Reserva";
            this.grpModificarReserva.ResumeLayout(false);
            this.grpModificarReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModificarReserva;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblIDReserva;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaRegreso;
        private System.Windows.Forms.DateTimePicker dtpFechaRetiro;
        private System.Windows.Forms.ComboBox cmbEstadoReserva;
        private System.Windows.Forms.ComboBox cmbLibroReserva;
        private System.Windows.Forms.ComboBox cmbUsuarioReserva;
        private System.Windows.Forms.Label lblEstadoReserva;
        private System.Windows.Forms.Label lblfechaRegreso;
        private System.Windows.Forms.Label lblFechaRetiro;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblUsuario;
    }
}