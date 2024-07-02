namespace DrugstoreOrders.Models
{
    public class PedidoManager
    {
        public string NombreMedicamento { get; set; } = string.Empty;
        public string TipoMedicamento { get; set; } = string.Empty;
        public int CantidadMedicamento { get; set; }
        public string Distribuidor { get; set; } = string.Empty;
        public string Sucursal { get; set; } = string.Empty;
    }
}
