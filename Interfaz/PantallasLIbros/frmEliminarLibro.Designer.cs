
namespace Interfaz
{
    partial class frmEliminarLibro
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
            this.grpEliminarLIbro = new System.Windows.Forms.GroupBox();
            this.pboxImagen = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.cmbIdLibro = new System.Windows.Forms.ComboBox();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblIdLibro = new System.Windows.Forms.Label();
            this.grpEliminarLIbro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEliminarLIbro
            // 
            this.grpEliminarLIbro.Controls.Add(this.pboxImagen);
            this.grpEliminarLIbro.Controls.Add(this.btnCancelar);
            this.grpEliminarLIbro.Controls.Add(this.btnEliminar);
            this.grpEliminarLIbro.Controls.Add(this.txtNombreLibro);
            this.grpEliminarLIbro.Controls.Add(this.cmbIdLibro);
            this.grpEliminarLIbro.Controls.Add(this.lblNombreLibro);
            this.grpEliminarLIbro.Controls.Add(this.lblIdLibro);
            this.grpEliminarLIbro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEliminarLIbro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarLIbro.Location = new System.Drawing.Point(0, 0);
            this.grpEliminarLIbro.Name = "grpEliminarLIbro";
            this.grpEliminarLIbro.Size = new System.Drawing.Size(609, 310);
            this.grpEliminarLIbro.TabIndex = 0;
            this.grpEliminarLIbro.TabStop = false;
            this.grpEliminarLIbro.Text = "Eliminar Libro";
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
            this.txtNombreLibro.Location = new System.Drawing.Point(218, 124);
            this.txtNombreLibro.Multiline = true;
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.ReadOnly = true;
            this.txtNombreLibro.Size = new System.Drawing.Size(153, 64);
            this.txtNombreLibro.TabIndex = 3;
            // 
            // cmbIdLibro
            // 
            this.cmbIdLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdLibro.FormattingEnabled = true;
            this.cmbIdLibro.Location = new System.Drawing.Point(295, 68);
            this.cmbIdLibro.Name = "cmbIdLibro";
            this.cmbIdLibro.Size = new System.Drawing.Size(76, 28);
            this.cmbIdLibro.TabIndex = 2;
            this.cmbIdLibro.SelectedIndexChanged += new System.EventHandler(this.cmbIdLibro_SelectedIndexChanged);
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Location = new System.Drawing.Point(59, 127);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(129, 20);
            this.lblNombreLibro.TabIndex = 1;
            this.lblNombreLibro.Text = "Nombre Libro:";
            // 
            // lblIdLibro
            // 
            this.lblIdLibro.AutoSize = true;
            this.lblIdLibro.Location = new System.Drawing.Point(59, 68);
            this.lblIdLibro.Name = "lblIdLibro";
            this.lblIdLibro.Size = new System.Drawing.Size(79, 20);
            this.lblIdLibro.TabIndex = 0;
            this.lblIdLibro.Text = "Id Libro:";
            // 
            // frmEliminarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 310);
            this.Controls.Add(this.grpEliminarLIbro);
            this.Name = "frmEliminarLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Libro";
            this.Load += new System.EventHandler(this.frmEliminarLibro_Load);
            this.grpEliminarLIbro.ResumeLayout(false);
            this.grpEliminarLIbro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEliminarLIbro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.ComboBox cmbIdLibro;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblIdLibro;
        private System.Windows.Forms.PictureBox pboxImagen;
    }
}