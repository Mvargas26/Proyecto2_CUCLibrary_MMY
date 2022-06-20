
namespace Interfaz
{
    partial class frmEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrada));
            this.grpVentanaEntrada = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModuloUsuario = new System.Windows.Forms.Button();
            this.btnModuloAdmin = new System.Windows.Forms.Button();
            this.lblSeleccione = new System.Windows.Forms.Label();
            this.grpVentanaEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVentanaEntrada
            // 
            this.grpVentanaEntrada.Controls.Add(this.pictureBox1);
            this.grpVentanaEntrada.Controls.Add(this.btnModuloUsuario);
            this.grpVentanaEntrada.Controls.Add(this.btnModuloAdmin);
            this.grpVentanaEntrada.Controls.Add(this.lblSeleccione);
            this.grpVentanaEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVentanaEntrada.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVentanaEntrada.Location = new System.Drawing.Point(0, 0);
            this.grpVentanaEntrada.Name = "grpVentanaEntrada";
            this.grpVentanaEntrada.Size = new System.Drawing.Size(378, 450);
            this.grpVentanaEntrada.TabIndex = 0;
            this.grpVentanaEntrada.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 314);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnModuloUsuario
            // 
            this.btnModuloUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModuloUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModuloUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnModuloUsuario.Location = new System.Drawing.Point(45, 218);
            this.btnModuloUsuario.Name = "btnModuloUsuario";
            this.btnModuloUsuario.Size = new System.Drawing.Size(251, 52);
            this.btnModuloUsuario.TabIndex = 2;
            this.btnModuloUsuario.Text = "Módulo Usuario";
            this.btnModuloUsuario.UseVisualStyleBackColor = false;
            // 
            // btnModuloAdmin
            // 
            this.btnModuloAdmin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModuloAdmin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModuloAdmin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnModuloAdmin.Location = new System.Drawing.Point(45, 104);
            this.btnModuloAdmin.Name = "btnModuloAdmin";
            this.btnModuloAdmin.Size = new System.Drawing.Size(251, 52);
            this.btnModuloAdmin.TabIndex = 1;
            this.btnModuloAdmin.Text = "Módulo Administrativo";
            this.btnModuloAdmin.UseVisualStyleBackColor = false;
            this.btnModuloAdmin.Click += new System.EventHandler(this.btnModuloAdmin_Click);
            // 
            // lblSeleccione
            // 
            this.lblSeleccione.AutoSize = true;
            this.lblSeleccione.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccione.Location = new System.Drawing.Point(23, 37);
            this.lblSeleccione.Name = "lblSeleccione";
            this.lblSeleccione.Size = new System.Drawing.Size(313, 28);
            this.lblSeleccione.TabIndex = 0;
            this.lblSeleccione.Text = "Seleccione el Módulo de Uso";
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.grpVentanaEntrada);
            this.Name = "frmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Entrada";
            this.grpVentanaEntrada.ResumeLayout(false);
            this.grpVentanaEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVentanaEntrada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModuloUsuario;
        private System.Windows.Forms.Button btnModuloAdmin;
        private System.Windows.Forms.Label lblSeleccione;
    }
}

