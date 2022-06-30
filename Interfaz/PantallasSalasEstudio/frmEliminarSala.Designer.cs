
namespace Interfaz.PantallasSalasEstudio
{
    partial class frmEliminarSala
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
            this.grpEliminarSala = new System.Windows.Forms.GroupBox();
            this.cmbIDSala = new System.Windows.Forms.ComboBox();
            this.lblIDSala = new System.Windows.Forms.Label();
            this.picImagenDecorativa = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTipoSala = new System.Windows.Forms.TextBox();
            this.lblTipoSala = new System.Windows.Forms.Label();
            this.grpEliminarSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenDecorativa)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEliminarSala
            // 
            this.grpEliminarSala.Controls.Add(this.cmbIDSala);
            this.grpEliminarSala.Controls.Add(this.lblIDSala);
            this.grpEliminarSala.Controls.Add(this.picImagenDecorativa);
            this.grpEliminarSala.Controls.Add(this.btnCancelar);
            this.grpEliminarSala.Controls.Add(this.btnAgregar);
            this.grpEliminarSala.Controls.Add(this.txtTipoSala);
            this.grpEliminarSala.Controls.Add(this.lblTipoSala);
            this.grpEliminarSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEliminarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarSala.Location = new System.Drawing.Point(0, 0);
            this.grpEliminarSala.Name = "grpEliminarSala";
            this.grpEliminarSala.Size = new System.Drawing.Size(796, 327);
            this.grpEliminarSala.TabIndex = 4;
            this.grpEliminarSala.TabStop = false;
            this.grpEliminarSala.Text = "Eliminar Sala";
            // 
            // cmbIDSala
            // 
            this.cmbIDSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDSala.FormattingEnabled = true;
            this.cmbIDSala.Location = new System.Drawing.Point(290, 57);
            this.cmbIDSala.Name = "cmbIDSala";
            this.cmbIDSala.Size = new System.Drawing.Size(176, 30);
            this.cmbIDSala.TabIndex = 28;
            // 
            // lblIDSala
            // 
            this.lblIDSala.AutoSize = true;
            this.lblIDSala.Location = new System.Drawing.Point(32, 57);
            this.lblIDSala.Name = "lblIDSala";
            this.lblIDSala.Size = new System.Drawing.Size(133, 24);
            this.lblIDSala.TabIndex = 27;
            this.lblIDSala.Text = "ID de la Sala:";
            // 
            // picImagenDecorativa
            // 
            this.picImagenDecorativa.Image = global::Interfaz.Properties.Resources.Basurero;
            this.picImagenDecorativa.InitialImage = global::Interfaz.Properties.Resources.room;
            this.picImagenDecorativa.Location = new System.Drawing.Point(516, 37);
            this.picImagenDecorativa.Name = "picImagenDecorativa";
            this.picImagenDecorativa.Size = new System.Drawing.Size(191, 142);
            this.picImagenDecorativa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenDecorativa.TabIndex = 25;
            this.picImagenDecorativa.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(373, 221);
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
            this.btnAgregar.Location = new System.Drawing.Point(191, 221);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 48);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtTipoSala
            // 
            this.txtTipoSala.Location = new System.Drawing.Point(290, 107);
            this.txtTipoSala.Name = "txtTipoSala";
            this.txtTipoSala.ReadOnly = true;
            this.txtTipoSala.Size = new System.Drawing.Size(176, 28);
            this.txtTipoSala.TabIndex = 1;
            // 
            // lblTipoSala
            // 
            this.lblTipoSala.AutoSize = true;
            this.lblTipoSala.Location = new System.Drawing.Point(32, 106);
            this.lblTipoSala.Name = "lblTipoSala";
            this.lblTipoSala.Size = new System.Drawing.Size(134, 24);
            this.lblTipoSala.TabIndex = 0;
            this.lblTipoSala.Text = "Tipo de Sala:";
            // 
            // frmEliminarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 327);
            this.Controls.Add(this.grpEliminarSala);
            this.Name = "frmEliminarSala";
            this.Text = "Eliminar Sala";
            this.grpEliminarSala.ResumeLayout(false);
            this.grpEliminarSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenDecorativa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEliminarSala;
        private System.Windows.Forms.ComboBox cmbIDSala;
        private System.Windows.Forms.Label lblIDSala;
        private System.Windows.Forms.PictureBox picImagenDecorativa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTipoSala;
        private System.Windows.Forms.Label lblTipoSala;
    }
}