using Segundo_Parcial.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Segundo_Parcial.UI.Registro
{
    public partial class RegistrodeTalleres : Form
    {
        public RegistrodeTalleres()
        {
            InitializeComponent();
        }
        private void RegistrodeTalleres_Load(object sender, EventArgs e)
        {

        }

        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && tallerIdNumericUpDown.Value == 0)
            {
                GenaralerrorProvider.SetError(tallerIdNumericUpDown, "Llenar taller Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(nombreTextBox.Text))
            {
                GenaralerrorProvider.SetError(nombreTextBox, "Llene Nombre");
                errores = true;
            }


            return errores;

        }
        private void Limpiar()
        {
            tallerIdNumericUpDown.Value = 0;
            nombreTextBox.Clear();
           

            GenaralerrorProvider.Clear();
        }
        private Talleres Llenaclase()
        {
            Talleres talleres = new Talleres();
            talleres.TallerId = Convert.ToInt32(tallerIdNumericUpDown.Value);
            talleres.Nombre = nombreTextBox.Text;
          

            return talleres;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar (Talleres Id) para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(tallerIdNumericUpDown.Value);
                Talleres talleres = BLL.TalleresBLL.Buscar(id);

                if (talleres != null)
                {
                    tallerIdNumericUpDown.Value = talleres.TallerId;
                    nombreTextBox.Text = talleres.Nombre;
               


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
                int id = Convert.ToInt32(tallerIdNumericUpDown.Value);

                if (BLL.TalleresBLL.Eliminar(id))
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

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Talleres talleres = Llenaclase();


            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (tallerIdNumericUpDown.Value == 0)
                {
                    paso = BLL.TalleresBLL.Guardar(talleres);
                }
                else
                {
                    var V = BLL.TalleresBLL.Buscar(Convert.ToInt32(tallerIdNumericUpDown.Value));

                    if (V != null)
                    {
                        paso = BLL.TalleresBLL.Editar(talleres);
                    }
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

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
