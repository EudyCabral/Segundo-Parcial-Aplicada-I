﻿using Segundo_Parcial.DAL;
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

            if (error == 2 &&  string.IsNullOrWhiteSpace(precioTextBox.Text))
            {
                GeneralerrorProvider.SetError(precioTextBox, "Llene precio");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(gananciaTextBox.Text))
            {
                GeneralerrorProvider.SetError(gananciaTextBox, "Llene Ganancia");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(costoTextBox.Text))
            {
                GeneralerrorProvider.SetError(costoTextBox, "Llene Costo");
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
           costoTextBox.Clear();
            precioTextBox.Clear();
            inventarioTextBox.Clear();
            descripcionTextBox.Clear();
            gananciaTextBox.Clear();
            inventarioTextBox.Text = 0.ToString();


            GeneralerrorProvider.Clear();
        }
        
        private RegistrodeArticulos Llenaclase()
        {
            RegistrodeArticulos registrodearticulos = new RegistrodeArticulos();

            inventarioTextBox.Text = 0.ToString();
            registrodearticulos.ArticulosId = Convert.ToInt32(articulosIdNumericUpDown.Value);
            registrodearticulos.Descripcion = descripcionTextBox.Text;
            registrodearticulos.costo = Convert.ToDecimal(costoTextBox.Text);
            registrodearticulos.Ganancia = Convert.ToDecimal(gananciaTextBox.Text);
            registrodearticulos.precio = Convert.ToDecimal(precioTextBox.Text);
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
                    var V = BLL.RegistrodeArticulosBLL.Buscar(Convert.ToInt32(articulosIdNumericUpDown.Value));

                    if (V != null)
                    {
                        paso = BLL.RegistrodeArticulosBLL.Editar(registrodearticulos);
                    }
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
                    costoTextBox.Text = registrodeArticulos.costo.ToString();
                    gananciaTextBox.Text = registrodeArticulos.Ganancia.ToString();
                    precioTextBox.Text = registrodeArticulos.precio.ToString();
                    inventarioTextBox.Text = registrodeArticulos.Inventario.ToString();




                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GeneralerrorProvider.Clear();
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
    

        private void costoTextBox_TextChanged(object sender, EventArgs e)
        {

    
                if (precioTextBox.Text != string.Empty && costoTextBox.Text != string.Empty && Convert.ToDecimal(costoTextBox.Text) < Convert.ToDecimal(precioTextBox.Text))
                {
                    gananciaTextBox.Text = BLL.RegistrodeArticulosBLL.CalcularGanancia(Convert.ToDecimal(costoTextBox.Text), Convert.ToDecimal(precioTextBox.Text)).ToString();
                    return;
                }



            if (gananciaTextBox.Text != string.Empty && costoTextBox.Text != string.Empty)
            {
                precioTextBox.Text = BLL.RegistrodeArticulosBLL.CalcularPrecio(Convert.ToDecimal(costoTextBox.Text), Convert.ToDecimal(gananciaTextBox.Text)).ToString();
                return;
            }


        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {


           
  
                if (precioTextBox.Text != string.Empty  && costoTextBox.Text != string.Empty && Convert.ToDecimal(costoTextBox.Text) < Convert.ToDecimal(precioTextBox.Text))
                {
                    gananciaTextBox.Text = BLL.RegistrodeArticulosBLL.CalcularGanancia(Convert.ToDecimal(costoTextBox.Text), Convert.ToDecimal(precioTextBox.Text)).ToString();
                    return;
                }
     

        }

        private void gananciaTextBox_TextChanged(object sender, EventArgs e)
        {

               if ( gananciaTextBox.Text != string.Empty && costoTextBox.Text != string.Empty)
                {
                    precioTextBox.Text = BLL.RegistrodeArticulosBLL.CalcularPrecio(Convert.ToDecimal(costoTextBox.Text), Convert.ToDecimal(gananciaTextBox.Text)).ToString();
                    return;
                }
           

        }

       
    }
}

