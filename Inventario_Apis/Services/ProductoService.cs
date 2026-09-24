using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;

namespace Inventario_Apis.Services
{
    public class ProductoService :IProductoService
    {
        private readonly IProductoRepository _repository;
        public ProductoService(IProductoRepository repository) => _repository = repository;

        public async Task<List<ProductoReponseDto>> ListaProducto()
        {
            var producto = await _repository.ListaProducto();
            return producto.Select(MapToDto).ToList();

        }

        public async Task<ProductoReponseDto>CrearProducto(InsertarProducto dto)
        {
            var producto = new Producto { NombreProducto = dto.NombreProducto.Trim(), IdCategoria = dto.IdCategoria };
            await _repository.CrearProducto(producto);
            return new ProductoReponseDto { NombreProducto = producto.NombreProducto, IdCategoria = producto.IdCategoria };
        }


        private static ProductoReponseDto MapToDto(Producto p) => new()
        {
            IdProducto = p.IdProducto,
            NombreProducto = p.NombreProducto,
            IdCategoria = p.IdCategoria,

        };

    }
}
