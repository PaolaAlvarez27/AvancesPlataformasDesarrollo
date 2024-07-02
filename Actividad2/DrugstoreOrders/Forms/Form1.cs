using System;
using System.Windows.Forms;
using DrugstoreOrders.Models;

namespace DrugstoreOrders.Forms
{
    public partial class Form1 : Form
    {
        private PedidoManager pedidoManager;

        public Form1()
        {
            InitializeComponent();
            pedidoManager = new PedidoManager();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombMedicam.Text) || string.IsNullOrEmpty(txtCantidadMedic.Text) ||
                (!rbDist1.Checked && !rbDist2.Checked && !rbDist3.Checked) ||
                (!cbPrincip.Checked && !cbSecund.Checked))
            {
                MessageBox.Show("Todos los campos deben estar diligenciados.");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombMedicam.Text, "^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("En 'Nombre del medicamento', no se permiten caracteres especiales, solo alfanuméricos.");
                return;
            }

            if (!int.TryParse(txtCantidadMedic.Text, out int cantidadMedicamento) || cantidadMedicamento <= 0)
            {
                MessageBox.Show("La cantidad de medicamento debe ser un número entero positivo.");
                return;
            }

            pedidoManager.NombreMedicamento = txtNombMedicam.Text;
            pedidoManager.TipoMedicamento = cbTipoMedic.SelectedItem?.ToString() ?? string.Empty;
            pedidoManager.CantidadMedicamento = cantidadMedicamento;

            if (rbDist1.Checked)
            {
                pedidoManager.Distribuidor = rbDist1.Text;
            }
            else if (rbDist2.Checked)
            {
                pedidoManager.Distribuidor = rbDist2.Text;
            }
            else if (rbDist3.Checked)
            {
                pedidoManager.Distribuidor = rbDist3.Text;
            }

            if (cbPrincip.Checked)
            {
                pedidoManager.Sucursal = cbPrincip.Text;
            }
            else if (cbSecund.Checked)
            {
                pedidoManager.Sucursal = cbSecund.Text;
            }

            // Abrir el segundo formulario con los detalles del pedido
            Form2 resumenForm = new Form2(pedidoManager);
            resumenForm.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNombMedicam.Text = string.Empty;
            txtCantidadMedic.Text = string.Empty;
            cbTipoMedic.SelectedIndex = 0;
            rbDist1.Checked = false;
            rbDist2.Checked = false;
            rbDist3.Checked = false;
            cbPrincip.Checked = false;
            cbSecund.Checked = false;

            pedidoManager = new PedidoManager();
        }
    }
}
