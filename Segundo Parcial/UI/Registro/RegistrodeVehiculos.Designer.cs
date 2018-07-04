namespace Segundo_Parcial.UI.Registro
{
    partial class RegistrodeVehiculos
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
            System.Windows.Forms.Label vehiculosIdLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label mantenimientoLabel;
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.vehiculosIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.mantenimientoTextBox = new System.Windows.Forms.TextBox();
            this.GenaralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            vehiculosIdLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            mantenimientoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenaralerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculosIdLabel
            // 
            vehiculosIdLabel.AutoSize = true;
            vehiculosIdLabel.Location = new System.Drawing.Point(4, 20);
            vehiculosIdLabel.Name = "vehiculosIdLabel";
            vehiculosIdLabel.Size = new System.Drawing.Size(68, 13);
            vehiculosIdLabel.TabIndex = 34;
            vehiculosIdLabel.Text = "Vehiculos Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(4, 51);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 35;
            descripcionLabel.Text = "Descripcion:";
            // 
            // mantenimientoLabel
            // 
            mantenimientoLabel.AutoSize = true;
            mantenimientoLabel.Location = new System.Drawing.Point(4, 79);
            mantenimientoLabel.Name = "mantenimientoLabel";
            mantenimientoLabel.Size = new System.Drawing.Size(106, 13);
            mantenimientoLabel.TabIndex = 36;
            mantenimientoLabel.Text = "Total Mantenimiento:";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Delete_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(255, 114);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 55);
            this.Eliminarbutton.TabIndex = 33;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Save_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(141, 114);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 55);
            this.Guardarbutton.TabIndex = 32;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_New_Window_32;
            this.Nuevobutton.Location = new System.Drawing.Point(27, 114);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 55);
            this.Nuevobutton.TabIndex = 31;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Search_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(256, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 48);
            this.Buscarbutton.TabIndex = 30;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // vehiculosIdNumericUpDown
            // 
            this.vehiculosIdNumericUpDown.Location = new System.Drawing.Point(116, 18);
            this.vehiculosIdNumericUpDown.Name = "vehiculosIdNumericUpDown";
            this.vehiculosIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.vehiculosIdNumericUpDown.TabIndex = 35;
            this.vehiculosIdNumericUpDown.ValueChanged += new System.EventHandler(this.vehiculosIdNumericUpDown_ValueChanged);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(116, 48);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(120, 20);
            this.descripcionTextBox.TabIndex = 36;
            // 
            // mantenimientoTextBox
            // 
            this.mantenimientoTextBox.Location = new System.Drawing.Point(116, 79);
            this.mantenimientoTextBox.Name = "mantenimientoTextBox";
            this.mantenimientoTextBox.ReadOnly = true;
            this.mantenimientoTextBox.Size = new System.Drawing.Size(120, 20);
            this.mantenimientoTextBox.TabIndex = 37;
            // 
            // GenaralerrorProvider
            // 
            this.GenaralerrorProvider.ContainerControl = this;
            // 
            // RegistrodeVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 182);
            this.Controls.Add(mantenimientoLabel);
            this.Controls.Add(this.mantenimientoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(vehiculosIdLabel);
            this.Controls.Add(this.vehiculosIdNumericUpDown);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "RegistrodeVehiculos";
            this.Text = "Registro de Vehiculos";
            this.Load += new System.EventHandler(this.RegistrodeVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenaralerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.NumericUpDown vehiculosIdNumericUpDown;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox mantenimientoTextBox;
        private System.Windows.Forms.ErrorProvider GenaralerrorProvider;
    }
}