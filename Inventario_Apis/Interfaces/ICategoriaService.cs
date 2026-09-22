

using Inventario_Apis.Models;

namespace Inventario_Apis.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<CategoriaResponseDto>> ListaCategoria();
        Task<CategoriaResponseDto> CrearCategoria(InsertarCategoria dto);
       
    }
}
