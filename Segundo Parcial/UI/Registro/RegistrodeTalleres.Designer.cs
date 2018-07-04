namespace Segundo_Parcial.UI.Registro
{
    partial class RegistrodeTalleres
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label tallerIdLabel;
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.tallerIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.GenaralerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            nombreLabel = new System.Windows.Forms.Label();
            tallerIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tallerIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenaralerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(4, 42);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 38;
            nombreLabel.Text = "Nombre:";
            // 
            // tallerIdLabel
            // 
            tallerIdLabel.AutoSize = true;
            tallerIdLabel.Location = new System.Drawing.Point(4, 14);
            tallerIdLabel.Name = "tallerIdLabel";
            tallerIdLabel.Size = new System.Drawing.Size(48, 13);
            tallerIdLabel.TabIndex = 40;
            tallerIdLabel.Text = "Taller Id:";
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Delete_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(236, 79);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 55);
            this.Eliminarbutton.TabIndex = 37;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Save_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(122, 79);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 55);
            this.Guardarbutton.TabIndex = 36;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Add_New_32;
            this.Nuevobutton.Location = new System.Drawing.Point(8, 79);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 55);
            this.Nuevobutton.TabIndex = 35;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Search_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(187, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 48);
            this.Buscarbutton.TabIndex = 34;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(64, 40);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 39;
            // 
            // tallerIdNumericUpDown
            // 
            this.tallerIdNumericUpDown.Location = new System.Drawing.Point(64, 14);
            this.tallerIdNumericUpDown.Name = "tallerIdNumericUpDown";
            this.tallerIdNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.tallerIdNumericUpDown.TabIndex = 41;
            // 
            // GenaralerrorProvider
            // 
            this.GenaralerrorProvider.ContainerControl = this;
            // 
            // RegistrodeTalleres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 154);
            this.Controls.Add(tallerIdLabel);
            this.Controls.Add(this.tallerIdNumericUpDown);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "RegistrodeTalleres";
            this.Text = "Registro de Talleres";
            this.Load += new System.EventHandler(this.RegistrodeTalleres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tallerIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenaralerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.NumericUpDown tallerIdNumericUpDown;
        private System.Windows.Forms.ErrorProvider GenaralerrorProvider;
    }
}