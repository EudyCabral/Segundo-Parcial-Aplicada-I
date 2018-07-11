using Segundo_Parcial.DAL;
using Segundo_Parcial.ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace Segundo_Parcial.UI.Registro
{
    public partial class RegistroDeMantenimiento : Form
    {
        decimal itbis = 0;
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

            importeTextBox.Clear();
            subtotaltextBox.Text = 0.ToString();
            TotaltextBox.Text = 0.ToString();
            ItbistextBox.Text = 0.ToString();
            DetalledataGridView.DataSource = null;

            itbis = 0;
             Total = 0;

            HayErrores.Clear();
        }

        public void NoColumnas()
        {
            DetalledataGridView.Columns["MantenimientoId"].Visible = false;
            DetalledataGridView.Columns["Id"].Visible = false;
            DetalledataGridView.Columns["MantenimientoId"].Visible = false;
            DetalledataGridView.Columns["TallerId"].Visible = false;
            DetalledataGridView.Columns["ArticulosId"].Visible = false;
            DetalledataGridView.Columns["RegistrodeArticulos"].Visible = false;
        }



        private RegistrodeMantenimiento LlenaClase()
        {
            RegistrodeMantenimiento registrodeMantenimiento = new RegistrodeMantenimiento();

            registrodeMantenimiento.MantenimientoId = Convert.ToInt32(mantenimientoIdNumericUpDown.Value);
            registrodeMantenimiento.VehiculoId = Convert.ToInt32(vehiculoComboBox.SelectedValue);
            registrodeMantenimiento.Fecha = fechaDateTimePicker.Value;
            registrodeMantenimiento.Subtotal = Convert.ToDecimal(subtotaltextBox.Text);
            registrodeMantenimiento.itbis = Convert.ToDecimal(ItbistextBox.Text);
            registrodeMantenimiento.Total = Convert.ToDecimal(TotaltextBox.Text);



            //Agregar cada linea del Grid al detalle
            foreach (DataGridViewRow item in DetalledataGridView.Rows)
            {

                registrodeMantenimiento.AgregarDetalle
                    (ToInt(item.Cells["id"].Value),
                     registrodeMantenimiento.MantenimientoId,
                       ToInt(item.Cells["tallerId"].Value),
                     ToInt(item.Cells["articulosId"].Value),
                      Convert.ToString(item.Cells["articulo"].Value),
                       ToInt(item.Cells["cantidad"].Value),
                    ToInt(item.Cells["precio"].Value),
                    ToInt(item.Cells["importe"].Value)
                  

                  
                  );
            }
            return registrodeMantenimiento;
        }




        private void LlenarCampos(RegistrodeMantenimiento registrodeMantenimiento)
        {
            Limpiar();
            mantenimientoIdNumericUpDown.Value = registrodeMantenimiento.MantenimientoId;
            fechaDateTimePicker.Value = registrodeMantenimiento.Fecha;
            subtotaltextBox.Text= registrodeMantenimiento.Subtotal.ToString();
            ItbistextBox.Text = registrodeMantenimiento.itbis.ToString();
            TotaltextBox.Text = registrodeMantenimiento.Total.ToString();

    
            //Cargar el detalle al Grid
            DetalledataGridView.DataSource = registrodeMantenimiento.Detalle;
        
            NoColumnas();

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

            Repositorio<RegistrodeArticulos> Entrada = new Repositorio<RegistrodeArticulos>(new Contexto());
            articulosComboBox.DataSource = Entrada.GetList(c => true);
            articulosComboBox.ValueMember = "ArticulosId";
            articulosComboBox.DisplayMember = "Descripcion";
        }


        private void RegistroDeMantenimiento_Load(object sender, EventArgs e)
        {
            
                DateTime fecha = Convert.ToDateTime(fechaproximaDateTimePicker.Text);
                fecha = fecha.AddMonths(3);
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

           

            if (DetalledataGridView.DataSource != null)
            {
                detalle = (List<RegistrodeMantenimientoDetalle>)DetalledataGridView.DataSource;
            }

            //Agregar un nuevo detalle con los datos introducidos.

            foreach (var item in BLL.RegistrodeArticulosBLL.GetList(x => x.Inventario < cantidadNumericUpDown.Value))
            {
                
                MessageBox.Show("No hay esa Existencia para Vender ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            
                if (string.IsNullOrEmpty(importeTextBox.Text))
                {
                    MessageBox.Show("Importe esta vacio , Llene cantidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    detalle.Add(
                        new RegistrodeMantenimientoDetalle(id: 0,
                        mantenimientoId: (int)Convert.ToInt32(mantenimientoIdNumericUpDown.Value),
                        tallerId: (int)tallerComboBox.SelectedValue,
                           articulosId: (int)articulosComboBox.SelectedValue,
                                articulo: (string)BLL.RegistrodeArticulosBLL.RetornarDescripcion(articulosComboBox.Text),
                            cantidad: (int)Convert.ToInt32(cantidadNumericUpDown.Value),
                            precio: (int)Convert.ToInt32(precioTextBox.Text),
                            importe: (int)Convert.ToInt32(importeTextBox.Text)

                        ));

                //Cargar el detalle al Grid
                    DetalledataGridView.DataSource = null;
                    DetalledataGridView.DataSource = detalle;

               
                NoColumnas();


                }

            decimal subtotal = 0;

            foreach (var item in detalle)
            {
                subtotal += item.Importe;

            }

                    
                    subtotaltextBox.Text = subtotal.ToString();
                
                itbis = BLL.RegistrodeMantenimientoBLL.CalcularItbis(Convert.ToDecimal(subtotaltextBox.Text));

                ItbistextBox.Text = itbis.ToString();

                Total = BLL.RegistrodeMantenimientoBLL.Total(Convert.ToDecimal(subtotaltextBox.Text), Convert.ToDecimal(ItbistextBox.Text));

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
                fecha = fecha.AddMonths(3);

                fechaproximaDateTimePicker.Text = fecha.ToString();
      
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(mantenimientoIdNumericUpDown.Value);
            RegistrodeMantenimiento registrodemantenimiento = BLL.RegistrodeMantenimientoBLL.Buscar(id);

            if (registrodemantenimiento != null)
            {
                LlenarCampos(registrodemantenimiento);

            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (Validar(2))
            {
                MessageBox.Show("Debe Agregar Algun Producto al Grid", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {

                RegistrodeMantenimiento registrodeMantenimiento = LlenaClase();
                bool Paso = false;

                //Determinar si es Guardar o Modificar


                if (mantenimientoIdNumericUpDown.Value == 0)
                {
                    Paso = BLL.RegistrodeMantenimientoBLL.Guardar(registrodeMantenimiento);
                    HayErrores.Clear();
                }
                else
                {
                    var V = BLL.RegistrodeMantenimientoBLL.Buscar(Convert.ToInt32(mantenimientoIdNumericUpDown.Value));

                    if (V != null)
                    {
                        Paso = BLL.RegistrodeMantenimientoBLL.Editar(registrodeMantenimiento);
                    }
                    HayErrores.Clear();
                }



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



        private void Removerbutton_Click(object sender, EventArgs e)
        {
            RegistrodeMantenimientoDetalle mantenimiento = new RegistrodeMantenimientoDetalle();
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                //convertir el grid en la lista
                List<RegistrodeMantenimientoDetalle> detalle = (List<RegistrodeMantenimientoDetalle>)DetalledataGridView.DataSource;

                //remover la fila             
                detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);

                decimal subtotal = 0;

                foreach (var item in detalle)
                {
                    subtotal -= item.Importe;
                }

                subtotal *= (-1);
                subtotaltextBox.Text = subtotal.ToString();

                itbis = BLL.RegistrodeMantenimientoBLL.CalcularItbis(Convert.ToDecimal(subtotaltextBox.Text));
                ItbistextBox.Text = itbis.ToString();

                Total = BLL.RegistrodeMantenimientoBLL.Total(Convert.ToDecimal(subtotaltextBox.Text),Convert.ToDecimal(ItbistextBox.Text));

                TotaltextBox.Text = Total.ToString(); 

                

                // Cargar el detalle al Grid
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = detalle;

              
                NoColumnas();
            }

        }



        private bool Validar(int error)
        {
            bool paso = false;



            if (error == 1 && mantenimientoIdNumericUpDown.Value == 0)
            {
                HayErrores.SetError(mantenimientoIdNumericUpDown,
                   "No debes dejar la Mantenimiento Id Vacio");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(TotaltextBox.Text))
            {
                HayErrores.SetError(TotaltextBox,
                   "No debes dejar la total vacio");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(subtotaltextBox.Text))
            {
                HayErrores.SetError(subtotaltextBox,
                   "No debes dejar la subtotal vacio");
                paso = true;
            }
            if (error == 2 && string.IsNullOrWhiteSpace(ItbistextBox.Text))
            {
                HayErrores.SetError(ItbistextBox,
                   "No debes dejar la Itbis vacio");
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


    }
}
