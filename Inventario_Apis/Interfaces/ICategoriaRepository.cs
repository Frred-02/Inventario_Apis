using Inventario_Apis.Models;

namespace Inventario_Apis.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> ListaCategoria();

    }
}
