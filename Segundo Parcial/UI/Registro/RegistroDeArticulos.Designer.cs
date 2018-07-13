namespace Segundo_Parcial.UI.Registro
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
            this.inventarioTextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.GeneralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.costoTextBox = new System.Windows.Forms.TextBox();
            this.gananciaTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            articulosIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            gananciaLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            inventarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.articulosIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // articulosIdLabel
            // 
            articulosIdLabel.AutoSize = true;
            articulosIdLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            articulosIdLabel.Location = new System.Drawing.Point(17, 14);
            articulosIdLabel.Name = "articulosIdLabel";
            articulosIdLabel.Size = new System.Drawing.Size(74, 15);
            articulosIdLabel.TabIndex = 1;
            articulosIdLabel.Text = "Articulos Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(17, 76);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(71, 15);
            descripcionLabel.TabIndex = 3;
            descripcionLabel.Text = "Descripcion:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoLabel.Location = new System.Drawing.Point(17, 144);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(38, 15);
            costoLabel.TabIndex = 5;
            costoLabel.Text = "Costo:";
            // 
            // gananciaLabel
            // 
            gananciaLabel.AutoSize = true;
            gananciaLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gananciaLabel.Location = new System.Drawing.Point(238, 144);
            gananciaLabel.Name = "gananciaLabel";
            gananciaLabel.Size = new System.Drawing.Size(74, 15);
            gananciaLabel.TabIndex = 7;
            gananciaLabel.Text = "Ganancia % :";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            precioLabel.Location = new System.Drawing.Point(17, 203);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(43, 15);
            precioLabel.TabIndex = 9;
            precioLabel.Text = "Precio:";
            // 
            // inventarioLabel
            // 
            inventarioLabel.AutoSize = true;
            inventarioLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            inventarioLabel.Location = new System.Drawing.Point(241, 206);
            inventarioLabel.Name = "inventarioLabel";
            inventarioLabel.Size = new System.Drawing.Size(65, 15);
            inventarioLabel.TabIndex = 11;
            inventarioLabel.Text = "Inventario:";
            // 
            // articulosIdNumericUpDown
            // 
            this.articulosIdNumericUpDown.Location = new System.Drawing.Point(95, 12);
            this.articulosIdNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.articulosIdNumericUpDown.Name = "articulosIdNumericUpDown";
            this.articulosIdNumericUpDown.Size = new System.Drawing.Size(112, 20);
            this.articulosIdNumericUpDown.TabIndex = 2;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(95, 69);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(112, 20);
            this.descripcionTextBox.TabIndex = 4;
            // 
            // inventarioTextBox
            // 
            this.inventarioTextBox.Location = new System.Drawing.Point(311, 203);
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
            // costoTextBox
            // 
            this.costoTextBox.Location = new System.Drawing.Point(95, 144);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(112, 20);
            this.costoTextBox.TabIndex = 47;
            this.costoTextBox.TextChanged += new System.EventHandler(this.costoTextBox_TextChanged);
            // 
            // gananciaTextBox
            // 
            this.gananciaTextBox.Location = new System.Drawing.Point(318, 141);
            this.gananciaTextBox.Name = "gananciaTextBox";
            this.gananciaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gananciaTextBox.TabIndex = 48;
            this.gananciaTextBox.TextChanged += new System.EventHandler(this.gananciaTextBox_TextChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(95, 201);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(112, 20);
            this.precioTextBox.TabIndex = 49;
            this.precioTextBox.TextChanged += new System.EventHandler(this.precioTextBox_TextChanged);
            // 
            // VentanaRegistroDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Segundo_Parcial.Properties.Resources.pieza;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(509, 325);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.gananciaTextBox);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(inventarioLabel);
            this.Controls.Add(this.inventarioTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(gananciaLabel);
            this.Controls.Add(costoLabel);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(articulosIdLabel);
            this.Controls.Add(this.articulosIdNumericUpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaRegistroDeArticulos";
            this.Text = "Registro De Articulos";
            this.Load += new System.EventHandler(this.VentanaRegistroDeArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articulosIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeneralerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown articulosIdNumericUpDown;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox inventarioTextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider GeneralerrorProvider;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox gananciaTextBox;
        private System.Windows.Forms.TextBox costoTextBox;
    }
}