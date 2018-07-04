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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label mantenimientoIdLabel;
            System.Windows.Forms.Label vehiculoIdLabel;
            System.Windows.Forms.Label tallerIdLabel;
            System.Windows.Forms.Label articulosIdLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label fechaLabel1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.fechaproximaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
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
            fechaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            mantenimientoIdLabel = new System.Windows.Forms.Label();
            vehiculoIdLabel = new System.Windows.Forms.Label();
            tallerIdLabel = new System.Windows.Forms.Label();
            articulosIdLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            fechaLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HayErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(23, 64);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(119, 13);
            fechaLabel.TabIndex = 30;
            fechaLabel.Text = "Proximo Mantenimiento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(474, 574);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 13);
            label1.TabIndex = 49;
            label1.Text = "Total:";
            // 
            // mantenimientoIdLabel
            // 
            mantenimientoIdLabel.AutoSize = true;
            mantenimientoIdLabel.Location = new System.Drawing.Point(23, 19);
            mantenimientoIdLabel.Name = "mantenimientoIdLabel";
            mantenimientoIdLabel.Size = new System.Drawing.Size(91, 13);
            mantenimientoIdLabel.TabIndex = 51;
            mantenimientoIdLabel.Text = "Mantenimiento Id:";
            // 
            // vehiculoIdLabel
            // 
            vehiculoIdLabel.AutoSize = true;
            vehiculoIdLabel.Location = new System.Drawing.Point(23, 118);
            vehiculoIdLabel.Name = "vehiculoIdLabel";
            vehiculoIdLabel.Size = new System.Drawing.Size(54, 13);
            vehiculoIdLabel.TabIndex = 53;
            vehiculoIdLabel.Text = "Vehiculo :";
            // 
            // tallerIdLabel
            // 
            tallerIdLabel.AutoSize = true;
            tallerIdLabel.Location = new System.Drawing.Point(23, 178);
            tallerIdLabel.Name = "tallerIdLabel";
            tallerIdLabel.Size = new System.Drawing.Size(39, 13);
            tallerIdLabel.TabIndex = 54;
            tallerIdLabel.Text = "Taller :";
            // 
            // articulosIdLabel
            // 
            articulosIdLabel.AutoSize = true;
            articulosIdLabel.Location = new System.Drawing.Point(23, 226);
            articulosIdLabel.Name = "articulosIdLabel";
            articulosIdLabel.Size = new System.Drawing.Size(53, 13);
            articulosIdLabel.TabIndex = 55;
            articulosIdLabel.Text = "Articulos :";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(301, 206);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 56;
            cantidadLabel.Text = "Cantidad:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(443, 206);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 57;
            precioLabel.Text = "Precio:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(559, 205);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(45, 13);
            importeLabel.TabIndex = 58;
            importeLabel.Text = "Importe:";
            // 
            // fechaLabel1
            // 
            fechaLabel1.AutoSize = true;
            fechaLabel1.Location = new System.Drawing.Point(418, 11);
            fechaLabel1.Name = "fechaLabel1";
            fechaLabel1.Size = new System.Drawing.Size(40, 13);
            fechaLabel1.TabIndex = 59;
            fechaLabel1.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(474, 502);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 13);
            label2.TabIndex = 61;
            label2.Text = "Sub-Total:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(474, 538);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 13);
            label3.TabIndex = 63;
            label3.Text = "Itbis %18 :";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Add_New_32;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Agregarbutton.Location = new System.Drawing.Point(641, 206);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 44);
            this.Agregarbutton.TabIndex = 48;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Removerbutton
            // 
            this.Removerbutton.Image = global::Segundo_Parcial.Properties.Resources.icons8_Delete_32;
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(26, 489);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(92, 23);
            this.Removerbutton.TabIndex = 47;
            this.Removerbutton.Text = "Remover";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            // 
            // fechaproximaDateTimePicker
            // 
            this.fechaproximaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaproximaDateTimePicker.Location = new System.Drawing.Point(145, 64);
            this.fechaproximaDateTimePicker.Name = "fechaproximaDateTimePicker";
            this.fechaproximaDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.fechaproximaDateTimePicker.TabIndex = 31;
            // 
            // Eliminarbutton
            // 
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
            this.mantenimientoIdNumericUpDown.Location = new System.Drawing.Point(120, 17);
            this.mantenimientoIdNumericUpDown.Name = "mantenimientoIdNumericUpDown";
            this.mantenimientoIdNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.mantenimientoIdNumericUpDown.TabIndex = 52;
            // 
            // vehiculoComboBox
            // 
            this.vehiculoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vehiculoComboBox.FormattingEnabled = true;
            this.vehiculoComboBox.Location = new System.Drawing.Point(120, 114);
            this.vehiculoComboBox.Name = "vehiculoComboBox";
            this.vehiculoComboBox.Size = new System.Drawing.Size(121, 21);
            this.vehiculoComboBox.TabIndex = 54;
            // 
            // tallerComboBox
            // 
            this.tallerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tallerComboBox.FormattingEnabled = true;
            this.tallerComboBox.Location = new System.Drawing.Point(120, 174);
            this.tallerComboBox.Name = "tallerComboBox";
            this.tallerComboBox.Size = new System.Drawing.Size(121, 21);
            this.tallerComboBox.TabIndex = 55;
            // 
            // articulosComboBox
            // 
            this.articulosComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articulosComboBox.FormattingEnabled = true;
            this.articulosComboBox.Location = new System.Drawing.Point(120, 222);
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
            // 
            // ItbistextBox
            // 
            this.ItbistextBox.Location = new System.Drawing.Point(535, 535);
            this.ItbistextBox.Name = "ItbistextBox";
            this.ItbistextBox.ReadOnly = true;
            this.ItbistextBox.Size = new System.Drawing.Size(100, 20);
            this.ItbistextBox.TabIndex = 64;
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
            // RegistroDeMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 612);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(label3);
            this.Controls.Add(this.ItbistextBox);
            this.Controls.Add(label2);
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
            this.Controls.Add(label1);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.Removerbutton);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaproximaDateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Name = "RegistroDeMantenimiento";
            this.Text = "Registro De Mantenimiento";
            this.Load += new System.EventHandler(this.RegistroDeMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mantenimientoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HayErrores)).EndInit();
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
    }
}