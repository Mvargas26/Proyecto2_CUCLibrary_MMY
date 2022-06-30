
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
            this.grpAutoresEscogidos = new System.Windows.Forms.GroupBox();
            this.lsvAutoresEscogidos = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvAutoresRegistrados = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.grpAutores.SuspendLayout();
            this.grpAutoresEscogidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresRegistrados)).BeginInit();
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
            // grpAutoresEscogidos
            // 
            this.grpAutoresEscogidos.Controls.Add(this.lsvAutoresEscogidos);
            this.grpAutoresEscogidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAutoresEscogidos.Location = new System.Drawing.Point(13, 279);
            this.grpAutoresEscogidos.Name = "grpAutoresEscogidos";
            this.grpAutoresEscogidos.Size = new System.Drawing.Size(776, 218);
            this.grpAutoresEscogidos.TabIndex = 1;
            this.grpAutoresEscogidos.TabStop = false;
            this.grpAutoresEscogidos.Text = "Autores que Seleciono";
            // 
            // lsvAutoresEscogidos
            // 
            this.lsvAutoresEscogidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvAutoresEscogidos.HideSelection = false;
            this.lsvAutoresEscogidos.Location = new System.Drawing.Point(3, 23);
            this.lsvAutoresEscogidos.Name = "lsvAutoresEscogidos";
            this.lsvAutoresEscogidos.Size = new System.Drawing.Size(770, 192);
            this.lsvAutoresEscogidos.TabIndex = 0;
            this.lsvAutoresEscogidos.UseCompatibleStateImageBehavior = false;
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
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(283, 513);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(195, 40);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Autor";
            this.btnEliminar.UseVisualStyleBackColor = true;
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
            this.grpAutores.ResumeLayout(false);
            this.grpAutoresEscogidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresRegistrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAutores;
        private System.Windows.Forms.DataGridView dgvAutoresRegistrados;
        private System.Windows.Forms.GroupBox grpAutoresEscogidos;
        private System.Windows.Forms.ListView lsvAutoresEscogidos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFinalizar;
    }
}