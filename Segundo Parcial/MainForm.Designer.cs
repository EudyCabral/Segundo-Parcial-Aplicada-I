namespace Segundo_Parcial
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeTalleresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEntradaDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivosToolStripMenuItem.Image")));
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::Segundo_Parcial.Properties.Resources.icons8_Exit_32;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeMantenimientoToolStripMenuItem,
            this.registroDeVehiculosToolStripMenuItem,
            this.registroDeTalleresToolStripMenuItem,
            this.registroEntradaDeArticulosToolStripMenuItem,
            this.registroDeArticulosToolStripMenuItem});
            this.registroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroToolStripMenuItem.Image")));
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.registroToolStripMenuItem.Text = "Registros";
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // registroDeMantenimientoToolStripMenuItem
            // 
            this.registroDeMantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeMantenimientoToolStripMenuItem.Image")));
            this.registroDeMantenimientoToolStripMenuItem.Name = "registroDeMantenimientoToolStripMenuItem";
            this.registroDeMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.registroDeMantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.registroDeMantenimientoToolStripMenuItem.Click += new System.EventHandler(this.registroDeMantenimientoToolStripMenuItem_Click);
            // 
            // registroDeVehiculosToolStripMenuItem
            // 
            this.registroDeVehiculosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeVehiculosToolStripMenuItem.Image")));
            this.registroDeVehiculosToolStripMenuItem.Name = "registroDeVehiculosToolStripMenuItem";
            this.registroDeVehiculosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.registroDeVehiculosToolStripMenuItem.Text = " Vehiculos";
            this.registroDeVehiculosToolStripMenuItem.Click += new System.EventHandler(this.registroDeVehiculosToolStripMenuItem_Click);
            // 
            // registroDeTalleresToolStripMenuItem
            // 
            this.registroDeTalleresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeTalleresToolStripMenuItem.Image")));
            this.registroDeTalleresToolStripMenuItem.Name = "registroDeTalleresToolStripMenuItem";
            this.registroDeTalleresToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.registroDeTalleresToolStripMenuItem.Text = "Talleres";
            this.registroDeTalleresToolStripMenuItem.Click += new System.EventHandler(this.registroDeTalleresToolStripMenuItem_Click);
            // 
            // registroEntradaDeArticulosToolStripMenuItem
            // 
            this.registroEntradaDeArticulosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroEntradaDeArticulosToolStripMenuItem.Image")));
            this.registroEntradaDeArticulosToolStripMenuItem.Name = "registroEntradaDeArticulosToolStripMenuItem";
            this.registroEntradaDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.registroEntradaDeArticulosToolStripMenuItem.Text = "Registro Entrada de Articulos";
            this.registroEntradaDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.registroEntradaDeArticulosToolStripMenuItem_Click);
            // 
            // registroDeArticulosToolStripMenuItem
            // 
            this.registroDeArticulosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroDeArticulosToolStripMenuItem.Image")));
            this.registroDeArticulosToolStripMenuItem.Name = "registroDeArticulosToolStripMenuItem";
            this.registroDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.registroDeArticulosToolStripMenuItem.Text = "Registro de Articulos";
            this.registroDeArticulosToolStripMenuItem.Click += new System.EventHandler(this.registroDeArticulosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculosToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.mantenimientoToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = global::Segundo_Parcial.Properties.Resources.icons8_Question_Mark_32;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // vehiculosToolStripMenuItem
            // 
            this.vehiculosToolStripMenuItem.Image = global::Segundo_Parcial.Properties.Resources.icons8_Convertible_32;
            this.vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            this.vehiculosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vehiculosToolStripMenuItem.Text = "Vehiculos";
            this.vehiculosToolStripMenuItem.Click += new System.EventHandler(this.vehiculosToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Image = global::Segundo_Parcial.Properties.Resources.icons8_Settings_32;
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mantenimientoToolStripMenuItem.Image = global::Segundo_Parcial.Properties.Resources.Mantenimiento3;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(591, 313);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeMantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeTalleresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEntradaDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
    }
}

