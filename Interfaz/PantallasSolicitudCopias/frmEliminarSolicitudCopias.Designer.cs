
namespace Interfaz.PantallasSolicitudCopias
{
    partial class frmEliminarSolicitudCopias
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
            this.grpEliminarSolicitudCopias = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblIDSolicitud = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtUsuarioSolicia = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picIlustrativa = new System.Windows.Forms.PictureBox();
            this.grpEliminarSolicitudCopias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIlustrativa)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEliminarSolicitudCopias
            // 
            this.grpEliminarSolicitudCopias.Controls.Add(this.comboBox3);
            this.grpEliminarSolicitudCopias.Controls.Add(this.lblIDSolicitud);
            this.grpEliminarSolicitudCopias.Controls.Add(this.btnCancelar);
            this.grpEliminarSolicitudCopias.Controls.Add(this.btnEliminar);
            this.grpEliminarSolicitudCopias.Controls.Add(this.picIlustrativa);
            this.grpEliminarSolicitudCopias.Controls.Add(this.txtUsuarioSolicia);
            this.grpEliminarSolicitudCopias.Controls.Add(this.lblUsuario);
            this.grpEliminarSolicitudCopias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEliminarSolicitudCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarSolicitudCopias.Location = new System.Drawing.Point(0, 0);
            this.grpEliminarSolicitudCopias.Name = "grpEliminarSolicitudCopias";
            this.grpEliminarSolicitudCopias.Size = new System.Drawing.Size(546, 405);
            this.grpEliminarSolicitudCopias.TabIndex = 2;
            this.grpEliminarSolicitudCopias.TabStop = false;
            this.grpEliminarSolicitudCopias.Text = "Eliminar Solicitud";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(261, 40);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(169, 28);
            this.comboBox3.TabIndex = 28;
            // 
            // lblIDSolicitud
            // 
            this.lblIDSolicitud.AutoSize = true;
            this.lblIDSolicitud.Location = new System.Drawing.Point(35, 40);
            this.lblIDSolicitud.Name = "lblIDSolicitud";
            this.lblIDSolicitud.Size = new System.Drawing.Size(113, 20);
            this.lblIDSolicitud.TabIndex = 27;
            this.lblIDSolicitud.Text = "ID Solicitud:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(286, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnEliminar.Location = new System.Drawing.Point(104, 314);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(123, 48);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtUsuarioSolicia
            // 
            this.txtUsuarioSolicia.Location = new System.Drawing.Point(261, 91);
            this.txtUsuarioSolicia.Name = "txtUsuarioSolicia";
            this.txtUsuarioSolicia.ReadOnly = true;
            this.txtUsuarioSolicia.Size = new System.Drawing.Size(168, 27);
            this.txtUsuarioSolicia.TabIndex = 5;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(35, 91);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(183, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario que solicita:";
            // 
            // picIlustrativa
            // 
            this.picIlustrativa.Image = global::Interfaz.Properties.Resources.basurero2;
            this.picIlustrativa.Location = new System.Drawing.Point(180, 155);
            this.picIlustrativa.Name = "picIlustrativa";
            this.picIlustrativa.Size = new System.Drawing.Size(146, 126);
            this.picIlustrativa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIlustrativa.TabIndex = 8;
            this.picIlustrativa.TabStop = false;
            // 
            // frmEliminarSolicitudCopias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 405);
            this.Controls.Add(this.grpEliminarSolicitudCopias);
            this.Name = "frmEliminarSolicitudCopias";
            this.Text = "frmEliminarSolicitudCopias";
            this.grpEliminarSolicitudCopias.ResumeLayout(false);
            this.grpEliminarSolicitudCopias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIlustrativa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEliminarSolicitudCopias;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label lblIDSolicitud;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox picIlustrativa;
        private System.Windows.Forms.TextBox txtUsuarioSolicia;
        private System.Windows.Forms.Label lblUsuario;
    }
}