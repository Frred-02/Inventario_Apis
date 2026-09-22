using Inventario_Apis.Models;

namespace Inventario_Apis.Interfaces
{
    public interface IClienteService
    {

        Task<List<ClienteReponseDto>> ListaCliente();

    }
}
