
namespace Interfaz.PantallasSolicitudCopias
{
    partial class frmModificarSolicitudCopias
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
            this.grpModificarSolicitudCopias = new System.Windows.Forms.GroupBox();
            this.cmbIDSolicitud = new System.Windows.Forms.ComboBox();
            this.lblIDSolicitud = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.picIlustrativa = new System.Windows.Forms.PictureBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpModificarSolicitudCopias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIlustrativa)).BeginInit();
            this.SuspendLayout();
            // 
            // grpModificarSolicitudCopias
            // 
            this.grpModificarSolicitudCopias.Controls.Add(this.cmbIDSolicitud);
            this.grpModificarSolicitudCopias.Controls.Add(this.lblIDSolicitud);
            this.grpModificarSolicitudCopias.Controls.Add(this.btnCancelar);
            this.grpModificarSolicitudCopias.Controls.Add(this.btnModificar);
            this.grpModificarSolicitudCopias.Controls.Add(this.picIlustrativa);
            this.grpModificarSolicitudCopias.Controls.Add(this.cmbEstado);
            this.grpModificarSolicitudCopias.Controls.Add(this.lblEstado);
            this.grpModificarSolicitudCopias.Controls.Add(this.txtPaginas);
            this.grpModificarSolicitudCopias.Controls.Add(this.lblPaginas);
            this.grpModificarSolicitudCopias.Controls.Add(this.cmbLibro);
            this.grpModificarSolicitudCopias.Controls.Add(this.lblLibro);
            this.grpModificarSolicitudCopias.Controls.Add(this.cmbUsuario);
            this.grpModificarSolicitudCopias.Controls.Add(this.lblUsuario);
            this.grpModificarSolicitudCopias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpModificarSolicitudCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModificarSolicitudCopias.Location = new System.Drawing.Point(0, 0);
            this.grpModificarSolicitudCopias.Name = "grpModificarSolicitudCopias";
            this.grpModificarSolicitudCopias.Size = new System.Drawing.Size(714, 450);
            this.grpModificarSolicitudCopias.TabIndex = 1;
            this.grpModificarSolicitudCopias.TabStop = false;
            this.grpModificarSolicitudCopias.Text = "Modificar Solicitud";
            // 
            // cmbIDSolicitud
            // 
            this.cmbIDSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDSolicitud.FormattingEnabled = true;
            this.cmbIDSolicitud.Location = new System.Drawing.Point(261, 40);
            this.cmbIDSolicitud.Name = "cmbIDSolicitud";
            this.cmbIDSolicitud.Size = new System.Drawing.Size(169, 28);
            this.cmbIDSolicitud.TabIndex = 28;
            this.cmbIDSolicitud.SelectedIndexChanged += new System.EventHandler(this.cmbIDSolicitud_SelectedIndexChanged);
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
            this.btnCancelar.Location = new System.Drawing.Point(358, 371);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnModificar.Location = new System.Drawing.Point(176, 371);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 48);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // picIlustrativa
            // 
            this.picIlustrativa.Image = global::Interfaz.Properties.Resources.photocopier2;
            this.picIlustrativa.Location = new System.Drawing.Point(490, 91);
            this.picIlustrativa.Name = "picIlustrativa";
            this.picIlustrativa.Size = new System.Drawing.Size(181, 175);
            this.picIlustrativa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIlustrativa.TabIndex = 8;
            this.picIlustrativa.TabStop = false;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Finalizada",
            "Pendiente"});
            this.cmbEstado.Location = new System.Drawing.Point(261, 298);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(169, 28);
            this.cmbEstado.TabIndex = 7;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(35, 298);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 20);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(358, 229);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(71, 27);
            this.txtPaginas.TabIndex = 5;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(35, 232);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(82, 20);
            this.lblPaginas.TabIndex = 4;
            this.lblPaginas.Text = "Paginas:";
            // 
            // cmbLibro
            // 
            this.cmbLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(261, 160);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(169, 28);
            this.cmbLibro.TabIndex = 3;
            this.cmbLibro.SelectedIndexChanged += new System.EventHandler(this.cmbLibro_SelectedIndexChanged);
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(35, 160);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(135, 20);
            this.lblLibro.TabIndex = 2;
            this.lblLibro.Text = "Libro a Copiar:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(261, 91);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(169, 28);
            this.cmbUsuario.TabIndex = 1;
            this.cmbUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbUsuario_SelectedIndexChanged);
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
            // frmModificarSolicitudCopias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.grpModificarSolicitudCopias);
            this.Name = "frmModificarSolicitudCopias";
            this.Text = "Modificar Solicitud Copias";
            this.Load += new System.EventHandler(this.frmModificarSolicitudCopias_Load);
            this.grpModificarSolicitudCopias.ResumeLayout(false);
            this.grpModificarSolicitudCopias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIlustrativa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModificarSolicitudCopias;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.PictureBox picIlustrativa;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbIDSolicitud;
        private System.Windows.Forms.Label lblIDSolicitud;
    }
}