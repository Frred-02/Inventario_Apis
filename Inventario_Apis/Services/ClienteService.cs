using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;

namespace Inventario_Apis.Services
{
    public class ClienteService :IClienteService
    {

        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository repo) => _clienteRepository = repo;


        public async Task<List<ClienteReponseDto>> ListaCliente()
        {
            var clientes = await _clienteRepository.ListaCliente();
            return clientes.Select(MapToDto).ToList();

        }


        public async Task<ClienteReponseDto>CrearCliente(InsertarCliente dto)
        {

            var cliente = new Cliente { NombreCliente = dto.NombreCliente.Trim(), ApellidoCliente = dto.ApellidoCliente.Trim(),
            Telefono =dto.Telefono.Trim()};
            await _clienteRepository.CrearCliente(cliente);
            return new ClienteReponseDto { NombreCliente = cliente.NombreCliente, ApellidoCliente = cliente.ApellidoCliente,
            Telefono = cliente.Telefono};
              

        }


        private static ClienteReponseDto MapToDto(Cliente c) => new()
        {
            IdCliente = c.IdCliente,
            NombreCliente = c.NombreCliente,
            ApellidoCliente = c.ApellidoCliente,
            Telefono = c.Telefono

        };

    }
}
