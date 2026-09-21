using System.ComponentModel.DataAnnotations;

namespace Inventario_Apis.Models
{
    public class Categoria
    {

        [Key]
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }

    }
}
