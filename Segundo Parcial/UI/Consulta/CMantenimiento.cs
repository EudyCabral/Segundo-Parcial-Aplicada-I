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

namespace Segundo_Parcial.UI.Consulta
{
    public partial class CMantenimiento : Form
    {
        public CMantenimiento()
        {
            InitializeComponent();
        }

        private void CMantenimiento_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<RegistrodeMantenimiento, bool>> filtro = x => true;

            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0://Id

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int id = Convert.ToInt32(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.MantenimientoId == id &&(desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);
                        }
                        else
                        {
                            filtro = x => x.MantenimientoId == id;
                        }


                        if (BLL.RegistrodeMantenimientoBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }


                    break;

                case 1://VehiculoId

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        int vehiculoid = Convert.ToInt32(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.VehiculoId == vehiculoid  && (desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);
                        }
                        else
                        {
                            filtro = x => x.VehiculoId == vehiculoid;
                        }

                        

                        if (BLL.RegistrodeMantenimientoBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 2://Subtotal

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal subtotal = Convert.ToDecimal(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Subtotal == subtotal && (desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);

                        }
                        else
                        {

                            filtro = x => x.Subtotal == subtotal;
                        }

                        if (BLL.RegistrodeMantenimientoBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 3://Itbis

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal itbis = Convert.ToDecimal(CriteriotextBox.Text);

                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.itbis == itbis && (desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);
                        }
                        else
                        {
                            filtro = x => x.itbis == itbis;
                        }

                        if (BLL.RegistrodeMantenimientoBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    break;

                case 4://Total

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        decimal total = Convert.ToDecimal(CriteriotextBox.Text);
                        if (FechacheckBox.Checked == true)
                        {
                            filtro = x => x.Total == total  && (desdedateTimePicker.Value >= x.Fecha && HastadateTimePicker.Value <= x.Fecha);
                        }
                        else
                        {
                            filtro = x => x.Total == total;
                        }


                        if (BLL.RegistrodeMantenimientoBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 5:
                    filtro = x => true;
                    break;

             
            }


            MantenimientodataGridView.DataSource = BLL.RegistrodeMantenimientoBLL.GetList(filtro);


            MantenimientodataGridView.Columns["Detalle"].Visible = false;
            



            CriteriotextBox.Clear();
            GeneralerrorProvider.Clear();
        }


        private bool Validar(int error)
        {
            bool paso = false;
            int num = 0;

            if (error == 1 && string.IsNullOrEmpty(CriteriotextBox.Text))
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Por Favor, LLenar Casilla!");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out num) == false)
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Debe Digitar un Numero");
                paso = true;
            }

            if (error == 3 && int.TryParse(CriteriotextBox.Text, out num) == true)
            {
                GeneralerrorProvider.SetError(CriteriotextBox, "Debe Digitar Caracteres");
                paso = true;
            }

            return paso;
        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
