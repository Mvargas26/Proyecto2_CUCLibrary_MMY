
namespace Interfaz.PantallasSalasEstudio
{
    partial class frmAgregarSala
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
            this.grpAgregarSala = new System.Windows.Forms.GroupBox();
            this.cmEstado = new System.Windows.Forms.ComboBox();
            this.picImagenDecorativa = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblLugarOrigen = new System.Windows.Forms.Label();
            this.txtTipoSala = new System.Windows.Forms.TextBox();
            this.lblTipoSala = new System.Windows.Forms.Label();
            this.grpAgregarSala.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenDecorativa)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgregarSala
            // 
            this.grpAgregarSala.Controls.Add(this.cmEstado);
            this.grpAgregarSala.Controls.Add(this.picImagenDecorativa);
            this.grpAgregarSala.Controls.Add(this.btnCancelar);
            this.grpAgregarSala.Controls.Add(this.btnAgregar);
            this.grpAgregarSala.Controls.Add(this.lblLugarOrigen);
            this.grpAgregarSala.Controls.Add(this.txtTipoSala);
            this.grpAgregarSala.Controls.Add(this.lblTipoSala);
            this.grpAgregarSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAgregarSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgregarSala.Location = new System.Drawing.Point(0, 0);
            this.grpAgregarSala.Name = "grpAgregarSala";
            this.grpAgregarSala.Size = new System.Drawing.Size(737, 370);
            this.grpAgregarSala.TabIndex = 2;
            this.grpAgregarSala.TabStop = false;
            this.grpAgregarSala.Text = "Nueva Sala";
            // 
            // cmEstado
            // 
            this.cmEstado.FormattingEnabled = true;
            this.cmEstado.Items.AddRange(new object[] {
            "Libre",
            "Ocupada"});
            this.cmEstado.Location = new System.Drawing.Point(290, 165);
            this.cmEstado.Name = "cmEstado";
            this.cmEstado.Size = new System.Drawing.Size(176, 30);
            this.cmEstado.TabIndex = 26;
            // 
            // picImagenDecorativa
            // 
            this.picImagenDecorativa.Image = global::Interfaz.Properties.Resources.room;
            this.picImagenDecorativa.InitialImage = global::Interfaz.Properties.Resources.room;
            this.picImagenDecorativa.Location = new System.Drawing.Point(526, 57);
            this.picImagenDecorativa.Name = "picImagenDecorativa";
            this.picImagenDecorativa.Size = new System.Drawing.Size(162, 180);
            this.picImagenDecorativa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenDecorativa.TabIndex = 25;
            this.picImagenDecorativa.TabStop = false;
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
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.txtTipoSala.Location = new System.Drawing.Point(290, 68);
            this.txtTipoSala.Name = "txtTipoSala";
            this.txtTipoSala.Size = new System.Drawing.Size(176, 28);
            this.txtTipoSala.TabIndex = 1;
            // 
            // lblTipoSala
            // 
            this.lblTipoSala.AutoSize = true;
            this.lblTipoSala.Location = new System.Drawing.Point(32, 67);
            this.lblTipoSala.Name = "lblTipoSala";
            this.lblTipoSala.Size = new System.Drawing.Size(134, 24);
            this.lblTipoSala.TabIndex = 0;
            this.lblTipoSala.Text = "Tipo de Sala:";
            // 
            // frmAgregarSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 370);
            this.Controls.Add(this.grpAgregarSala);
            this.Name = "frmAgregarSala";
            this.Text = "Agregar Sala";
            this.grpAgregarSala.ResumeLayout(false);
            this.grpAgregarSala.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenDecorativa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregarSala;
        private System.Windows.Forms.ComboBox cmEstado;
        private System.Windows.Forms.PictureBox picImagenDecorativa;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblLugarOrigen;
        private System.Windows.Forms.TextBox txtTipoSala;
        private System.Windows.Forms.Label lblTipoSala;
    }
}