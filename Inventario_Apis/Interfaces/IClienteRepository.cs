using Inventario_Apis.Models;

namespace Inventario_Apis.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> ListaCliente();
      


    }
}
