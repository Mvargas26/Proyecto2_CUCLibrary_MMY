
namespace Interfaz.PantallasAutores
{
    partial class frmEliminarAutor
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
            this.grpEliminarAutor = new System.Windows.Forms.GroupBox();
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.cmbIdLibro = new System.Windows.Forms.ComboBox();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.lblIdAutor = new System.Windows.Forms.Label();
            this.grpEliminarAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEliminarAutor
            // 
            this.grpEliminarAutor.Controls.Add(this.pboxImagen);
            this.grpEliminarAutor.Controls.Add(this.btnCancelar);
            this.grpEliminarAutor.Controls.Add(this.btnEliminar);
            this.grpEliminarAutor.Controls.Add(this.txtNombreLibro);
            this.grpEliminarAutor.Controls.Add(this.cmbIdLibro);
            this.grpEliminarAutor.Controls.Add(this.lblNombreAutor);
            this.grpEliminarAutor.Controls.Add(this.lblIdAutor);
            this.grpEliminarAutor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEliminarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarAutor.Location = new System.Drawing.Point(0, 0);
            this.grpEliminarAutor.Name = "grpEliminarAutor";
            this.grpEliminarAutor.Size = new System.Drawing.Size(650, 315);
            this.grpEliminarAutor.TabIndex = 1;
            this.grpEliminarAutor.TabStop = false;
            this.grpEliminarAutor.Text = "Eliminar Autor";
            // 
            // pboxImagen
            // 
            this.pboxImagen.Image = global::Interfaz.Properties.Resources.Basurero;
            this.pboxImagen.Location = new System.Drawing.Point(430, 54);
            this.pboxImagen.Name = "pboxImagen";
            this.pboxImagen.Size = new System.Drawing.Size(151, 151);
            this.pboxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagen.TabIndex = 21;
            this.pboxImagen.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(272, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 55);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(92, 221);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 55);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(250, 124);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.ReadOnly = true;
            this.txtNombreLibro.Size = new System.Drawing.Size(121, 27);
            this.txtNombreLibro.TabIndex = 3;
            // 
            // cmbIdLibro
            // 
            this.cmbIdLibro.FormattingEnabled = true;
            this.cmbIdLibro.Location = new System.Drawing.Point(250, 68);
            this.cmbIdLibro.Name = "cmbIdLibro";
            this.cmbIdLibro.Size = new System.Drawing.Size(121, 28);
            this.cmbIdLibro.TabIndex = 2;
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.Location = new System.Drawing.Point(59, 127);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(131, 20);
            this.lblNombreAutor.TabIndex = 1;
            this.lblNombreAutor.Text = "Nombre Autor:";
            // 
            // lblIdAutor
            // 
            this.lblIdAutor.AutoSize = true;
            this.lblIdAutor.Location = new System.Drawing.Point(59, 68);
            this.lblIdAutor.Name = "lblIdAutor";
            this.lblIdAutor.Size = new System.Drawing.Size(81, 20);
            this.lblIdAutor.TabIndex = 0;
            this.lblIdAutor.Text = "Id Autor:";
            // 
            // frmEliminarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 315);
            this.Controls.Add(this.grpEliminarAutor);
            this.Name = "frmEliminarAutor";
            this.Text = "Eliminar Autor";
            this.grpEliminarAutor.ResumeLayout(false);
            this.grpEliminarAutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEliminarAutor;
        private System.Windows.Forms.PictureBox pboxImagen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.ComboBox cmbIdLibro;
        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.Label lblIdAutor;
    }
}