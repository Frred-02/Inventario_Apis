namespace Inventario_Apis.Models
{
    public class VentaReponseDto
    {
        public int IdVenta { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }


    }


    public class InsertarVenta
    {
        public int IdCliente { get; set; }
        public DateTime Fecha { get; set; }
        //public string Estado { get; set; }
    }
}
