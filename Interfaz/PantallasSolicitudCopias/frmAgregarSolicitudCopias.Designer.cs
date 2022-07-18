
namespace Interfaz
{
    partial class frmAgregarSolicitudCopias
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
            this.grpSolicitudCopias = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.picIlustrativa = new System.Windows.Forms.PictureBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCantPaginas = new System.Windows.Forms.TextBox();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.cmbLibroSolicita = new System.Windows.Forms.ComboBox();
            this.lblLibro = new System.Windows.Forms.Label();
            this.cmbUsuarioSolicita = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpSolicitudCopias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIlustrativa)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSolicitudCopias
            // 
            this.grpSolicitudCopias.Controls.Add(this.btnCancelar);
            this.grpSolicitudCopias.Controls.Add(this.btnAgregar);
            this.grpSolicitudCopias.Controls.Add(this.picIlustrativa);
            this.grpSolicitudCopias.Controls.Add(this.cmbEstado);
            this.grpSolicitudCopias.Controls.Add(this.lblEstado);
            this.grpSolicitudCopias.Controls.Add(this.txtCantPaginas);
            this.grpSolicitudCopias.Controls.Add(this.lblPaginas);
            this.grpSolicitudCopias.Controls.Add(this.cmbLibroSolicita);
            this.grpSolicitudCopias.Controls.Add(this.lblLibro);
            this.grpSolicitudCopias.Controls.Add(this.cmbUsuarioSolicita);
            this.grpSolicitudCopias.Controls.Add(this.lblUsuario);
            this.grpSolicitudCopias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSolicitudCopias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSolicitudCopias.Location = new System.Drawing.Point(0, 0);
            this.grpSolicitudCopias.Name = "grpSolicitudCopias";
            this.grpSolicitudCopias.Size = new System.Drawing.Size(734, 450);
            this.grpSolicitudCopias.TabIndex = 0;
            this.grpSolicitudCopias.TabStop = false;
            this.grpSolicitudCopias.Text = "Nueva Solicitud Copias";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(358, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(176, 356);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 48);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // picIlustrativa
            // 
            this.picIlustrativa.Image = global::Interfaz.Properties.Resources.photocopier;
            this.picIlustrativa.Location = new System.Drawing.Point(517, 58);
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
            this.cmbEstado.Location = new System.Drawing.Point(288, 265);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(169, 28);
            this.cmbEstado.TabIndex = 7;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(62, 265);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 20);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCantPaginas
            // 
            this.txtCantPaginas.Location = new System.Drawing.Point(385, 196);
            this.txtCantPaginas.Name = "txtCantPaginas";
            this.txtCantPaginas.Size = new System.Drawing.Size(71, 27);
            this.txtCantPaginas.TabIndex = 5;
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Location = new System.Drawing.Point(62, 199);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(162, 20);
            this.lblPaginas.TabIndex = 4;
            this.lblPaginas.Text = "Cantidad Paginas:";
            // 
            // cmbLibroSolicita
            // 
            this.cmbLibroSolicita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibroSolicita.FormattingEnabled = true;
            this.cmbLibroSolicita.Location = new System.Drawing.Point(288, 127);
            this.cmbLibroSolicita.Name = "cmbLibroSolicita";
            this.cmbLibroSolicita.Size = new System.Drawing.Size(169, 28);
            this.cmbLibroSolicita.TabIndex = 3;
            this.cmbLibroSolicita.SelectedIndexChanged += new System.EventHandler(this.cmbLibroSolicita_SelectedIndexChanged);
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(62, 127);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(135, 20);
            this.lblLibro.TabIndex = 2;
            this.lblLibro.Text = "Libro a Copiar:";
            // 
            // cmbUsuarioSolicita
            // 
            this.cmbUsuarioSolicita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioSolicita.FormattingEnabled = true;
            this.cmbUsuarioSolicita.Location = new System.Drawing.Point(288, 58);
            this.cmbUsuarioSolicita.Name = "cmbUsuarioSolicita";
            this.cmbUsuarioSolicita.Size = new System.Drawing.Size(169, 28);
            this.cmbUsuarioSolicita.TabIndex = 1;
            this.cmbUsuarioSolicita.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarioSolicita_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(62, 58);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(183, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario que solicita:";
            // 
            // frmAgregarSolicitudCopias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.grpSolicitudCopias);
            this.Name = "frmAgregarSolicitudCopias";
            this.Text = "Agregar Solicitud Copias";
            this.Load += new System.EventHandler(this.frmAgregarSolicitudCopias_Load);
            this.grpSolicitudCopias.ResumeLayout(false);
            this.grpSolicitudCopias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIlustrativa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSolicitudCopias;
        private System.Windows.Forms.PictureBox picIlustrativa;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCantPaginas;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.ComboBox cmbLibroSolicita;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox cmbUsuarioSolicita;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
    }
}