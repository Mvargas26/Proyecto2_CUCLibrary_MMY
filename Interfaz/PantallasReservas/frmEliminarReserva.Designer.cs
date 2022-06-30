
namespace Interfaz.PantallasReservas
{
    partial class frmEliminarReserva
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
            this.grpEliminarReserva = new System.Windows.Forms.GroupBox();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbUsuarioReserva = new System.Windows.Forms.ComboBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblIDReserva = new System.Windows.Forms.Label();
            this.grpEliminarReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEliminarReserva
            // 
            this.grpEliminarReserva.Controls.Add(this.txtNombreUser);
            this.grpEliminarReserva.Controls.Add(this.button2);
            this.grpEliminarReserva.Controls.Add(this.btnEliminar);
            this.grpEliminarReserva.Controls.Add(this.pictureBox1);
            this.grpEliminarReserva.Controls.Add(this.cmbUsuarioReserva);
            this.grpEliminarReserva.Controls.Add(this.lblNombreUsuario);
            this.grpEliminarReserva.Controls.Add(this.lblIDReserva);
            this.grpEliminarReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEliminarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarReserva.Location = new System.Drawing.Point(0, 0);
            this.grpEliminarReserva.Name = "grpEliminarReserva";
            this.grpEliminarReserva.Size = new System.Drawing.Size(662, 346);
            this.grpEliminarReserva.TabIndex = 1;
            this.grpEliminarReserva.TabStop = false;
            this.grpEliminarReserva.Text = "Eliminar";
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Location = new System.Drawing.Point(203, 108);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.ReadOnly = true;
            this.txtNombreUser.Size = new System.Drawing.Size(203, 27);
            this.txtNombreUser.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(272, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 48);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Navy;
            this.btnEliminar.Location = new System.Drawing.Point(90, 244);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 48);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.basurero2;
            this.pictureBox1.Location = new System.Drawing.Point(456, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // cmbUsuarioReserva
            // 
            this.cmbUsuarioReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioReserva.FormattingEnabled = true;
            this.cmbUsuarioReserva.Location = new System.Drawing.Point(203, 55);
            this.cmbUsuarioReserva.Name = "cmbUsuarioReserva";
            this.cmbUsuarioReserva.Size = new System.Drawing.Size(203, 28);
            this.cmbUsuarioReserva.TabIndex = 5;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(26, 108);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(151, 20);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "Nombre Usuario:";
            // 
            // lblIDReserva
            // 
            this.lblIDReserva.AutoSize = true;
            this.lblIDReserva.Location = new System.Drawing.Point(26, 58);
            this.lblIDReserva.Name = "lblIDReserva";
            this.lblIDReserva.Size = new System.Drawing.Size(109, 20);
            this.lblIDReserva.TabIndex = 0;
            this.lblIDReserva.Text = "ID Reserva:";
            // 
            // frmEliminarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 346);
            this.Controls.Add(this.grpEliminarReserva);
            this.Name = "frmEliminarReserva";
            this.Text = "Eliminar Reserva";
            this.grpEliminarReserva.ResumeLayout(false);
            this.grpEliminarReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEliminarReserva;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbUsuarioReserva;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblIDReserva;
        private System.Windows.Forms.TextBox txtNombreUser;
    }
}