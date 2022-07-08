
namespace Interfaz.PantallasLIbros
{
    partial class frmDGVAutores
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
            this.grpAutores = new System.Windows.Forms.GroupBox();
            this.dgvAutoresRegistrados = new System.Windows.Forms.DataGridView();
            this.grpAutoresEscogidos = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dgvAutoresYaSelec = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAutores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresRegistrados)).BeginInit();
            this.grpAutoresEscogidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresYaSelec)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAutores
            // 
            this.grpAutores.Controls.Add(this.dgvAutoresRegistrados);
            this.grpAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAutores.Location = new System.Drawing.Point(12, 12);
            this.grpAutores.Name = "grpAutores";
            this.grpAutores.Size = new System.Drawing.Size(773, 202);
            this.grpAutores.TabIndex = 0;
            this.grpAutores.TabStop = false;
            this.grpAutores.Text = "Autores Registrados";
            // 
            // dgvAutoresRegistrados
            // 
            this.dgvAutoresRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoresRegistrados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAutoresRegistrados.Location = new System.Drawing.Point(3, 23);
            this.dgvAutoresRegistrados.Name = "dgvAutoresRegistrados";
            this.dgvAutoresRegistrados.RowHeadersWidth = 51;
            this.dgvAutoresRegistrados.RowTemplate.Height = 24;
            this.dgvAutoresRegistrados.Size = new System.Drawing.Size(767, 176);
            this.dgvAutoresRegistrados.TabIndex = 0;
            // 
            // grpAutoresEscogidos
            // 
            this.grpAutoresEscogidos.Controls.Add(this.dgvAutoresYaSelec);
            this.grpAutoresEscogidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAutoresEscogidos.Location = new System.Drawing.Point(13, 279);
            this.grpAutoresEscogidos.Name = "grpAutoresEscogidos";
            this.grpAutoresEscogidos.Size = new System.Drawing.Size(776, 218);
            this.grpAutoresEscogidos.TabIndex = 1;
            this.grpAutoresEscogidos.TabStop = false;
            this.grpAutoresEscogidos.Text = "Autores que Seleciono";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(317, 220);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 40);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Autor";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(283, 513);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(195, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Autor";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Blue;
            this.btnFinalizar.Location = new System.Drawing.Point(301, 598);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(177, 69);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar !";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dgvAutoresYaSelec
            // 
            this.dgvAutoresYaSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoresYaSelec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNombre,
            this.colOrigen});
            this.dgvAutoresYaSelec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAutoresYaSelec.Location = new System.Drawing.Point(3, 23);
            this.dgvAutoresYaSelec.Name = "dgvAutoresYaSelec";
            this.dgvAutoresYaSelec.RowHeadersWidth = 51;
            this.dgvAutoresYaSelec.RowTemplate.Height = 24;
            this.dgvAutoresYaSelec.Size = new System.Drawing.Size(770, 192);
            this.dgvAutoresYaSelec.TabIndex = 1;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 125;
            // 
            // colOrigen
            // 
            this.colOrigen.HeaderText = "Origen";
            this.colOrigen.MinimumWidth = 6;
            this.colOrigen.Name = "colOrigen";
            this.colOrigen.ReadOnly = true;
            this.colOrigen.Width = 125;
            // 
            // frmDGVAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 688);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpAutoresEscogidos);
            this.Controls.Add(this.grpAutores);
            this.Name = "frmDGVAutores";
            this.Text = "frmDGVAutores";
            this.Load += new System.EventHandler(this.frmDGVAutores_Load);
            this.grpAutores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresRegistrados)).EndInit();
            this.grpAutoresEscogidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresYaSelec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAutores;
        private System.Windows.Forms.DataGridView dgvAutoresRegistrados;
        private System.Windows.Forms.GroupBox grpAutoresEscogidos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvAutoresYaSelec;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrigen;
    }
}