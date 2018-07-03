using Segundo_Parcial.ENTIDADES;
using Segundo_Parcial.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Segundo_Parcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registroDeMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDeMantenimiento registrodeMantenimiento = new RegistroDeMantenimiento();
            registrodeMantenimiento.Show();
        }
    }
}
