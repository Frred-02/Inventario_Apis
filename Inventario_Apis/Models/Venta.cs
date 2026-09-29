namespace Inventario_Apis.Models
{
    public class Venta
    {
        public int IdVenta { get; set; }    
        public int IdCliente { get; set; } 
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}
