using Segundo_Parcial.ENTIDADES;
using Segundo_Parcial.UI;
using Segundo_Parcial.UI.Consulta;
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

        private void registroDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeVehiculos registrodeVehiculos = new RegistrodeVehiculos();
            registrodeVehiculos.Show();
        }

        private void registroDeTalleresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrodeTalleres registrodeTalleres = new RegistrodeTalleres();
            registrodeTalleres.Show();
        }

        private void registroEntradaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaRegistroEntradaDeArticulos ventanaRegistroEntradaDeArticulos = new VentanaRegistroEntradaDeArticulos();

            ventanaRegistroEntradaDeArticulos.Show();
        }

       

        private void registroDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaRegistroDeArticulos registroDeArticulos = new VentanaRegistroDeArticulos();
          
            registroDeArticulos.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVehiculos cVehiculos = new CVehiculos();
            cVehiculos.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CArticulos cArticulos = new CArticulos();
            cArticulos.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CMantenimiento cMantenimiento = new CMantenimiento();
            cMantenimiento.Show();
        }
    }
}
