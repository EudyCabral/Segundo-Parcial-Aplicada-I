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
    public partial class CArticulos : Form
    {
        public CArticulos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<RegistrodeArticulos, bool>> filtro = x => true;

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

                        filtro = x => x.ArticulosId == id;

                        if (BLL.RegistrodeArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este ID, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }


                    break;

                case 1://Descripcion

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(3))
                    {
                        MessageBox.Show("Debe Digitar una Descripcion!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        filtro = x => x.Descripcion.Contains(CriteriotextBox.Text);

                        if (BLL.RegistrodeArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Esta Descripcion, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 2://Costo

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
                        decimal costo = Convert.ToDecimal(CriteriotextBox.Text);
                        filtro = x => x.costo == costo;


                        if (BLL.RegistrodeArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Monto, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    break;

                case 3://Ganancia

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
                        decimal Ganancia = Convert.ToDecimal(CriteriotextBox.Text);
                        filtro = x => x.Ganancia == Ganancia;


                        if (BLL.RegistrodeArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este Monto, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }



                    break;

                case 4://precio
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
                        decimal precio = Convert.ToDecimal(CriteriotextBox.Text);
                        filtro = x => x.precio == precio;


                        if (BLL.RegistrodeArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("Este precio, No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    break;

                case 5://Inventario
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
                        decimal Invetario = Convert.ToDecimal(CriteriotextBox.Text);
                        filtro = x => x.Inventario == Invetario;


                        if (BLL.RegistrodeArticulosBLL.GetList(filtro).Count() == 0)
                        {
                            MessageBox.Show("No  hay Existencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                    break;

                case 6://Todo
                    filtro = x => true;
                    break;
            }

            ArticulosdataGridView.DataSource = BLL.RegistrodeArticulosBLL.GetList(filtro);
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

        private void CArticulos_Load(object sender, EventArgs e)
        {

        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {

        }

        private void ArticulosdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CriteriotextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
