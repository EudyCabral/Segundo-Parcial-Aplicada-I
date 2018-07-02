namespace Segundo_Parcial.UI.Registro
{
    partial class detalle
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
            System.Windows.Forms.Label perroIdLabel;
            System.Windows.Forms.Label personaIdLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label ventasIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label label1;
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.VentasdataGridView = new System.Windows.Forms.DataGridView();
            this.perroIdComboBox = new System.Windows.Forms.ComboBox();
            this.personaIdComboBox = new System.Windows.Forms.ComboBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.importeTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.ventasIdTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            perroIdLabel = new System.Windows.Forms.Label();
            personaIdLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ventasIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VentasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // perroIdLabel
            // 
            perroIdLabel.AutoSize = true;
            perroIdLabel.Location = new System.Drawing.Point(9, 83);
            perroIdLabel.Name = "perroIdLabel";
            perroIdLabel.Size = new System.Drawing.Size(22, 13);
            perroIdLabel.TabIndex = 44;
            perroIdLabel.Text = " Id:";
            // 
            // personaIdLabel
            // 
            personaIdLabel.AutoSize = true;
            personaIdLabel.Location = new System.Drawing.Point(9, 49);
            personaIdLabel.Name = "personaIdLabel";
            personaIdLabel.Size = new System.Drawing.Size(61, 13);
            personaIdLabel.TabIndex = 42;
            personaIdLabel.Text = "Persona Id:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(250, 65);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 39;
            cantidadLabel.Text = "Cantidad:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(491, 65);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(45, 13);
            importeLabel.TabIndex = 37;
            importeLabel.Text = "Importe:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(379, 65);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(39, 13);
            precioLabel.TabIndex = 36;
            precioLabel.Text = "precio:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(553, 359);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 34;
            descripcionLabel.Text = "Descripcion:";
            // 
            // ventasIdLabel
            // 
            ventasIdLabel.AutoSize = true;
            ventasIdLabel.Location = new System.Drawing.Point(9, 7);
            ventasIdLabel.Name = "ventasIdLabel";
            ventasIdLabel.Size = new System.Drawing.Size(61, 13);
            ventasIdLabel.TabIndex = 32;
            ventasIdLabel.Text = "principal Id:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(553, 11);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 30;
            fechaLabel.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(555, 343);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 13);
            label1.TabIndex = 49;
            label1.Text = "Total:";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Add_New_32;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Agregarbutton.Location = new System.Drawing.Point(599, 49);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 52);
            this.Agregarbutton.TabIndex = 48;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Delete_32;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(12, 335);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(92, 23);
            this.Removerbutton.TabIndex = 47;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            // 
            // VentasdataGridView
            // 
            this.VentasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasdataGridView.Location = new System.Drawing.Point(12, 107);
            this.VentasdataGridView.Name = "VentasdataGridView";
            this.VentasdataGridView.Size = new System.Drawing.Size(683, 222);
            this.VentasdataGridView.TabIndex = 46;
            // 
            // perroIdComboBox
            // 
            this.perroIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perroIdComboBox.FormattingEnabled = true;
            this.perroIdComboBox.Location = new System.Drawing.Point(76, 80);
            this.perroIdComboBox.Name = "perroIdComboBox";
            this.perroIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.perroIdComboBox.TabIndex = 45;
            // 
            // personaIdComboBox
            // 
            this.personaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personaIdComboBox.FormattingEnabled = true;
            this.personaIdComboBox.Location = new System.Drawing.Point(76, 46);
            this.personaIdComboBox.Name = "personaIdComboBox";
            this.personaIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.personaIdComboBox.TabIndex = 43;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.Location = new System.Drawing.Point(236, 81);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 41;
            // 
            // importeTextBox
            // 
            this.importeTextBox.Location = new System.Drawing.Point(469, 81);
            this.importeTextBox.Name = "importeTextBox";
            this.importeTextBox.ReadOnly = true;
            this.importeTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeTextBox.TabIndex = 40;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(353, 81);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 38;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Location = new System.Drawing.Point(469, 375);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(228, 64);
            this.descripcionTextBox.TabIndex = 35;
            // 
            // ventasIdTextBox
            // 
            this.ventasIdTextBox.Location = new System.Drawing.Point(76, 4);
            this.ventasIdTextBox.Name = "ventasIdTextBox";
            this.ventasIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.ventasIdTextBox.TabIndex = 33;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(599, 7);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.fechaDateTimePicker.TabIndex = 31;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Delete_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(332, 387);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 55);
            this.Eliminarbutton.TabIndex = 29;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Save_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(218, 387);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 55);
            this.Guardarbutton.TabIndex = 28;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_New_Window_32;
            this.Nuevobutton.Location = new System.Drawing.Point(104, 387);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 55);
            this.Nuevobutton.TabIndex = 27;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Search_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(222, 4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 48);
            this.Buscarbutton.TabIndex = 26;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(595, 338);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 50;
            this.TotaltextBox.TextChanged += new System.EventHandler(this.TotaltextBox_TextChanged);
            // 
            // detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(label1);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(this.VentasdataGridView);
            this.Controls.Add(perroIdLabel);
            this.Controls.Add(this.perroIdComboBox);
            this.Controls.Add(personaIdLabel);
            this.Controls.Add(this.personaIdComboBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(importeLabel);
            this.Controls.Add(this.importeTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(ventasIdLabel);
            this.Controls.Add(this.ventasIdTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "detalle";
            this.Text = "Ventana";
            ((System.ComponentModel.ISupportInitialize)(this.VentasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.DataGridView VentasdataGridView;
        private System.Windows.Forms.ComboBox perroIdComboBox;
        private System.Windows.Forms.ComboBox personaIdComboBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox importeTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox ventasIdTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox TotaltextBox;
    }
}