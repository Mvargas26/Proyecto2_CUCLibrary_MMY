
namespace Interfaz.PantallasReservas
{
    partial class frmVerReservas
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
            this.dgvVerReservas = new System.Windows.Forms.DataGridView();
            this.grpVerReservas = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarReservaNombre = new System.Windows.Forms.Label();
            this.txtReservaNombre = new System.Windows.Forms.TextBox();
            this.lblBuscarReservaID = new System.Windows.Forms.Label();
            this.txtReservaId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerReservas)).BeginInit();
            this.grpVerReservas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerReservas
            // 
            this.dgvVerReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerReservas.Location = new System.Drawing.Point(0, 163);
            this.dgvVerReservas.Name = "dgvVerReservas";
            this.dgvVerReservas.ReadOnly = true;
            this.dgvVerReservas.RowHeadersWidth = 51;
            this.dgvVerReservas.RowTemplate.Height = 24;
            this.dgvVerReservas.Size = new System.Drawing.Size(956, 287);
            this.dgvVerReservas.TabIndex = 3;
            // 
            // grpVerReservas
            // 
            this.grpVerReservas.Controls.Add(this.btnLimpiarCampos);
            this.grpVerReservas.Controls.Add(this.btnBuscar);
            this.grpVerReservas.Controls.Add(this.lblBuscarReservaNombre);
            this.grpVerReservas.Controls.Add(this.txtReservaNombre);
            this.grpVerReservas.Controls.Add(this.lblBuscarReservaID);
            this.grpVerReservas.Controls.Add(this.txtReservaId);
            this.grpVerReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpVerReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerReservas.Location = new System.Drawing.Point(0, 0);
            this.grpVerReservas.Name = "grpVerReservas";
            this.grpVerReservas.Size = new System.Drawing.Size(956, 163);
            this.grpVerReservas.TabIndex = 2;
            this.grpVerReservas.TabStop = false;
            this.grpVerReservas.Text = "Ver Reservas";
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
            // lblBuscarReservaNombre
            // 
            this.lblBuscarReservaNombre.AutoSize = true;
            this.lblBuscarReservaNombre.Location = new System.Drawing.Point(47, 83);
            this.lblBuscarReservaNombre.Name = "lblBuscarReservaNombre";
            this.lblBuscarReservaNombre.Size = new System.Drawing.Size(228, 20);
            this.lblBuscarReservaNombre.TabIndex = 3;
            this.lblBuscarReservaNombre.Text = "Buscar Libro por Nombre:";
            // 
            // txtReservaNombre
            // 
            this.txtReservaNombre.Location = new System.Drawing.Point(346, 84);
            this.txtReservaNombre.Name = "txtReservaNombre";
            this.txtReservaNombre.Size = new System.Drawing.Size(189, 27);
            this.txtReservaNombre.TabIndex = 2;
            // 
            // lblBuscarReservaID
            // 
            this.lblBuscarReservaID.AutoSize = true;
            this.lblBuscarReservaID.Location = new System.Drawing.Point(47, 39);
            this.lblBuscarReservaID.Name = "lblBuscarReservaID";
            this.lblBuscarReservaID.Size = new System.Drawing.Size(208, 20);
            this.lblBuscarReservaID.TabIndex = 1;
            this.lblBuscarReservaID.Text = "Buscar Reserva por ID:";
            // 
            // txtReservaId
            // 
            this.txtReservaId.Location = new System.Drawing.Point(346, 35);
            this.txtReservaId.Name = "txtReservaId";
            this.txtReservaId.Size = new System.Drawing.Size(189, 27);
            this.txtReservaId.TabIndex = 0;
            // 
            // frmVerReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.dgvVerReservas);
            this.Controls.Add(this.grpVerReservas);
            this.Name = "frmVerReservas";
            this.Text = "Ver Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerReservas)).EndInit();
            this.grpVerReservas.ResumeLayout(false);
            this.grpVerReservas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerReservas;
        private System.Windows.Forms.GroupBox grpVerReservas;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscarReservaNombre;
        private System.Windows.Forms.TextBox txtReservaNombre;
        private System.Windows.Forms.Label lblBuscarReservaID;
        private System.Windows.Forms.TextBox txtReservaId;
    }
}