
namespace Interfaz.PantallasSolicitudCopias
{
    partial class frmVerSolicitudesCopias
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
            this.dgvVerSolicitud = new System.Windows.Forms.DataGridView();
            this.grpVerSalagrpVerSolicitudes = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblSolicitudBuscarNombre = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblBuscarSolicitudID = new System.Windows.Forms.Label();
            this.txtsolicitudID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerSolicitud)).BeginInit();
            this.grpVerSalagrpVerSolicitudes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerSolicitud
            // 
            this.dgvVerSolicitud.AllowUserToAddRows = false;
            this.dgvVerSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerSolicitud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerSolicitud.Location = new System.Drawing.Point(0, 163);
            this.dgvVerSolicitud.Name = "dgvVerSolicitud";
            this.dgvVerSolicitud.ReadOnly = true;
            this.dgvVerSolicitud.RowHeadersWidth = 51;
            this.dgvVerSolicitud.RowTemplate.Height = 24;
            this.dgvVerSolicitud.Size = new System.Drawing.Size(970, 325);
            this.dgvVerSolicitud.TabIndex = 8;
            // 
            // grpVerSalagrpVerSolicitudes
            // 
            this.grpVerSalagrpVerSolicitudes.Controls.Add(this.btnLimpiarCampos);
            this.grpVerSalagrpVerSolicitudes.Controls.Add(this.btnBuscar);
            this.grpVerSalagrpVerSolicitudes.Controls.Add(this.lblSolicitudBuscarNombre);
            this.grpVerSalagrpVerSolicitudes.Controls.Add(this.txtUsuario);
            this.grpVerSalagrpVerSolicitudes.Controls.Add(this.lblBuscarSolicitudID);
            this.grpVerSalagrpVerSolicitudes.Controls.Add(this.txtsolicitudID);
            this.grpVerSalagrpVerSolicitudes.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpVerSalagrpVerSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerSalagrpVerSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.grpVerSalagrpVerSolicitudes.Name = "grpVerSalagrpVerSolicitudes";
            this.grpVerSalagrpVerSolicitudes.Size = new System.Drawing.Size(970, 163);
            this.grpVerSalagrpVerSolicitudes.TabIndex = 7;
            this.grpVerSalagrpVerSolicitudes.TabStop = false;
            this.grpVerSalagrpVerSolicitudes.Text = "Ver Solicitudes";
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
            // lblSolicitudBuscarNombre
            // 
            this.lblSolicitudBuscarNombre.AutoSize = true;
            this.lblSolicitudBuscarNombre.Location = new System.Drawing.Point(47, 83);
            this.lblSolicitudBuscarNombre.Name = "lblSolicitudBuscarNombre";
            this.lblSolicitudBuscarNombre.Size = new System.Drawing.Size(258, 20);
            this.lblSolicitudBuscarNombre.TabIndex = 3;
            this.lblSolicitudBuscarNombre.Text = "Buscar Solicitud por Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(346, 84);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 27);
            this.txtUsuario.TabIndex = 2;
            // 
            // lblBuscarSolicitudID
            // 
            this.lblBuscarSolicitudID.AutoSize = true;
            this.lblBuscarSolicitudID.Location = new System.Drawing.Point(47, 39);
            this.lblBuscarSolicitudID.Name = "lblBuscarSolicitudID";
            this.lblBuscarSolicitudID.Size = new System.Drawing.Size(212, 20);
            this.lblBuscarSolicitudID.TabIndex = 1;
            this.lblBuscarSolicitudID.Text = "Buscar Solicitud por ID:";
            // 
            // txtsolicitudID
            // 
            this.txtsolicitudID.Location = new System.Drawing.Point(346, 35);
            this.txtsolicitudID.Name = "txtsolicitudID";
            this.txtsolicitudID.Size = new System.Drawing.Size(189, 27);
            this.txtsolicitudID.TabIndex = 0;
            // 
            // frmVerSolicitudesCopias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 488);
            this.Controls.Add(this.dgvVerSolicitud);
            this.Controls.Add(this.grpVerSalagrpVerSolicitudes);
            this.Name = "frmVerSolicitudesCopias";
            this.Text = "Ver Solicitudes Copias";
            this.Load += new System.EventHandler(this.frmVerSolicitudesCopias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerSolicitud)).EndInit();
            this.grpVerSalagrpVerSolicitudes.ResumeLayout(false);
            this.grpVerSalagrpVerSolicitudes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerSolicitud;
        private System.Windows.Forms.GroupBox grpVerSalagrpVerSolicitudes;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSolicitudBuscarNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblBuscarSolicitudID;
        private System.Windows.Forms.TextBox txtsolicitudID;
    }
}