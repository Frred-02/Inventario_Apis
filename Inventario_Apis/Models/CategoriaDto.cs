namespace Inventario_Apis.Models
{
    
        public class CategoriaResponseDto
        {
            public int IdCategoria { get; set; }
            public string NombreCategoria { get; set; } = string.Empty;
        }

    public class InsertarCategoria
    {

        public string NombreCategoria { get; set; }
    }
   
}
