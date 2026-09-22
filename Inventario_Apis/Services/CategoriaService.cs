

using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;


namespace Inventario_Apis.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repo;

        public CategoriaService(ICategoriaRepository repo) => _repo = repo;


        public async Task<List<CategoriaResponseDto>> ListaCategoria()
        {

            var categorias = await _repo.ListaCategoria();
            return categorias.Select(MapToDto).ToList();


        }

        private static CategoriaResponseDto MapToDto(Categoria c) => new()
        {
            IdCategoria = c.IdCategoria,
            NombreCategoria = c.NombreCategoria
        };

        public async Task<CategoriaResponseDto>CrearCategoria(InsertarCategoria dto)
        {
            if (string.IsNullOrWhiteSpace(dto.NombreCategoria))
                throw new ArgumentException("Ingresar Nombre");

            var categoria = new Categoria { NombreCategoria = dto.NombreCategoria.Trim() };
            await _repo.CrearCategoria(categoria);
            return new CategoriaResponseDto { NombreCategoria = categoria.NombreCategoria };

        }


    }
}
