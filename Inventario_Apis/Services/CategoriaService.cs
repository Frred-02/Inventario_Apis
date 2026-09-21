

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


    }
}
