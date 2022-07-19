
namespace Interfaz
{
    partial class frmConsultasExtra
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
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.grpVerlibro = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.lblSelecConsulta = new System.Windows.Forms.Label();
            this.cmbConsultas = new System.Windows.Forms.ComboBox();
            this.txtLeyenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.grpVerlibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultas.Location = new System.Drawing.Point(0, 207);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.RowTemplate.Height = 24;
            this.dgvConsultas.Size = new System.Drawing.Size(1012, 243);
            this.dgvConsultas.TabIndex = 3;
            // 
            // grpVerlibro
            // 
            this.grpVerlibro.Controls.Add(this.txtLeyenda);
            this.grpVerlibro.Controls.Add(this.cmbConsultas);
            this.grpVerlibro.Controls.Add(this.btnLimpiarCampos);
            this.grpVerlibro.Controls.Add(this.lblSelecConsulta);
            this.grpVerlibro.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpVerlibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerlibro.Location = new System.Drawing.Point(0, 0);
            this.grpVerlibro.Name = "grpVerlibro";
            this.grpVerlibro.Size = new System.Drawing.Size(1012, 207);
            this.grpVerlibro.TabIndex = 2;
            this.grpVerlibro.TabStop = false;
            this.grpVerlibro.Text = "Buscar Libro";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.ForeColor = System.Drawing.Color.Navy;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(561, 31);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(177, 36);
            this.btnLimpiarCampos.TabIndex = 5;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblSelecConsulta
            // 
            this.lblSelecConsulta.AutoSize = true;
            this.lblSelecConsulta.Location = new System.Drawing.Point(70, 47);
            this.lblSelecConsulta.Name = "lblSelecConsulta";
            this.lblSelecConsulta.Size = new System.Drawing.Size(208, 20);
            this.lblSelecConsulta.TabIndex = 1;
            this.lblSelecConsulta.Text = "Seleccione la Consulta:\r\n";
            // 
            // cmbConsultas
            // 
            this.cmbConsultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultas.FormattingEnabled = true;
            this.cmbConsultas.Items.AddRange(new object[] {
            "Consulta 1",
            "Consulta 2",
            "Consulta 3",
            "Consulta 4",
            "Consulta 5",
            "Consulta 6"});
            this.cmbConsultas.Location = new System.Drawing.Point(336, 39);
            this.cmbConsultas.Name = "cmbConsultas";
            this.cmbConsultas.Size = new System.Drawing.Size(176, 28);
            this.cmbConsultas.TabIndex = 6;
            this.cmbConsultas.SelectedIndexChanged += new System.EventHandler(this.cmbConsultas_SelectedIndexChanged);
            // 
            // txtLeyenda
            // 
            this.txtLeyenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtLeyenda.Location = new System.Drawing.Point(51, 89);
            this.txtLeyenda.Multiline = true;
            this.txtLeyenda.Name = "txtLeyenda";
            this.txtLeyenda.ReadOnly = true;
            this.txtLeyenda.Size = new System.Drawing.Size(888, 92);
            this.txtLeyenda.TabIndex = 8;
            // 
            // frmConsultasExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 450);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.grpVerlibro);
            this.Name = "frmConsultasExtra";
            this.Text = "Consultas Extra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.grpVerlibro.ResumeLayout(false);
            this.grpVerlibro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.GroupBox grpVerlibro;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Label lblSelecConsulta;
        private System.Windows.Forms.ComboBox cmbConsultas;
        private System.Windows.Forms.TextBox txtLeyenda;
    }
}