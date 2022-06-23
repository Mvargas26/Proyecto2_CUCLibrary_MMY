﻿
namespace Interfaz.PantallasEditoriales
{
    partial class frmModificarEditorial
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
            this.grpModificarEditorial = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtLugarOrigen = new System.Windows.Forms.TextBox();
            this.lblLugarOrigen = new System.Windows.Forms.Label();
            this.txtNombreEditorial = new System.Windows.Forms.TextBox();
            this.lblNombreEditorial = new System.Windows.Forms.Label();
            this.lblEditorialID = new System.Windows.Forms.Label();
            this.cmbEditorialID = new System.Windows.Forms.ComboBox();
            this.grpModificarEditorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpModificarEditorial
            // 
            this.grpModificarEditorial.Controls.Add(this.cmbEditorialID);
            this.grpModificarEditorial.Controls.Add(this.lblEditorialID);
            this.grpModificarEditorial.Controls.Add(this.pictureBox1);
            this.grpModificarEditorial.Controls.Add(this.btnCancelar);
            this.grpModificarEditorial.Controls.Add(this.btnAgregar);
            this.grpModificarEditorial.Controls.Add(this.txtLugarOrigen);
            this.grpModificarEditorial.Controls.Add(this.lblLugarOrigen);
            this.grpModificarEditorial.Controls.Add(this.txtNombreEditorial);
            this.grpModificarEditorial.Controls.Add(this.lblNombreEditorial);
            this.grpModificarEditorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpModificarEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModificarEditorial.Location = new System.Drawing.Point(0, 0);
            this.grpModificarEditorial.Name = "grpModificarEditorial";
            this.grpModificarEditorial.Size = new System.Drawing.Size(711, 377);
            this.grpModificarEditorial.TabIndex = 2;
            this.grpModificarEditorial.TabStop = false;
            this.grpModificarEditorial.Text = "Modificar Editorial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.modfEditorial;
            this.pictureBox1.Location = new System.Drawing.Point(518, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCancelar.Location = new System.Drawing.Point(338, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 48);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAgregar.Location = new System.Drawing.Point(156, 287);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(123, 48);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtLugarOrigen
            // 
            this.txtLugarOrigen.Location = new System.Drawing.Point(298, 200);
            this.txtLugarOrigen.Name = "txtLugarOrigen";
            this.txtLugarOrigen.Size = new System.Drawing.Size(176, 28);
            this.txtLugarOrigen.TabIndex = 3;
            // 
            // lblLugarOrigen
            // 
            this.lblLugarOrigen.AutoSize = true;
            this.lblLugarOrigen.Location = new System.Drawing.Point(40, 204);
            this.lblLugarOrigen.Name = "lblLugarOrigen";
            this.lblLugarOrigen.Size = new System.Drawing.Size(169, 24);
            this.lblLugarOrigen.TabIndex = 2;
            this.lblLugarOrigen.Text = "Lugar de Origen:";
            // 
            // txtNombreEditorial
            // 
            this.txtNombreEditorial.Location = new System.Drawing.Point(298, 125);
            this.txtNombreEditorial.Name = "txtNombreEditorial";
            this.txtNombreEditorial.Size = new System.Drawing.Size(176, 28);
            this.txtNombreEditorial.TabIndex = 1;
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
            // frmModificarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 377);
            this.Controls.Add(this.grpModificarEditorial);
            this.Name = "frmModificarEditorial";
            this.Text = "frmModificarEditorial";
            this.grpModificarEditorial.ResumeLayout(false);
            this.grpModificarEditorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModificarEditorial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtLugarOrigen;
        private System.Windows.Forms.Label lblLugarOrigen;
        private System.Windows.Forms.TextBox txtNombreEditorial;
        private System.Windows.Forms.Label lblNombreEditorial;
        private System.Windows.Forms.Label lblEditorialID;
        private System.Windows.Forms.ComboBox cmbEditorialID;
    }
}