
namespace Interfaz
{
    partial class frmLoginModAdmin
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.chkPassword = new System.Windows.Forms.CheckBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtPasswordConsultar = new System.Windows.Forms.TextBox();
            this.lblPasword = new System.Windows.Forms.Label();
            this.txtUsuarioConsultar = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.grpLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.chkPassword);
            this.grpLogin.Controls.Add(this.btnEntrar);
            this.grpLogin.Controls.Add(this.txtPasswordConsultar);
            this.grpLogin.Controls.Add(this.lblPasword);
            this.grpLogin.Controls.Add(this.txtUsuarioConsultar);
            this.grpLogin.Controls.Add(this.lblUsuario);
            this.grpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.Location = new System.Drawing.Point(0, 0);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(648, 322);
            this.grpLogin.TabIndex = 1;
            this.grpLogin.TabStop = false;
            // 
            // chkPassword
            // 
            this.chkPassword.AutoSize = true;
            this.chkPassword.Location = new System.Drawing.Point(521, 125);
            this.chkPassword.Name = "chkPassword";
            this.chkPassword.Size = new System.Drawing.Size(106, 28);
            this.chkPassword.TabIndex = 11;
            this.chkPassword.Text = "Mostrar";
            this.chkPassword.UseVisualStyleBackColor = true;
            this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(218, 208);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(203, 57);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtPasswordConsultar
            // 
            this.txtPasswordConsultar.Location = new System.Drawing.Point(265, 123);
            this.txtPasswordConsultar.Name = "txtPasswordConsultar";
            this.txtPasswordConsultar.Size = new System.Drawing.Size(238, 30);
            this.txtPasswordConsultar.TabIndex = 3;
            this.txtPasswordConsultar.UseSystemPasswordChar = true;
            // 
            // lblPasword
            // 
            this.lblPasword.AutoSize = true;
            this.lblPasword.Location = new System.Drawing.Point(31, 123);
            this.lblPasword.Name = "lblPasword";
            this.lblPasword.Size = new System.Drawing.Size(204, 24);
            this.lblPasword.TabIndex = 2;
            this.lblPasword.Text = "Ingrese su Pasword:";
            // 
            // txtUsuarioConsultar
            // 
            this.txtUsuarioConsultar.Location = new System.Drawing.Point(265, 53);
            this.txtUsuarioConsultar.Name = "txtUsuarioConsultar";
            this.txtUsuarioConsultar.Size = new System.Drawing.Size(238, 30);
            this.txtUsuarioConsultar.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(31, 53);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(193, 24);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Ingrese su usuario:";
            // 
            // frmLoginModAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 322);
            this.ControlBox = false;
            this.Controls.Add(this.grpLogin);
            this.Name = "frmLoginModAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLoginModAdmin_Load);
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.CheckBox chkPassword;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtPasswordConsultar;
        private System.Windows.Forms.Label lblPasword;
        private System.Windows.Forms.TextBox txtUsuarioConsultar;
        private System.Windows.Forms.Label lblUsuario;
    }
}