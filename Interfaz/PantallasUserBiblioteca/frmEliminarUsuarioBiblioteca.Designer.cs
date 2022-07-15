
namespace Interfaz.PantallasUserBiblioteca
{
    partial class frmEliminarUsuarioBiblioteca
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
            this.grpEliminarUserBiblioteca = new System.Windows.Forms.GroupBox();
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbIdUserUB = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.grpEliminarUserBiblioteca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEliminarUserBiblioteca
            // 
            this.grpEliminarUserBiblioteca.Controls.Add(this.pboxImagen);
            this.grpEliminarUserBiblioteca.Controls.Add(this.btnCancelar);
            this.grpEliminarUserBiblioteca.Controls.Add(this.btnEliminar);
            this.grpEliminarUserBiblioteca.Controls.Add(this.txtUsuario);
            this.grpEliminarUserBiblioteca.Controls.Add(this.cmbIdUserUB);
            this.grpEliminarUserBiblioteca.Controls.Add(this.lblUsuario);
            this.grpEliminarUserBiblioteca.Controls.Add(this.lblIdUser);
            this.grpEliminarUserBiblioteca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEliminarUserBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarUserBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.grpEliminarUserBiblioteca.Name = "grpEliminarUserBiblioteca";
            this.grpEliminarUserBiblioteca.Size = new System.Drawing.Size(628, 327);
            this.grpEliminarUserBiblioteca.TabIndex = 2;
            this.grpEliminarUserBiblioteca.TabStop = false;
            this.grpEliminarUserBiblioteca.Text = "Eliminar Usuario Bliblioteca";
            // 
            // pboxImagen
            // 
            this.pboxImagen.Image = global::Interfaz.Properties.Resources.Basurero;
            this.pboxImagen.Location = new System.Drawing.Point(430, 54);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(151, 151);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 21;
            this.pboxImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(272, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 55);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(92, 221);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 55);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(250, 124);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(121, 27);
            this.txtUsuario.TabIndex = 3;
            // 
            // cmbIdUserUB
            // 
            this.cmbIdUserUB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdUserUB.FormattingEnabled = true;
            this.cmbIdUserUB.Location = new System.Drawing.Point(250, 68);
            this.cmbIdUserUB.Name = "cmbIdUserUB";
            this.cmbIdUserUB.Size = new System.Drawing.Size(121, 28);
            this.cmbIdUserUB.TabIndex = 2;
            this.cmbIdUserUB.SelectedIndexChanged += new System.EventHandler(this.cmbIdUserUB_SelectedIndexChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(59, 127);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(80, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Location = new System.Drawing.Point(59, 68);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(76, 20);
            this.lblIdUser.TabIndex = 0;
            this.lblIdUser.Text = "Id User:";
            // 
            // frmEliminarUsuarioBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 327);
            this.Controls.Add(this.grpEliminarUserBiblioteca);
            this.Name = "frmEliminarUsuarioBiblioteca";
            this.Text = "Eliminar Usuario Biblioteca";
            this.Load += new System.EventHandler(this.frmEliminarUsuarioBiblioteca_Load);
            this.grpEliminarUserBiblioteca.ResumeLayout(false);
            this.grpEliminarUserBiblioteca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEliminarUserBiblioteca;
        private System.Windows.Forms.PictureBox pboxImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ComboBox cmbIdUserUB;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblIdUser;
    }
}