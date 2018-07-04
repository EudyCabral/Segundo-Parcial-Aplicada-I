using Segundo_Parcial.DAL;
using Segundo_Parcial.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Segundo_Parcial.UI
{
    public partial class VentanaRegistroEntradaDeArticulos : Form
    {
        public VentanaRegistroEntradaDeArticulos()
        {
            InitializeComponent();
            LlenaComboBox();
        }

        private void VentanaRegistroEntradaDeArticulos_Load(object sender, EventArgs e)
        {

        }

        private void LlenaComboBox()
        {
            Repositorio<RegistrodeArticulos> repositorio = new Repositorio<RegistrodeArticulos>(new Contexto());
            articulosComboBox.DataSource = repositorio.GetList(c => true);
            articulosComboBox.ValueMember = "ArticulosId";
            articulosComboBox.DisplayMember = "Descripcion"; 
        }

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && entradaIdNumericUpDown.Value == 0)
            {
                GenaralerrorProvider.SetError(entradaIdNumericUpDown, "Llenar Entrada Id");
                errores = true;
            }

            if (error == 2 && cantidadNumericUpDown.Value == 0)
            {
                GenaralerrorProvider.SetError(cantidadNumericUpDown, "Llene Nombre");
                errores = true;
            }


            return errores;

        }
        private void Limpiar()
        {
            entradaIdNumericUpDown.Value = 0;
            cantidadNumericUpDown.Value = 0;


            GenaralerrorProvider.Clear();
        }
        private RegistroEntradaDeArticulos Llenaclase()
        {
            RegistroEntradaDeArticulos articulos = new RegistroEntradaDeArticulos();
            articulos.EntradaId = Convert.ToInt32(entradaIdNumericUpDown.Value);
            articulos.Articulos = articulosComboBox.Text;
            articulos.Cantidad = Convert.ToInt32(cantidadNumericUpDown.Value);


            return articulos;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RegistroEntradaDeArticulos registroEntradaDeArticulos = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (entradaIdNumericUpDown.Value == 0)
                {
                    paso = BLL.RegistroEntradaDeArticulosBLL.Guardar(registroEntradaDeArticulos);
                }
                else
                {
                    paso = BLL.RegistroEntradaDeArticulosBLL.Editar(registroEntradaDeArticulos);
                }
                Limpiar();
                GenaralerrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(entradaIdNumericUpDown.Value);
                RegistroEntradaDeArticulos  registroEntradaDeArticulos= BLL.RegistroEntradaDeArticulosBLL.Buscar(id);

                if (registroEntradaDeArticulos != null)
                {
                    entradaIdNumericUpDown.Value = registroEntradaDeArticulos.EntradaId;
                    articulosComboBox.Text = registroEntradaDeArticulos.Articulos;
                    cantidadNumericUpDown.Value = registroEntradaDeArticulos.Cantidad;



                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GenaralerrorProvider.Clear();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar (Vehiculos Id) para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(entradaIdNumericUpDown.Value);

                if (BLL.RegistroEntradaDeArticulosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GenaralerrorProvider.Clear();
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void articulosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
