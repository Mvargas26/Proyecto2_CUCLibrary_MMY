
namespace Interfaz.PantallasSalasEstudio
{
    partial class frmVerSala
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
            this.dgvVerSala = new System.Windows.Forms.DataGridView();
            this.grpVerSala = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSalaBuscarNombre = new System.Windows.Forms.Label();
            this.txtAutorNombre = new System.Windows.Forms.TextBox();
            this.lblBuscarSalaID = new System.Windows.Forms.Label();
            this.txtSalaID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerSala)).BeginInit();
            this.grpVerSala.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerSala
            // 
            this.dgvVerSala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerSala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerSala.Location = new System.Drawing.Point(0, 163);
            this.dgvVerSala.Name = "dgvVerSala";
            this.dgvVerSala.ReadOnly = true;
            this.dgvVerSala.RowHeadersWidth = 51;
            this.dgvVerSala.RowTemplate.Height = 24;
            this.dgvVerSala.Size = new System.Drawing.Size(1012, 488);
            this.dgvVerSala.TabIndex = 6;
            // 
            // grpVerSala
            // 
            this.grpVerSala.Controls.Add(this.btnLimpiarCampos);
            this.grpVerSala.Controls.Add(this.btnBuscar);
            this.grpVerSala.Controls.Add(this.lblSalaBuscarNombre);
            this.grpVerSala.Controls.Add(this.txtAutorNombre);
            this.grpVerSala.Controls.Add(this.lblBuscarSalaID);
            this.grpVerSala.Controls.Add(this.txtSalaID);
            this.grpVerSala.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpVerSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerSala.Location = new System.Drawing.Point(0, 0);
            this.grpVerSala.Name = "grpVerSala";
            this.grpVerSala.Size = new System.Drawing.Size(1012, 163);
            this.grpVerSala.TabIndex = 5;
            this.grpVerSala.TabStop = false;
            this.grpVerSala.Text = "Buscar Sala";
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
            // lblSalaBuscarNombre
            // 
            this.lblSalaBuscarNombre.AutoSize = true;
            this.lblSalaBuscarNombre.Location = new System.Drawing.Point(47, 83);
            this.lblSalaBuscarNombre.Name = "lblSalaBuscarNombre";
            this.lblSalaBuscarNombre.Size = new System.Drawing.Size(222, 20);
            this.lblSalaBuscarNombre.TabIndex = 3;
            this.lblSalaBuscarNombre.Text = "Buscar Sala por Nombre:";
            // 
            // txtAutorNombre
            // 
            this.txtAutorNombre.Location = new System.Drawing.Point(346, 84);
            this.txtAutorNombre.Name = "txtAutorNombre";
            this.txtAutorNombre.Size = new System.Drawing.Size(189, 27);
            this.txtAutorNombre.TabIndex = 2;
            // 
            // lblBuscarSalaID
            // 
            this.lblBuscarSalaID.AutoSize = true;
            this.lblBuscarSalaID.Location = new System.Drawing.Point(47, 39);
            this.lblBuscarSalaID.Name = "lblBuscarSalaID";
            this.lblBuscarSalaID.Size = new System.Drawing.Size(176, 20);
            this.lblBuscarSalaID.TabIndex = 1;
            this.lblBuscarSalaID.Text = "Buscar Sala por ID:";
            // 
            // txtSalaID
            // 
            this.txtSalaID.Location = new System.Drawing.Point(346, 35);
            this.txtSalaID.Name = "txtSalaID";
            this.txtSalaID.Size = new System.Drawing.Size(189, 27);
            this.txtSalaID.TabIndex = 0;
            // 
            // frmVerSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 651);
            this.Controls.Add(this.dgvVerSala);
            this.Controls.Add(this.grpVerSala);
            this.Name = "frmVerSala";
            this.Text = "Ver Sala";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerSala)).EndInit();
            this.grpVerSala.ResumeLayout(false);
            this.grpVerSala.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerSala;
        private System.Windows.Forms.GroupBox grpVerSala;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSalaBuscarNombre;
        private System.Windows.Forms.TextBox txtAutorNombre;
        private System.Windows.Forms.Label lblBuscarSalaID;
        private System.Windows.Forms.TextBox txtSalaID;
    }
}