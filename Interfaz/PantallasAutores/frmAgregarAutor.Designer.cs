
namespace Interfaz.PantallasAutores
{
    partial class frmAgregarAutor
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
            this.grpAutor = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtLugarOrigen = new System.Windows.Forms.TextBox();
            this.lblLugarOrigen = new System.Windows.Forms.Label();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.grpAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAutor
            // 
            this.grpAutor.Controls.Add(this.pictureBox1);
            this.grpAutor.Controls.Add(this.btnCancelar);
            this.grpAutor.Controls.Add(this.btnAgregar);
            this.grpAutor.Controls.Add(this.txtLugarOrigen);
            this.grpAutor.Controls.Add(this.lblLugarOrigen);
            this.grpAutor.Controls.Add(this.txtNombreAutor);
            this.grpAutor.Controls.Add(this.lblNombreAutor);
            this.grpAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAutor.Location = new System.Drawing.Point(0, 0);
            this.grpAutor.Name = "grpAutor";
            this.grpAutor.Size = new System.Drawing.Size(691, 355);
            this.grpAutor.TabIndex = 0;
            this.grpAutor.TabStop = false;
            this.grpAutor.Text = "Nuevo Autor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.writer;
            this.pictureBox1.Location = new System.Drawing.Point(495, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(260, 276);
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
            this.btnAgregar.Location = new System.Drawing.Point(78, 276);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 48);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtLugarOrigen
            // 
            this.txtLugarOrigen.Location = new System.Drawing.Point(260, 172);
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
            // txtNombreAutor
            // 
            this.txtNombreAutor.Location = new System.Drawing.Point(260, 68);
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.Size = new System.Drawing.Size(176, 28);
            this.txtNombreAutor.TabIndex = 1;
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.Location = new System.Drawing.Point(32, 67);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(182, 24);
            this.lblNombreAutor.TabIndex = 0;
            this.lblNombreAutor.Text = "Nombre del Autor:";
            // 
            // frmAgregarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 355);
            this.Controls.Add(this.grpAutor);
            this.Name = "frmAgregarAutor";
            this.Text = "Agregar Autor";
            this.grpAutor.ResumeLayout(false);
            this.grpAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAutor;
        private System.Windows.Forms.TextBox txtLugarOrigen;
        private System.Windows.Forms.Label lblLugarOrigen;
        private System.Windows.Forms.TextBox txtNombreAutor;
        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}