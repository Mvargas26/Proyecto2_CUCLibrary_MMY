
namespace Interfaz.PantallasUserBiblioteca
{
    partial class frmVerUserBiblioteca
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
            this.dgvVerusuariosBiblioteca = new System.Windows.Forms.DataGridView();
            this.grpUsuariosBiblioteca = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblUserBuscar = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUserBibliotecaBuscarID = new System.Windows.Forms.Label();
            this.txtAutorID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerusuariosBiblioteca)).BeginInit();
            this.grpUsuariosBiblioteca.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerusuariosBiblioteca
            // 
            this.dgvVerusuariosBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerusuariosBiblioteca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerusuariosBiblioteca.Location = new System.Drawing.Point(0, 163);
            this.dgvVerusuariosBiblioteca.Name = "dgvVerusuariosBiblioteca";
            this.dgvVerusuariosBiblioteca.ReadOnly = true;
            this.dgvVerusuariosBiblioteca.RowHeadersWidth = 51;
            this.dgvVerusuariosBiblioteca.RowTemplate.Height = 24;
            this.dgvVerusuariosBiblioteca.Size = new System.Drawing.Size(862, 287);
            this.dgvVerusuariosBiblioteca.TabIndex = 5;
            // 
            // grpUsuariosBiblioteca
            // 
            this.grpUsuariosBiblioteca.Controls.Add(this.btnLimpiarCampos);
            this.grpUsuariosBiblioteca.Controls.Add(this.btnBuscar);
            this.grpUsuariosBiblioteca.Controls.Add(this.lblUserBuscar);
            this.grpUsuariosBiblioteca.Controls.Add(this.txtUsuario);
            this.grpUsuariosBiblioteca.Controls.Add(this.lblUserBibliotecaBuscarID);
            this.grpUsuariosBiblioteca.Controls.Add(this.txtAutorID);
            this.grpUsuariosBiblioteca.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpUsuariosBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsuariosBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.grpUsuariosBiblioteca.Name = "grpUsuariosBiblioteca";
            this.grpUsuariosBiblioteca.Size = new System.Drawing.Size(862, 163);
            this.grpUsuariosBiblioteca.TabIndex = 4;
            this.grpUsuariosBiblioteca.TabStop = false;
            this.grpUsuariosBiblioteca.Text = "Usuarios Biblioteca";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.Navy;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(690, 50);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(121, 63);
            this.btnLimpiarCampos.TabIndex = 5;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscar.Location = new System.Drawing.Point(537, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 63);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblUserBuscar
            // 
            this.lblUserBuscar.AutoSize = true;
            this.lblUserBuscar.Location = new System.Drawing.Point(47, 83);
            this.lblUserBuscar.Name = "lblUserBuscar";
            this.lblUserBuscar.Size = new System.Drawing.Size(154, 20);
            this.lblUserBuscar.TabIndex = 3;
            this.lblUserBuscar.Text = "Buscar por User:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(293, 83);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 27);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblUserBibliotecaBuscarID
            // 
            this.lblUserBibliotecaBuscarID.AutoSize = true;
            this.lblUserBibliotecaBuscarID.Location = new System.Drawing.Point(47, 39);
            this.lblUserBibliotecaBuscarID.Name = "lblUserBibliotecaBuscarID";
            this.lblUserBibliotecaBuscarID.Size = new System.Drawing.Size(204, 20);
            this.lblUserBibliotecaBuscarID.TabIndex = 1;
            this.lblUserBibliotecaBuscarID.Text = "Buscar Usuario por ID:";
            // 
            // txtAutorID
            // 
            this.txtAutorID.Location = new System.Drawing.Point(293, 34);
            this.txtAutorID.Name = "txtAutorID";
            this.txtAutorID.Size = new System.Drawing.Size(189, 27);
            this.txtAutorID.TabIndex = 0;
            // 
            // frmVerUserBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.dgvVerusuariosBiblioteca);
            this.Controls.Add(this.grpUsuariosBiblioteca);
            this.Name = "frmVerUserBiblioteca";
            this.Text = "Ver User Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerusuariosBiblioteca)).EndInit();
            this.grpUsuariosBiblioteca.ResumeLayout(false);
            this.grpUsuariosBiblioteca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerusuariosBiblioteca;
        private System.Windows.Forms.GroupBox grpUsuariosBiblioteca;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblUserBuscar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUserBibliotecaBuscarID;
        private System.Windows.Forms.TextBox txtAutorID;
    }
}