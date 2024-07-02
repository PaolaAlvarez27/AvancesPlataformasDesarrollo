using System;
using System.Windows.Forms;
using DrugstoreOrders.Models;

namespace DrugstoreOrders.Forms
{
    public partial class Form2 : Form
    {
        private PedidoManager pedidoManager;

        public Form2(PedidoManager pedido)
        {
            InitializeComponent();
            pedidoManager = pedido;
            DisplayPedido();
        }

        private void DisplayPedido()
        {
            string direccion = pedidoManager.Sucursal == "Principal" ? "Calle de la Rosa n. 28" : "Calle Alcazabilla n. 3";

            lblResumen.Text = $"Pedido al distribuidor: {pedidoManager.Distribuidor}\n" +
                              $"{pedidoManager.CantidadMedicamento} Unidades de {pedidoManager.TipoMedicamento} {pedidoManager.NombreMedicamento}\n" +
                              $"Para la farmacia situada en {direccion}";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Lógica para enviar el pedido
            MessageBox.Show("Pedido enviado.");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
