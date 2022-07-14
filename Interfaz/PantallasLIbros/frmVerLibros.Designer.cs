
namespace Interfaz.PantallasLIbros
{
    partial class frmVerLibros
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
            this.grpVerlibro = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblLibroBuscarNombre = new System.Windows.Forms.Label();
            this.txtLibroNombre = new System.Windows.Forms.TextBox();
            this.lblLibroBuscarID = new System.Windows.Forms.Label();
            this.txtLibroID = new System.Windows.Forms.TextBox();
            this.dgvVerLibros = new System.Windows.Forms.DataGridView();
            this.grpVerlibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVerlibro
            // 
            this.grpVerlibro.Controls.Add(this.btnLimpiarCampos);
            this.grpVerlibro.Controls.Add(this.btnBuscar);
            this.grpVerlibro.Controls.Add(this.lblLibroBuscarNombre);
            this.grpVerlibro.Controls.Add(this.txtLibroNombre);
            this.grpVerlibro.Controls.Add(this.lblLibroBuscarID);
            this.grpVerlibro.Controls.Add(this.txtLibroID);
            this.grpVerlibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpVerlibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerlibro.Location = new System.Drawing.Point(0, 0);
            this.grpVerlibro.Name = "grpVerlibro";
            this.grpVerlibro.Size = new System.Drawing.Size(928, 163);
            this.grpVerlibro.TabIndex = 0;
            this.grpVerlibro.TabStop = false;
            this.grpVerlibro.Text = "Buscar Libro";
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
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblLibroBuscarNombre
            // 
            this.lblLibroBuscarNombre.AutoSize = true;
            this.lblLibroBuscarNombre.Location = new System.Drawing.Point(47, 83);
            this.lblLibroBuscarNombre.Name = "lblLibroBuscarNombre";
            this.lblLibroBuscarNombre.Size = new System.Drawing.Size(228, 20);
            this.lblLibroBuscarNombre.TabIndex = 3;
            this.lblLibroBuscarNombre.Text = "Buscar Libro por Nombre:";
            // 
            // txtLibroNombre
            // 
            this.txtLibroNombre.Location = new System.Drawing.Point(346, 84);
            this.txtLibroNombre.Name = "txtLibroNombre";
            this.txtLibroNombre.Size = new System.Drawing.Size(189, 27);
            this.txtLibroNombre.TabIndex = 2;
            // 
            // lblLibroBuscarID
            // 
            this.lblLibroBuscarID.AutoSize = true;
            this.lblLibroBuscarID.Location = new System.Drawing.Point(47, 39);
            this.lblLibroBuscarID.Name = "lblLibroBuscarID";
            this.lblLibroBuscarID.Size = new System.Drawing.Size(182, 20);
            this.lblLibroBuscarID.TabIndex = 1;
            this.lblLibroBuscarID.Text = "Buscar Libro por ID:";
            // 
            // txtLibroID
            // 
            this.txtLibroID.Location = new System.Drawing.Point(346, 35);
            this.txtLibroID.Name = "txtLibroID";
            this.txtLibroID.Size = new System.Drawing.Size(189, 27);
            this.txtLibroID.TabIndex = 0;
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
            this.dgvVerLibros.Size = new System.Drawing.Size(928, 287);
            this.dgvVerLibros.TabIndex = 1;
            // 
            // frmVerLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.dgvVerLibros);
            this.Controls.Add(this.grpVerlibro);
            this.Name = "frmVerLibros";
            this.Text = "Ver Libros";
            this.Load += new System.EventHandler(this.frmVerLibros_Load);
            this.grpVerlibro.ResumeLayout(false);
            this.grpVerlibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVerlibro;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblLibroBuscarNombre;
        private System.Windows.Forms.TextBox txtLibroNombre;
        private System.Windows.Forms.Label lblLibroBuscarID;
        private System.Windows.Forms.TextBox txtLibroID;
        private System.Windows.Forms.DataGridView dgvVerLibros;
    }
}