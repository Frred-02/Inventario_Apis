using Inventario_Apis.Models;

namespace Inventario_Apis.Interfaces
{
    public interface IProductoService
    {
        Task<List<ProductoReponseDto>> ListaProducto();
        Task<ProductoReponseDto> CrearProducto(InsertarProducto producto);
    }
}
