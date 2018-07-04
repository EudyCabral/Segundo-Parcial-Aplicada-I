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
    public partial class RegistroDeMantenimiento : Form
    {
        decimal itbis = 0;
        decimal importe = 0;
        decimal Total = 0;
        public RegistroDeMantenimiento()
        {
            InitializeComponent();
            LlenarComboBox();
        }
        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;

        }
        public void Limpiar()
        {
            mantenimientoIdNumericUpDown.Value = 0;
            fechaDateTimePicker.Value = DateTime.Now;
            cantidadNumericUpDown.Value = 0;
            TotaltextBox.Clear();
            precioTextBox.Clear();
            importeTextBox.Clear();
            subtotaltextBox.Clear();
            TotaltextBox.Clear();
            DetalledataGridView.DataSource = null;
            HayErrores.Clear();
        }

        private RegistrodeMantenimiento LlenaClase()
        {
            RegistrodeMantenimiento registrodeMantenimiento = new RegistrodeMantenimiento();

            registrodeMantenimiento.MantenimientoId = Convert.ToInt32(mantenimientoIdNumericUpDown.Value);
            registrodeMantenimiento.Fecha = fechaDateTimePicker.Value;
           


            //Agregar cada linea del Grid al detalle
            foreach (DataGridViewRow item in DetalledataGridView.Rows)
            {

                registrodeMantenimiento.AgregarDetalle
                    (
                     
                     ToInt(item.Cells["articulosId"].Value),
                      Convert.ToString(item.Cells["descripcion"].Value),
                       ToInt(item.Cells["cantidad"].Value),
                    ToInt(item.Cells["precio"].Value),
                    ToInt(item.Cells["importe"].Value)
                  

                  
                  );
            }
            return registrodeMantenimiento;
        }
        private void LlenarComboBox()
        {
            Repositorio<Vehiculos> vehiculos= new Repositorio<Vehiculos>(new Contexto());
            vehiculoComboBox.DataSource = vehiculos.GetList(c => true);
            vehiculoComboBox.ValueMember = "VehiculosId";
            vehiculoComboBox.DisplayMember = "Descripcion";

            Repositorio<Talleres> talleres = new Repositorio<Talleres>(new Contexto());
            tallerComboBox.DataSource = talleres.GetList(c => true);
            tallerComboBox.ValueMember = "TallerId";
            tallerComboBox.DisplayMember = "Nombre";

            Repositorio<RegistroEntradaDeArticulos> Entrada = new Repositorio<RegistroEntradaDeArticulos>(new Contexto());
            articulosComboBox.DataSource = Entrada.GetList(c => true);
            articulosComboBox.ValueMember = "EntradaId";
            articulosComboBox.DisplayMember = "Articulos";
        }
        private void RegistroDeMantenimiento_Load(object sender, EventArgs e)
        {
            

                DateTime fecha = Convert.ToDateTime(fechaproximaDateTimePicker.Text);
                fecha = fecha.AddDays(90);

                fechaproximaDateTimePicker.Text = fecha.ToString();
        
        }

        private void articulosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in BLL.RegistrodeArticulosBLL.GetList(x => x.Descripcion == articulosComboBox.Text))
            {
                precioTextBox.Text = item.precio.ToString();

            }
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            List<RegistrodeMantenimientoDetalle> detalle = new List<RegistrodeMantenimientoDetalle>();
            RegistrodeMantenimiento registrodeMantenimiento = new RegistrodeMantenimiento();

            if (DetalledataGridView.DataSource != null)
            {
                registrodeMantenimiento.Detalle = (List<RegistrodeMantenimientoDetalle>)DetalledataGridView.DataSource;
            }

            //Agregar un nuevo detalle con los datos introducidos.

            if (string.IsNullOrEmpty(importeTextBox.Text))
            {
                MessageBox.Show("Importe esta vacio , Llene cantidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                registrodeMantenimiento.Detalle.Add(
                    new RegistrodeMantenimientoDetalle(id : 0,
                    mantenimientoId: (int)Convert.ToInt32(mantenimientoIdNumericUpDown.Value),
                    vehiculoId: (int)vehiculoComboBox.SelectedValue,
                    tallerId: (int) tallerComboBox.SelectedValue,
                       articulosId: (int)articulosComboBox.SelectedValue,
                       entradaId:(int)articulosComboBox.SelectedValue,
                            articulo: (string)BLL.RegistroEntradaDeArticulosBLL.RetornarDescripcion(articulosComboBox.Text),
                        cantidad: (int)Convert.ToInt32(cantidadNumericUpDown.Value),
                        precio: (int)Convert.ToInt32(precioTextBox.Text),
                        importe: (int)Convert.ToInt32(importeTextBox.Text)

                    ));
           


                //Cargar el detalle al Grid
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = registrodeMantenimiento.Detalle;

            }
                importe += BLL.RegistrodeMantenimientoBLL.CalcularImporte(Convert.ToDecimal(precioTextBox.Text), Convert.ToInt32(cantidadNumericUpDown.Value));



            itbis = BLL.RegistrodeMantenimientoBLL.CalcularImporte(Convert.ToDecimal(precioTextBox.Text), Convert.ToInt32(cantidadNumericUpDown.Value)) * Convert.ToDecimal(0.18);

            subtotaltextBox.Text = importe.ToString();

            ItbistextBox.Text = itbis.ToString();

            Total = importe + itbis;
            TotaltextBox.Text = Total.ToString();
        }

        private void cantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
           
                importeTextBox.Text = BLL.RegistrodeMantenimientoBLL.CalcularImporte(Convert.ToInt32(precioTextBox.Text), Convert.ToInt32(cantidadNumericUpDown.Value)).ToString(); ;
            
        }

        private void fechaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            
                fechaproximaDateTimePicker.Value = fechaDateTimePicker.Value;


                DateTime fecha = Convert.ToDateTime(fechaproximaDateTimePicker.Text);
                fecha = fecha.AddDays(90);

                fechaproximaDateTimePicker.Text = fecha.ToString();
      
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }

        private bool Validar(int error)
        {
            bool paso = false;



            if (error == 1 && mantenimientoIdNumericUpDown.Value == 0)
            {
                HayErrores.SetError(mantenimientoIdNumericUpDown,
                   "No debes dejar la Cotizacion Id Vacio");
                paso = true;
            }
            if (error == 2 && String.IsNullOrWhiteSpace(TotaltextBox.Text))
            {
                HayErrores.SetError(TotaltextBox,
                   "No debes dejar la Observacion vacia");
                paso = true;
            }

            if (error == 2 && DetalledataGridView.RowCount == 0)
            {
                HayErrores.SetError(DetalledataGridView,
                    "Es obligatorio Agregar un Articulo ");
                paso = true;
            }

            if (error == 3 && string.IsNullOrEmpty(importeTextBox.Text))
            {
                HayErrores.SetError(importeTextBox,
                    "Es obligatorio Agregar un Articulo ");
                paso = true;
            }

            return paso;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {


                MessageBox.Show("Favor Llenar Casilla!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int id = Convert.ToInt32(mantenimientoIdNumericUpDown.Value);
                if (BLL.RegistrodeMantenimientoBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RegistrodeMantenimiento registrodeMantenimiento = LlenaClase();
            bool Paso = false;

            if (Validar(2))
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //Determinar si es Guardar o Modificar


            if (mantenimientoIdNumericUpDown.Value == 0)
            {
                Paso = BLL.RegistrodeMantenimientoBLL.Guardar(registrodeMantenimiento);
                HayErrores.Clear();
            }
            else
            {

                Paso = BLL.RegistrodeMantenimientoBLL.Editar(registrodeMantenimiento);
                HayErrores.Clear();
            }


            //Esto es para en caso de que se elimine algun elemento del datagrid y se modifique que elimine el detalle 

            //Informar el resultado
            if (Paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
