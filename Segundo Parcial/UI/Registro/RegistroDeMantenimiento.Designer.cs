namespace Segundo_Parcial.UI.Registro
{
    partial class RegistroDeMantenimiento
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label mantenimientoIdLabel;
            System.Windows.Forms.Label vehiculoIdLabel;
            System.Windows.Forms.Label tallerIdLabel;
            System.Windows.Forms.Label articulosIdLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label fechaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroDeMantenimiento));
            this.fechaproximaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.mantenimientoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vehiculoComboBox = new System.Windows.Forms.ComboBox();
            this.tallerComboBox = new System.Windows.Forms.ComboBox();
            this.articulosComboBox = new System.Windows.Forms.ComboBox();
            this.cantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.importeTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.subtotaltextBox = new System.Windows.Forms.TextBox();
            this.ItbistextBox = new System.Windows.Forms.TextBox();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.HayErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            fechaLabel = new System.Windows.Forms.Label();
            mantenimientoIdLabel = new System.Windows.Forms.Label();
            vehiculoIdLabel = new System.Windows.Forms.Label();
            tallerIdLabel = new System.Windows.Forms.Label();
            articulosIdLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            fechaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HayErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(19, 64);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(139, 15);
            fechaLabel.TabIndex = 30;
            fechaLabel.Text = "Proximo Mantenimiento:";
            // 
            // mantenimientoIdLabel
            // 
            mantenimientoIdLabel.AutoSize = true;
            mantenimientoIdLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mantenimientoIdLabel.Location = new System.Drawing.Point(23, 19);
            mantenimientoIdLabel.Name = "mantenimientoIdLabel";
            mantenimientoIdLabel.Size = new System.Drawing.Size(105, 15);
            mantenimientoIdLabel.TabIndex = 51;
            mantenimientoIdLabel.Text = "Mantenimiento Id:";
            // 
            // vehiculoIdLabel
            // 
            vehiculoIdLabel.AutoSize = true;
            vehiculoIdLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vehiculoIdLabel.Location = new System.Drawing.Point(23, 118);
            vehiculoIdLabel.Name = "vehiculoIdLabel";
            vehiculoIdLabel.Size = new System.Drawing.Size(61, 15);
            vehiculoIdLabel.TabIndex = 53;
            vehiculoIdLabel.Text = "Vehiculo :";
            // 
            // tallerIdLabel
            // 
            tallerIdLabel.AutoSize = true;
            tallerIdLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tallerIdLabel.Location = new System.Drawing.Point(23, 178);
            tallerIdLabel.Name = "tallerIdLabel";
            tallerIdLabel.Size = new System.Drawing.Size(46, 15);
            tallerIdLabel.TabIndex = 54;
            tallerIdLabel.Text = "Taller :";
            // 
            // articulosIdLabel
            // 
            articulosIdLabel.AutoSize = true;
            articulosIdLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            articulosIdLabel.Location = new System.Drawing.Point(23, 226);
            articulosIdLabel.Name = "articulosIdLabel";
            articulosIdLabel.Size = new System.Drawing.Size(63, 15);
            articulosIdLabel.TabIndex = 55;
            articulosIdLabel.Text = "Articulos :";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(301, 206);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(56, 15);
            cantidadLabel.TabIndex = 56;
            cantidadLabel.Text = "Cantidad:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioLabel.Location = new System.Drawing.Point(443, 206);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(43, 15);
            precioLabel.TabIndex = 57;
            precioLabel.Text = "Precio:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            importeLabel.Location = new System.Drawing.Point(559, 205);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(51, 15);
            importeLabel.TabIndex = 58;
            importeLabel.Text = "Importe:";
            // 
            // fechaLabel1
            // 
            fechaLabel1.AutoSize = true;
            fechaLabel1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel1.Location = new System.Drawing.Point(418, 11);
            fechaLabel1.Name = "fechaLabel1";
            fechaLabel1.Size = new System.Drawing.Size(41, 15);
            fechaLabel1.TabIndex = 59;
            fechaLabel1.Text = "Fecha:";
            // 
            // fechaproximaDateTimePicker
            // 
            this.fechaproximaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaproximaDateTimePicker.Location = new System.Drawing.Point(159, 65);
            this.fechaproximaDateTimePicker.Name = "fechaproximaDateTimePicker";
            this.fechaproximaDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.fechaproximaDateTimePicker.TabIndex = 31;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(535, 571);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 50;
            // 
            // mantenimientoIdNumericUpDown
            // 
            this.mantenimientoIdNumericUpDown.Location = new System.Drawing.Point(134, 18);
            this.mantenimientoIdNumericUpDown.Name = "mantenimientoIdNumericUpDown";
            this.mantenimientoIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.mantenimientoIdNumericUpDown.TabIndex = 52;
            // 
            // vehiculoComboBox
            // 
            this.vehiculoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehiculoComboBox.FormattingEnabled = true;
            this.vehiculoComboBox.Location = new System.Drawing.Point(134, 115);
            this.vehiculoComboBox.Name = "vehiculoComboBox";
            this.vehiculoComboBox.Size = new System.Drawing.Size(121, 21);
            this.vehiculoComboBox.TabIndex = 54;
            // 
            // tallerComboBox
            // 
            this.tallerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tallerComboBox.FormattingEnabled = true;
            this.tallerComboBox.Location = new System.Drawing.Point(134, 175);
            this.tallerComboBox.Name = "tallerComboBox";
            this.tallerComboBox.Size = new System.Drawing.Size(121, 21);
            this.tallerComboBox.TabIndex = 55;
            // 
            // articulosComboBox
            // 
            this.articulosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articulosComboBox.FormattingEnabled = true;
            this.articulosComboBox.Location = new System.Drawing.Point(134, 223);
            this.articulosComboBox.Name = "articulosComboBox";
            this.articulosComboBox.Size = new System.Drawing.Size(121, 21);
            this.articulosComboBox.TabIndex = 56;
            this.articulosComboBox.SelectedIndexChanged += new System.EventHandler(this.articulosComboBox_SelectedIndexChanged);
            // 
            // cantidadNumericUpDown
            // 
            this.cantidadNumericUpDown.Location = new System.Drawing.Point(274, 223);
            this.cantidadNumericUpDown.Name = "cantidadNumericUpDown";
            this.cantidadNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.cantidadNumericUpDown.TabIndex = 57;
            this.cantidadNumericUpDown.ValueChanged += new System.EventHandler(this.cantidadNumericUpDown_ValueChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(415, 222);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.ReadOnly = true;
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 58;
            // 
            // importeTextBox
            // 
            this.importeTextBox.Location = new System.Drawing.Point(535, 222);
            this.importeTextBox.Name = "importeTextBox";
            this.importeTextBox.ReadOnly = true;
            this.importeTextBox.Size = new System.Drawing.Size(100, 20);
            this.importeTextBox.TabIndex = 59;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(464, 8);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.fechaDateTimePicker.TabIndex = 60;
            this.fechaDateTimePicker.ValueChanged += new System.EventHandler(this.fechaDateTimePicker1_ValueChanged);
            // 
            // subtotaltextBox
            // 
            this.subtotaltextBox.Location = new System.Drawing.Point(535, 499);
            this.subtotaltextBox.Name = "subtotaltextBox";
            this.subtotaltextBox.ReadOnly = true;
            this.subtotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.subtotaltextBox.TabIndex = 62;
            this.subtotaltextBox.TextChanged += new System.EventHandler(this.subtotaltextBox_TextChanged);
            // 
            // ItbistextBox
            // 
            this.ItbistextBox.Location = new System.Drawing.Point(535, 535);
            this.ItbistextBox.Name = "ItbistextBox";
            this.ItbistextBox.ReadOnly = true;
            this.ItbistextBox.Size = new System.Drawing.Size(100, 20);
            this.ItbistextBox.TabIndex = 64;
            this.ItbistextBox.TextChanged += new System.EventHandler(this.ItbistextBox_TextChanged);
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(26, 249);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.Size = new System.Drawing.Size(609, 234);
            this.DetalledataGridView.TabIndex = 65;
            // 
            // HayErrores
            // 
            this.HayErrores.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Sub-Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(456, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Itbis 18% :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 569);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Total :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Segundo_Parcial.Properties.Resources.Mantenimiento2;
            this.pictureBox1.Location = new System.Drawing.Point(372, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 169);
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.FlatAppearance.BorderSize = 0;
            this.Agregarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Add_New_32;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Agregarbutton.Location = new System.Drawing.Point(641, 205);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 49);
            this.Agregarbutton.TabIndex = 48;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.FlatAppearance.BorderSize = 0;
            this.Removerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Removerbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Delete_32;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(26, 489);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(92, 23);
            this.Removerbutton.TabIndex = 47;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.FlatAppearance.BorderSize = 0;
            this.Eliminarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Delete_32;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(356, 532);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 55);
            this.Eliminarbutton.TabIndex = 29;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.FlatAppearance.BorderSize = 0;
            this.Guardarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Save_32;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(242, 532);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 55);
            this.Guardarbutton.TabIndex = 28;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.FlatAppearance.BorderSize = 0;
            this.Nuevobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevobutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_New_Window_32;
            this.Nuevobutton.Location = new System.Drawing.Point(128, 532);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 55);
            this.Nuevobutton.TabIndex = 27;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Search_32;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(291, 4);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 48);
            this.Buscarbutton.TabIndex = 26;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistroDeMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(723, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.ItbistextBox);
            this.Controls.Add(this.subtotaltextBox);
            this.Controls.Add(fechaLabel1);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(importeLabel);
            this.Controls.Add(this.importeTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadNumericUpDown);
            this.Controls.Add(articulosIdLabel);
            this.Controls.Add(this.articulosComboBox);
            this.Controls.Add(tallerIdLabel);
            this.Controls.Add(this.tallerComboBox);
            this.Controls.Add(vehiculoIdLabel);
            this.Controls.Add(this.vehiculoComboBox);
            this.Controls.Add(mantenimientoIdLabel);
            this.Controls.Add(this.mantenimientoIdNumericUpDown);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaproximaDateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroDeMantenimiento";
            this.Text = "Registro De Mantenimiento";
            this.Load += new System.EventHandler(this.RegistroDeMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HayErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.DateTimePicker fechaproximaDateTimePicker;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.NumericUpDown mantenimientoIdNumericUpDown;
        private System.Windows.Forms.ComboBox vehiculoComboBox;
        private System.Windows.Forms.ComboBox tallerComboBox;
        private System.Windows.Forms.ComboBox articulosComboBox;
        private System.Windows.Forms.NumericUpDown cantidadNumericUpDown;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox importeTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox subtotaltextBox;
        private System.Windows.Forms.TextBox ItbistextBox;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.ErrorProvider HayErrores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}