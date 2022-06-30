
namespace Interfaz.PantallasEditoriales
{
    partial class frmAgregarEditorial
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
            this.grpEditorial = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtLugarOrigen = new System.Windows.Forms.TextBox();
            this.lblLugarOrigen = new System.Windows.Forms.Label();
            this.txtNombreEditorial = new System.Windows.Forms.TextBox();
            this.lblNombreEditorial = new System.Windows.Forms.Label();
            this.grpEditorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEditorial
            // 
            this.grpEditorial.Controls.Add(this.pictureBox1);
            this.grpEditorial.Controls.Add(this.btnCancelar);
            this.grpEditorial.Controls.Add(this.btnAgregar);
            this.grpEditorial.Controls.Add(this.txtLugarOrigen);
            this.grpEditorial.Controls.Add(this.lblLugarOrigen);
            this.grpEditorial.Controls.Add(this.txtNombreEditorial);
            this.grpEditorial.Controls.Add(this.lblNombreEditorial);
            this.grpEditorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditorial.Location = new System.Drawing.Point(0, 0);
            this.grpEditorial.Name = "grpEditorial";
            this.grpEditorial.Size = new System.Drawing.Size(717, 373);
            this.grpEditorial.TabIndex = 1;
            this.grpEditorial.TabStop = false;
            this.grpEditorial.Text = "Nueva Editorial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.Editorial;
            this.pictureBox1.Location = new System.Drawing.Point(526, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(356, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(174, 280);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 48);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtLugarOrigen
            // 
            this.txtLugarOrigen.Location = new System.Drawing.Point(290, 167);
            this.txtLugarOrigen.Name = "txtLugarOrigen";
            this.txtLugarOrigen.Size = new System.Drawing.Size(176, 28);
            this.txtLugarOrigen.TabIndex = 3;
            // 
            // lblLugarOrigen
            // 
            this.lblLugarOrigen.AutoSize = true;
            this.lblLugarOrigen.Location = new System.Drawing.Point(32, 171);
            this.lblLugarOrigen.Name = "lblLugarOrigen";
            this.lblLugarOrigen.Size = new System.Drawing.Size(169, 24);
            this.lblLugarOrigen.TabIndex = 2;
            this.lblLugarOrigen.Text = "Lugar de Origen:";
            // 
            // txtNombreEditorial
            // 
            this.txtNombreEditorial.Location = new System.Drawing.Point(290, 68);
            this.txtNombreEditorial.Name = "txtNombreEditorial";
            this.txtNombreEditorial.Size = new System.Drawing.Size(176, 28);
            this.txtNombreEditorial.TabIndex = 1;
            // 
            // lblNombreEditorial
            // 
            this.lblNombreEditorial.AutoSize = true;
            this.lblNombreEditorial.Location = new System.Drawing.Point(32, 67);
            this.lblNombreEditorial.Name = "lblNombreEditorial";
            this.lblNombreEditorial.Size = new System.Drawing.Size(225, 24);
            this.lblNombreEditorial.TabIndex = 0;
            this.lblNombreEditorial.Text = "Nombre de la Editorial:";
            // 
            // frmAgregarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 373);
            this.Controls.Add(this.grpEditorial);
            this.Name = "frmAgregarEditorial";
            this.Text = "Agregar Editorial";
            this.grpEditorial.ResumeLayout(false);
            this.grpEditorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEditorial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtLugarOrigen;
        private System.Windows.Forms.Label lblLugarOrigen;
        private System.Windows.Forms.TextBox txtNombreEditorial;
        private System.Windows.Forms.Label lblNombreEditorial;
    }
}