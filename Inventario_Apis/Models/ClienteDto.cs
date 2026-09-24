namespace Inventario_Apis.Models
{
    public class ClienteReponseDto
    {

        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Telefono { get; set; }


    }


    public class InsertarCliente
    {
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Telefono { get; set; }


    }
}
