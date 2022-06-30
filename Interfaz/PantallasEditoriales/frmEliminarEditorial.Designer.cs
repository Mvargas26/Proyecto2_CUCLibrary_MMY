
namespace Interfaz.PantallasEditoriales
{
    partial class frmEliminarEditorial
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
            this.lblNombreEditorial = new System.Windows.Forms.Label();
            this.txtNombreEditorial = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEditorialID = new System.Windows.Forms.Label();
            this.cmbEditorialID = new System.Windows.Forms.ComboBox();
            this.grpEliminarEditorial = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpEliminarEditorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreEditorial
            // 
            this.lblNombreEditorial.AutoSize = true;
            this.lblNombreEditorial.Location = new System.Drawing.Point(40, 124);
            this.lblNombreEditorial.Name = "lblNombreEditorial";
            this.lblNombreEditorial.Size = new System.Drawing.Size(225, 24);
            this.lblNombreEditorial.TabIndex = 0;
            this.lblNombreEditorial.Text = "Nombre de la Editorial:";
            // 
            // txtNombreEditorial
            // 
            this.txtNombreEditorial.Location = new System.Drawing.Point(298, 125);
            this.txtNombreEditorial.Name = "txtNombreEditorial";
            this.txtNombreEditorial.ReadOnly = true;
            this.txtNombreEditorial.Size = new System.Drawing.Size(176, 28);
            this.txtNombreEditorial.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(353, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblEditorialID
            // 
            this.lblEditorialID.AutoSize = true;
            this.lblEditorialID.Location = new System.Drawing.Point(40, 59);
            this.lblEditorialID.Name = "lblEditorialID";
            this.lblEditorialID.Size = new System.Drawing.Size(117, 24);
            this.lblEditorialID.TabIndex = 26;
            this.lblEditorialID.Text = "ID Editorial:";
            // 
            // cmbEditorialID
            // 
            this.cmbEditorialID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorialID.FormattingEnabled = true;
            this.cmbEditorialID.Location = new System.Drawing.Point(298, 59);
            this.cmbEditorialID.Name = "cmbEditorialID";
            this.cmbEditorialID.Size = new System.Drawing.Size(176, 30);
            this.cmbEditorialID.TabIndex = 27;
            // 
            // grpEliminarEditorial
            // 
            this.grpEliminarEditorial.Controls.Add(this.btnEliminar);
            this.grpEliminarEditorial.Controls.Add(this.cmbEditorialID);
            this.grpEliminarEditorial.Controls.Add(this.lblEditorialID);
            this.grpEliminarEditorial.Controls.Add(this.pictureBox1);
            this.grpEliminarEditorial.Controls.Add(this.btnCancelar);
            this.grpEliminarEditorial.Controls.Add(this.txtNombreEditorial);
            this.grpEliminarEditorial.Controls.Add(this.lblNombreEditorial);
            this.grpEliminarEditorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpEliminarEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEliminarEditorial.Location = new System.Drawing.Point(0, 0);
            this.grpEliminarEditorial.Name = "grpEliminarEditorial";
            this.grpEliminarEditorial.Size = new System.Drawing.Size(720, 322);
            this.grpEliminarEditorial.TabIndex = 3;
            this.grpEliminarEditorial.TabStop = false;
            this.grpEliminarEditorial.Text = "Eliminar Editorial";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(173, 241);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 55);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.basurero2;
            this.pictureBox1.Location = new System.Drawing.Point(527, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // frmEliminarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 322);
            this.Controls.Add(this.grpEliminarEditorial);
            this.Name = "frmEliminarEditorial";
            this.Text = "frmEliminarEditorial";
            this.grpEliminarEditorial.ResumeLayout(false);
            this.grpEliminarEditorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreEditorial;
        private System.Windows.Forms.TextBox txtNombreEditorial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEditorialID;
        private System.Windows.Forms.ComboBox cmbEditorialID;
        private System.Windows.Forms.GroupBox grpEliminarEditorial;
        private System.Windows.Forms.Button btnEliminar;
    }
}