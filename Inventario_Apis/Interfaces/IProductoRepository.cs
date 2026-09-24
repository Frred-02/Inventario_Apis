using Inventario_Apis.Models;

namespace Inventario_Apis.Interfaces
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> ListaProducto();
        Task CrearProducto(Producto producto);


    }
}
