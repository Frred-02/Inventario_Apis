using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario_Apis.Models
{

    [Table("Producto")]
    public class Producto
    {

        [Key]
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string NombreProducto { get; set; }
    }
}
