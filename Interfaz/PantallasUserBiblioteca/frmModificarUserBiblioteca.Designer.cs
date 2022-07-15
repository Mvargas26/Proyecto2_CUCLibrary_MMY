
namespace Interfaz.PantallasUserBiblioteca
{
    partial class frmModificarUserBiblioteca
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
            this.grpAgregarLibro = new System.Windows.Forms.GroupBox();
            this.cmbIdUserUB = new System.Windows.Forms.ComboBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.grpAgregarLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAgregarLibro
            // 
            this.grpAgregarLibro.Controls.Add(this.txtConfirmar);
            this.grpAgregarLibro.Controls.Add(this.lblConfirmar);
            this.grpAgregarLibro.Controls.Add(this.cmbIdUserUB);
            this.grpAgregarLibro.Controls.Add(this.lblIdUsuario);
            this.grpAgregarLibro.Controls.Add(this.cmbEstado);
            this.grpAgregarLibro.Controls.Add(this.txtPassword);
            this.grpAgregarLibro.Controls.Add(this.txtUser);
            this.grpAgregarLibro.Controls.Add(this.txtApellidos);
            this.grpAgregarLibro.Controls.Add(this.txtEdad);
            this.grpAgregarLibro.Controls.Add(this.txtNombre);
            this.grpAgregarLibro.Controls.Add(this.btnCancelar);
            this.grpAgregarLibro.Controls.Add(this.btnAgregar);
            this.grpAgregarLibro.Controls.Add(this.pictureBox1);
            this.grpAgregarLibro.Controls.Add(this.lblEstado);
            this.grpAgregarLibro.Controls.Add(this.lblEdad);
            this.grpAgregarLibro.Controls.Add(this.lblPassword);
            this.grpAgregarLibro.Controls.Add(this.lblUser);
            this.grpAgregarLibro.Controls.Add(this.lblApellidos);
            this.grpAgregarLibro.Controls.Add(this.lblNombre);
            this.grpAgregarLibro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAgregarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgregarLibro.Location = new System.Drawing.Point(0, 0);
            this.grpAgregarLibro.Name = "grpAgregarLibro";
            this.grpAgregarLibro.Size = new System.Drawing.Size(784, 609);
            this.grpAgregarLibro.TabIndex = 2;
            this.grpAgregarLibro.TabStop = false;
            // 
            // cmbIdUserUB
            // 
            this.cmbIdUserUB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdUserUB.FormattingEnabled = true;
            this.cmbIdUserUB.Location = new System.Drawing.Point(250, 43);
            this.cmbIdUserUB.Name = "cmbIdUserUB";
            this.cmbIdUserUB.Size = new System.Drawing.Size(156, 28);
            this.cmbIdUserUB.TabIndex = 25;
            this.cmbIdUserUB.SelectedIndexChanged += new System.EventHandler(this.cmbIdUserUB_SelectedIndexChanged);
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(53, 43);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(105, 20);
            this.lblIdUsuario.TabIndex = 24;
            this.lblIdUsuario.Text = "ID Usuario:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(250, 448);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(156, 28);
            this.cmbEstado.TabIndex = 23;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(250, 268);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 27);
            this.txtPassword.TabIndex = 22;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(250, 210);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(156, 27);
            this.txtUser.TabIndex = 21;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(250, 163);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(156, 27);
            this.txtApellidos.TabIndex = 2;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(345, 383);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(61, 27);
            this.txtEdad.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(250, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 27);
            this.txtNombre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(395, 529);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(213, 529);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 48);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Modificar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(460, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(41, 448);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 20);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(41, 383);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(154, 20);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad (numerica):";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(41, 268);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(44, 210);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(41, 152);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(92, 20);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 99);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(250, 324);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(156, 27);
            this.txtConfirmar.TabIndex = 27;
            this.txtConfirmar.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Location = new System.Drawing.Point(41, 324);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(98, 20);
            this.lblConfirmar.TabIndex = 26;
            this.lblConfirmar.Text = "Confirmar:";
            // 
            // frmModificarUserBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 609);
            this.Controls.Add(this.grpAgregarLibro);
            this.Name = "frmModificarUserBiblioteca";
            this.Text = "Modificar User Biblioteca";
            this.Load += new System.EventHandler(this.frmModificarUserBiblioteca_Load);
            this.grpAgregarLibro.ResumeLayout(false);
            this.grpAgregarLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAgregarLibro;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbIdUserUB;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label lblConfirmar;
    }
}