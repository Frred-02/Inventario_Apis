using Inventario_Apis.Models;

namespace Inventario_Apis.Interfaces
{
    public interface IProductoService
    {
        Task<List<CrearProductoReponseDto>> ListaProducto();
    }
}
