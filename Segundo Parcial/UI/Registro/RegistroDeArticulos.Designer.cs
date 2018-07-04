﻿namespace Segundo_Parcial.UI.Registro
{
    partial class VentanaRegistroDeArticulos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label articulosIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label costoLabel;
            System.Windows.Forms.Label gananciaLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label inventarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaRegistroDeArticulos));
            this.articulosIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.costoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gananciaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.precioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inventarioTextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            articulosIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            gananciaLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            inventarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articulosIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gananciaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // articulosIdLabel
            // 
            articulosIdLabel.AutoSize = true;
            articulosIdLabel.Location = new System.Drawing.Point(25, 14);
            articulosIdLabel.Name = "articulosIdLabel";
            articulosIdLabel.Size = new System.Drawing.Size(62, 13);
            articulosIdLabel.TabIndex = 1;
            articulosIdLabel.Text = "Articulos Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(25, 76);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Location = new System.Drawing.Point(25, 144);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(36, 13);
            costoLabel.TabIndex = 5;
            costoLabel.Text = "costo:";
            // 
            // gananciaLabel
            // 
            gananciaLabel.AutoSize = true;
            gananciaLabel.Location = new System.Drawing.Point(242, 143);
            gananciaLabel.Name = "gananciaLabel";
            gananciaLabel.Size = new System.Drawing.Size(67, 13);
            gananciaLabel.TabIndex = 7;
            gananciaLabel.Text = "Ganancia %:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(25, 203);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "precio:";
            // 
            // inventarioLabel
            // 
            inventarioLabel.AutoSize = true;
            inventarioLabel.Location = new System.Drawing.Point(241, 206);
            inventarioLabel.Name = "inventarioLabel";
            inventarioLabel.Size = new System.Drawing.Size(57, 13);
            inventarioLabel.TabIndex = 11;
            inventarioLabel.Text = "Inventario:";
            // 
            // articulosIdNumericUpDown
            // 
            this.articulosIdNumericUpDown.Location = new System.Drawing.Point(95, 12);
            this.articulosIdNumericUpDown.Name = "articulosIdNumericUpDown";
            this.articulosIdNumericUpDown.Size = new System.Drawing.Size(112, 20);
            this.articulosIdNumericUpDown.TabIndex = 2;
            this.articulosIdNumericUpDown.ValueChanged += new System.EventHandler(this.articulosIdNumericUpDown_ValueChanged);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(95, 69);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(112, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // costoNumericUpDown
            // 
            this.costoNumericUpDown.Location = new System.Drawing.Point(95, 140);
            this.costoNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.costoNumericUpDown.Name = "costoNumericUpDown";
            this.costoNumericUpDown.Size = new System.Drawing.Size(112, 20);
            this.costoNumericUpDown.TabIndex = 6;
            this.costoNumericUpDown.ValueChanged += new System.EventHandler(this.costoNumericUpDown_ValueChanged);
            // 
            // gananciaNumericUpDown
            // 
            this.gananciaNumericUpDown.Location = new System.Drawing.Point(311, 140);
            this.gananciaNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.gananciaNumericUpDown.Name = "gananciaNumericUpDown";
            this.gananciaNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.gananciaNumericUpDown.TabIndex = 8;
            this.gananciaNumericUpDown.ValueChanged += new System.EventHandler(this.gananciaNumericUpDown_ValueChanged);
            // 
            // precioNumericUpDown
            // 
            this.precioNumericUpDown.Location = new System.Drawing.Point(95, 199);
            this.precioNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.precioNumericUpDown.Name = "precioNumericUpDown";
            this.precioNumericUpDown.Size = new System.Drawing.Size(112, 20);
            this.precioNumericUpDown.TabIndex = 10;
            this.precioNumericUpDown.ValueChanged += new System.EventHandler(this.precioNumericUpDown_ValueChanged);
            // 
            // inventarioTextBox
            // 
            this.inventarioTextBox.Location = new System.Drawing.Point(304, 203);
            this.inventarioTextBox.Name = "inventarioTextBox";
            this.inventarioTextBox.ReadOnly = true;
            this.inventarioTextBox.Size = new System.Drawing.Size(120, 20);
            this.inventarioTextBox.TabIndex = 12;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(280, 248);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 55);
            this.Eliminarbutton.TabIndex = 45;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(166, 248);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 55);
            this.Guardarbutton.TabIndex = 44;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.Location = new System.Drawing.Point(52, 248);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 55);
            this.Nuevobutton.TabIndex = 43;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(213, 3);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 48);
            this.Buscarbutton.TabIndex = 42;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // GeneralerrorProvider
            // 
            this.GeneralerrorProvider.ContainerControl = this;
            // 
            // VentanaRegistroDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 325);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(inventarioLabel);
            this.Controls.Add(this.inventarioTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioNumericUpDown);
            this.Controls.Add(gananciaLabel);
            this.Controls.Add(this.gananciaNumericUpDown);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.costoNumericUpDown);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(articulosIdLabel);
            this.Controls.Add(this.articulosIdNumericUpDown);
            this.Name = "VentanaRegistroDeArticulos";
            this.Text = "Registro De Articulos";
            this.Load += new System.EventHandler(this.VentanaRegistroDeArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articulosIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gananciaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown articulosIdNumericUpDown;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.NumericUpDown costoNumericUpDown;
        private System.Windows.Forms.NumericUpDown gananciaNumericUpDown;
        private System.Windows.Forms.NumericUpDown precioNumericUpDown;
        private System.Windows.Forms.TextBox inventarioTextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider GeneralerrorProvider;
    }
}