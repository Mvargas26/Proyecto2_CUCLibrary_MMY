
namespace Interfaz.PantallasAutores
{
    partial class frmVerAutores
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
            this.dgvVerLibros = new System.Windows.Forms.DataGridView();
            this.grpVerAutor = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblLibroBuscarNombre = new System.Windows.Forms.Label();
            this.txtAutorNombre = new System.Windows.Forms.TextBox();
            this.lblAutorBuscarID = new System.Windows.Forms.Label();
            this.txtAutorID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerLibros)).BeginInit();
            this.grpVerAutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerLibros
            // 
            this.dgvVerLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerLibros.Location = new System.Drawing.Point(0, 163);
            this.dgvVerLibros.Name = "dgvVerLibros";
            this.dgvVerLibros.ReadOnly = true;
            this.dgvVerLibros.RowHeadersWidth = 51;
            this.dgvVerLibros.RowTemplate.Height = 24;
            this.dgvVerLibros.Size = new System.Drawing.Size(919, 287);
            this.dgvVerLibros.TabIndex = 3;
            // 
            // grpVerAutor
            // 
            this.grpVerAutor.Controls.Add(this.btnLimpiarCampos);
            this.grpVerAutor.Controls.Add(this.btnBuscar);
            this.grpVerAutor.Controls.Add(this.lblLibroBuscarNombre);
            this.grpVerAutor.Controls.Add(this.txtAutorNombre);
            this.grpVerAutor.Controls.Add(this.lblAutorBuscarID);
            this.grpVerAutor.Controls.Add(this.txtAutorID);
            this.grpVerAutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpVerAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerAutor.Location = new System.Drawing.Point(0, 0);
            this.grpVerAutor.Name = "grpVerAutor";
            this.grpVerAutor.Size = new System.Drawing.Size(919, 163);
            this.grpVerAutor.TabIndex = 2;
            this.grpVerAutor.TabStop = false;
            this.grpVerAutor.Text = "Buscar Autor";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.Navy;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(743, 51);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(121, 63);
            this.btnLimpiarCampos.TabIndex = 5;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscar.Location = new System.Drawing.Point(590, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 63);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblLibroBuscarNombre
            // 
            this.lblLibroBuscarNombre.AutoSize = true;
            this.lblLibroBuscarNombre.Location = new System.Drawing.Point(47, 83);
            this.lblLibroBuscarNombre.Name = "lblLibroBuscarNombre";
            this.lblLibroBuscarNombre.Size = new System.Drawing.Size(230, 20);
            this.lblLibroBuscarNombre.TabIndex = 3;
            this.lblLibroBuscarNombre.Text = "Buscar Autor por Nombre:";
            // 
            // txtAutorNombre
            // 
            this.txtAutorNombre.Location = new System.Drawing.Point(346, 84);
            this.txtAutorNombre.Name = "txtAutorNombre";
            this.txtAutorNombre.Size = new System.Drawing.Size(189, 27);
            this.txtAutorNombre.TabIndex = 2;
            // 
            // lblAutorBuscarID
            // 
            this.lblAutorBuscarID.AutoSize = true;
            this.lblAutorBuscarID.Location = new System.Drawing.Point(47, 39);
            this.lblAutorBuscarID.Name = "lblAutorBuscarID";
            this.lblAutorBuscarID.Size = new System.Drawing.Size(184, 20);
            this.lblAutorBuscarID.TabIndex = 1;
            this.lblAutorBuscarID.Text = "Buscar Autor por ID:";
            // 
            // txtAutorID
            // 
            this.txtAutorID.Location = new System.Drawing.Point(346, 35);
            this.txtAutorID.Name = "txtAutorID";
            this.txtAutorID.Size = new System.Drawing.Size(189, 27);
            this.txtAutorID.TabIndex = 0;
            // 
            // frmVerAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.dgvVerLibros);
            this.Controls.Add(this.grpVerAutor);
            this.Name = "frmVerAutores";
            this.Text = "Ver Autores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerLibros)).EndInit();
            this.grpVerAutor.ResumeLayout(false);
            this.grpVerAutor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerLibros;
        private System.Windows.Forms.GroupBox grpVerAutor;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblLibroBuscarNombre;
        private System.Windows.Forms.TextBox txtAutorNombre;
        private System.Windows.Forms.Label lblAutorBuscarID;
        private System.Windows.Forms.TextBox txtAutorID;
    }
}