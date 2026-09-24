namespace Inventario_Apis.Models
{
    public class ProductoReponseDto
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string NombreProducto { get; set; }

    }


    public class InsertarProducto
    {
        public int IdCategoria { get; set; }
        public string NombreProducto { get; set; }



    }
}
