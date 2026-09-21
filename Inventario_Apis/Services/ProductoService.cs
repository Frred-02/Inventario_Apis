using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;

namespace Inventario_Apis.Services
{
    public class ProductoService :IProductoService
    {
        private readonly IProductoRepository _repository;
        public ProductoService(IProductoRepository repository) => _repository = repository;

        public async Task<List<CrearProductoReponseDto>> ListaProducto()
        {
            var producto = await _repository.ListaProducto();
            return producto.Select(MapToDto).ToList();

        }

        private static CrearProductoReponseDto MapToDto(Producto p) => new()
        {
            IdProducto = p.IdProducto,
            NombreProducto = p.NombreProducto,
            IdCategoria = p.IdCategoria,

        };

    }
}
