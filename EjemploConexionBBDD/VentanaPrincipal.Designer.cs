﻿namespace EjemploConexionBBDD
{
    partial class VentanaPrincipal
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
            this.desplegableActores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // desplegableActores
            // 
            this.desplegableActores.FormattingEnabled = true;
            this.desplegableActores.Location = new System.Drawing.Point(12, 86);
            this.desplegableActores.Name = "desplegableActores";
            this.desplegableActores.Size = new System.Drawing.Size(234, 24);
            this.desplegableActores.TabIndex = 0;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desplegableActores);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox desplegableActores;
    }
}