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

namespace Segundo_Parcial.UI.Registro
{
    public partial class VentanaRegistroDeArticulos : Form
    {
        

        public VentanaRegistroDeArticulos()
        {
            InitializeComponent();
        }
        private bool validar(int error)
        {
            bool errores = false;

            if (error == 1 && articulosIdNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(articulosIdNumericUpDown, "Llenar ArticulosId Id");
                errores = true;
            }

            if (error == 2 &&  precioNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(precioNumericUpDown, "Llene precio");
                errores = true;
            }

            if (error == 2 && gananciaNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(gananciaNumericUpDown, "Llene Ganancia");
                errores = true;
            }

            if (error == 2 && costoNumericUpDown.Value == 0)
            {
                GeneralerrorProvider.SetError(costoNumericUpDown, "Llene Costo");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                GeneralerrorProvider.SetError(descripcionTextBox, "Llene Descripcion");
                errores = true;
            }
            if (error == 2 && string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                GeneralerrorProvider.SetError(descripcionTextBox, "Llene Descripcion");
                errores = true;
            }

            if (error == 2 && string.IsNullOrEmpty(inventarioTextBox.Text))
            {
                GeneralerrorProvider.SetError(inventarioTextBox, "Llene Inventario");
                errores = true;
            }


            return errores;

        }
       
        private void Limpiar()
        {
            articulosIdNumericUpDown.Value = 0;
           costoNumericUpDown.Value = 0;
            precioNumericUpDown.Value = 0;
            inventarioTextBox.Clear();
            descripcionTextBox.Clear();
            gananciaNumericUpDown.Value = 0;
            inventarioTextBox.Text = 0.ToString();


            GeneralerrorProvider.Clear();
        }
        
        private RegistrodeArticulos Llenaclase()
        {
            RegistrodeArticulos registrodearticulos = new RegistrodeArticulos();

            inventarioTextBox.Text = 0.ToString();
            registrodearticulos.ArticulosId = Convert.ToInt32(articulosIdNumericUpDown.Value);
            registrodearticulos.Descripcion = descripcionTextBox.Text;
            registrodearticulos.costo = Convert.ToInt32(costoNumericUpDown.Value);
            registrodearticulos.Ganancia = Convert.ToInt32(gananciaNumericUpDown.Value);
            registrodearticulos.precio = Convert.ToInt32(precioNumericUpDown.Value);
            registrodearticulos.Inventario = Convert.ToInt32(inventarioTextBox.Text);

            return registrodearticulos;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            RegistrodeArticulos registrodearticulos = Llenaclase();

            
            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (articulosIdNumericUpDown.Value == 0)
                {
                    paso = BLL.RegistrodeArticulosBLL.Guardar(registrodearticulos);
                }
                else
                {
                    paso = BLL.RegistrodeArticulosBLL.Editar(registrodearticulos);
                }
                Limpiar();
                GeneralerrorProvider.Clear();
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
                int id = Convert.ToInt32(articulosIdNumericUpDown.Value);
                RegistrodeArticulos registrodeArticulos = BLL.RegistrodeArticulosBLL.Buscar(id);

                if (registrodeArticulos != null)
                {
                    articulosIdNumericUpDown.Value = registrodeArticulos.ArticulosId;
                    descripcionTextBox.Text = registrodeArticulos.Descripcion;
                    costoNumericUpDown.Value = registrodeArticulos.costo;
                    gananciaNumericUpDown.Value = registrodeArticulos.Ganancia;
                    precioNumericUpDown.Value = registrodeArticulos.precio;
                    inventarioTextBox.Text = registrodeArticulos.Inventario.ToString();




                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralerrorProvider.Clear();
            }

            foreach (var item in BLL.RegistroEntradaDeArticulosBLL.GetList(x => x.Articulos == descripcionTextBox.Text))
            {
                inventarioTextBox.Text = item.Cantidad.ToString();
            }
        }

        

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(articulosIdNumericUpDown.Value);

                if (BLL.RegistrodeArticulosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralerrorProvider.Clear();
            }
        }

        private void VentanaRegistroDeArticulos_Load(object sender, EventArgs e)
        {

        }

        private void costoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToInt32(costoNumericUpDown.Value);
            decimal precio = Convert.ToInt32(precioNumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(gananciaNumericUpDown.Value);

            if (costoNumericUpDown.Value < precioNumericUpDown.Value && gananciaNumericUpDown.Value == 0)
            {
                gananciaNumericUpDown.Value = BLL.RegistrodeArticulosBLL.CalcularGanancia(costo,costo);
            }
            else
            
                if(costoNumericUpDown.Value > 0 && gananciaNumericUpDown.Value > 0 && precioNumericUpDown.Value == 0)
            {

                precioNumericUpDown.Value = BLL.RegistrodeArticulosBLL.CalcularPrecio(costo,ganancia);
            }
            
          
        }

        private void precioNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToDecimal(costoNumericUpDown.Value);
            decimal precio = Convert.ToDecimal(precioNumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(gananciaNumericUpDown.Value);

            if (precioNumericUpDown.Value > costoNumericUpDown.Value && gananciaNumericUpDown.Value == 0)
            {  
                gananciaNumericUpDown.Value = BLL.RegistrodeArticulosBLL.CalcularGanancia(costo, precio);

            }
            else
            if(precioNumericUpDown.Value > 0 && gananciaNumericUpDown.Value > 0 && costoNumericUpDown.Value == 0)
            {

                costoNumericUpDown.Value = BLL.RegistrodeArticulosBLL.CalcularCosto(ganancia, precio);
            }
            

             

        }

       

        private void gananciaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal costo = Convert.ToInt32(costoNumericUpDown.Value);
            decimal precio = Convert.ToInt32(precioNumericUpDown.Value);
            decimal ganancia = Convert.ToDecimal(gananciaNumericUpDown.Value);


            if (costoNumericUpDown.Value > 0 && gananciaNumericUpDown.Value > 0 && precioNumericUpDown.Value == 0)
            {

                precioNumericUpDown.Value = BLL.RegistrodeArticulosBLL.CalcularPrecio(costo, ganancia);
            }
            else
            if (precioNumericUpDown.Value > 0 && gananciaNumericUpDown.Value > 0 && costoNumericUpDown.Value == 0)
            {

                 costoNumericUpDown.Value = BLL.RegistrodeArticulosBLL.CalcularCosto(ganancia, precio);
            }

        }

       
        private void articulosIdNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

            
        }
    }
}
