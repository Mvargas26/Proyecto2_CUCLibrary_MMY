
namespace Interfaz.PantallasEditoriales
{
    partial class frmVerEditoriales
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
            this.grpVerEditoriales = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblEditorialBuscarNombre = new System.Windows.Forms.Label();
            this.txtEditorialNombre = new System.Windows.Forms.TextBox();
            this.lblEditorialBuscarID = new System.Windows.Forms.Label();
            this.txtEditorialID = new System.Windows.Forms.TextBox();
            this.dgvVerEditoriales = new System.Windows.Forms.DataGridView();
            this.grpVerEditoriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEditoriales)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVerEditoriales
            // 
            this.grpVerEditoriales.Controls.Add(this.btnLimpiarCampos);
            this.grpVerEditoriales.Controls.Add(this.btnBuscar);
            this.grpVerEditoriales.Controls.Add(this.lblEditorialBuscarNombre);
            this.grpVerEditoriales.Controls.Add(this.txtEditorialNombre);
            this.grpVerEditoriales.Controls.Add(this.lblEditorialBuscarID);
            this.grpVerEditoriales.Controls.Add(this.txtEditorialID);
            this.grpVerEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpVerEditoriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerEditoriales.Location = new System.Drawing.Point(0, 0);
            this.grpVerEditoriales.Name = "grpVerEditoriales";
            this.grpVerEditoriales.Size = new System.Drawing.Size(934, 163);
            this.grpVerEditoriales.TabIndex = 3;
            this.grpVerEditoriales.TabStop = false;
            this.grpVerEditoriales.Text = "Buscar Editoriales";
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
            // lblEditorialBuscarNombre
            // 
            this.lblEditorialBuscarNombre.AutoSize = true;
            this.lblEditorialBuscarNombre.Location = new System.Drawing.Point(47, 83);
            this.lblEditorialBuscarNombre.Name = "lblEditorialBuscarNombre";
            this.lblEditorialBuscarNombre.Size = new System.Drawing.Size(255, 20);
            this.lblEditorialBuscarNombre.TabIndex = 3;
            this.lblEditorialBuscarNombre.Text = "Buscar Editorial por Nombre:";
            // 
            // txtEditorialNombre
            // 
            this.txtEditorialNombre.Location = new System.Drawing.Point(346, 84);
            this.txtEditorialNombre.Name = "txtEditorialNombre";
            this.txtEditorialNombre.Size = new System.Drawing.Size(189, 27);
            this.txtEditorialNombre.TabIndex = 2;
            // 
            // lblEditorialBuscarID
            // 
            this.lblEditorialBuscarID.AutoSize = true;
            this.lblEditorialBuscarID.Location = new System.Drawing.Point(47, 39);
            this.lblEditorialBuscarID.Name = "lblEditorialBuscarID";
            this.lblEditorialBuscarID.Size = new System.Drawing.Size(209, 20);
            this.lblEditorialBuscarID.TabIndex = 1;
            this.lblEditorialBuscarID.Text = "Buscar Editorial por ID:";
            // 
            // txtEditorialID
            // 
            this.txtEditorialID.Location = new System.Drawing.Point(346, 35);
            this.txtEditorialID.Name = "txtEditorialID";
            this.txtEditorialID.Size = new System.Drawing.Size(189, 27);
            this.txtEditorialID.TabIndex = 0;
            // 
            // dgvVerEditoriales
            // 
            this.dgvVerEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerEditoriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerEditoriales.Location = new System.Drawing.Point(0, 163);
            this.dgvVerEditoriales.Name = "dgvVerEditoriales";
            this.dgvVerEditoriales.ReadOnly = true;
            this.dgvVerEditoriales.RowHeadersWidth = 51;
            this.dgvVerEditoriales.RowTemplate.Height = 24;
            this.dgvVerEditoriales.Size = new System.Drawing.Size(934, 422);
            this.dgvVerEditoriales.TabIndex = 4;
            // 
            // frmVerEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 585);
            this.Controls.Add(this.dgvVerEditoriales);
            this.Controls.Add(this.grpVerEditoriales);
            this.Name = "frmVerEditoriales";
            this.Text = "Ver Editoriales";
            this.Load += new System.EventHandler(this.frmVerEditoriales_Load);
            this.grpVerEditoriales.ResumeLayout(false);
            this.grpVerEditoriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerEditoriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVerEditoriales;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblEditorialBuscarNombre;
        private System.Windows.Forms.TextBox txtEditorialNombre;
        private System.Windows.Forms.Label lblEditorialBuscarID;
        private System.Windows.Forms.TextBox txtEditorialID;
        private System.Windows.Forms.DataGridView dgvVerEditoriales;
    }
}