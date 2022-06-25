
namespace Interfaz.PantallasSalasEstudio
{
    partial class frmModificarSala
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
            this.grpModificarSala = new System.Windows.Forms.GroupBox();
            this.cmEstado = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblLugarOrigen = new System.Windows.Forms.Label();
            this.txtTipoSala = new System.Windows.Forms.TextBox();
            this.lblTipoSala = new System.Windows.Forms.Label();
            this.lblIDSala = new System.Windows.Forms.Label();
            this.cmbIDSala = new System.Windows.Forms.ComboBox();
            this.picImagenDecorativa = new System.Windows.Forms.PictureBox();
            this.grpModificarSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenDecorativa)).BeginInit();
            this.SuspendLayout();
            // 
            // grpModificarSala
            // 
            this.grpModificarSala.Controls.Add(this.cmbIDSala);
            this.grpModificarSala.Controls.Add(this.lblIDSala);
            this.grpModificarSala.Controls.Add(this.cmEstado);
            this.grpModificarSala.Controls.Add(this.picImagenDecorativa);
            this.grpModificarSala.Controls.Add(this.btnCancelar);
            this.grpModificarSala.Controls.Add(this.btnAgregar);
            this.grpModificarSala.Controls.Add(this.lblLugarOrigen);
            this.grpModificarSala.Controls.Add(this.txtTipoSala);
            this.grpModificarSala.Controls.Add(this.lblTipoSala);
            this.grpModificarSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpModificarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModificarSala.Location = new System.Drawing.Point(0, 0);
            this.grpModificarSala.Name = "grpModificarSala";
            this.grpModificarSala.Size = new System.Drawing.Size(729, 373);
            this.grpModificarSala.TabIndex = 3;
            this.grpModificarSala.TabStop = false;
            this.grpModificarSala.Text = "Modificar Sala";
            // 
            // cmEstado
            // 
            this.cmEstado.FormattingEnabled = true;
            this.cmEstado.Items.AddRange(new object[] {
            "Ocupada",
            "Libre"});
            this.cmEstado.Location = new System.Drawing.Point(290, 165);
            this.cmEstado.Name = "cmEstado";
            this.cmEstado.Size = new System.Drawing.Size(176, 30);
            this.cmEstado.TabIndex = 26;
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
            // lblLugarOrigen
            // 
            this.lblLugarOrigen.AutoSize = true;
            this.lblLugarOrigen.Location = new System.Drawing.Point(32, 171);
            this.lblLugarOrigen.Name = "lblLugarOrigen";
            this.lblLugarOrigen.Size = new System.Drawing.Size(80, 24);
            this.lblLugarOrigen.TabIndex = 2;
            this.lblLugarOrigen.Text = "Estado:";
            // 
            // txtTipoSala
            // 
            this.txtTipoSala.Location = new System.Drawing.Point(290, 107);
            this.txtTipoSala.Name = "txtTipoSala";
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
            // lblIDSala
            // 
            this.lblIDSala.AutoSize = true;
            this.lblIDSala.Location = new System.Drawing.Point(32, 57);
            this.lblIDSala.Name = "lblIDSala";
            this.lblIDSala.Size = new System.Drawing.Size(133, 24);
            this.lblIDSala.TabIndex = 27;
            this.lblIDSala.Text = "ID de la Sala:";
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
            // picImagenDecorativa
            // 
            this.picImagenDecorativa.Image = global::Interfaz.Properties.Resources.sala2;
            this.picImagenDecorativa.InitialImage = global::Interfaz.Properties.Resources.room;
            this.picImagenDecorativa.Location = new System.Drawing.Point(526, 57);
            this.picImagenDecorativa.Name = "picImagenDecorativa";
            this.picImagenDecorativa.Size = new System.Drawing.Size(162, 180);
            this.picImagenDecorativa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenDecorativa.TabIndex = 25;
            this.picImagenDecorativa.TabStop = false;
            // 
            // frmModificarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 373);
            this.Controls.Add(this.grpModificarSala);
            this.Name = "frmModificarSala";
            this.Text = "Modificar Sala";
            this.grpModificarSala.ResumeLayout(false);
            this.grpModificarSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenDecorativa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModificarSala;
        private System.Windows.Forms.ComboBox cmEstado;
        private System.Windows.Forms.PictureBox picImagenDecorativa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblLugarOrigen;
        private System.Windows.Forms.TextBox txtTipoSala;
        private System.Windows.Forms.Label lblTipoSala;
        private System.Windows.Forms.ComboBox cmbIDSala;
        private System.Windows.Forms.Label lblIDSala;
    }
}