using Inventario_Apis.Data;
using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario_Apis.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        private readonly AppDbContext _context;

        public ClienteRepository(AppDbContext context)
        {
            _context = context; 
        }

        public async Task<IEnumerable<Cliente>> ListaCliente()
        {
            return await _context.Clientes
                .FromSqlRaw("sp_ListaCliente")
                .ToListAsync();
        }

        public async Task CrearCliente(Cliente cliente)
        
        {
            await _context.Database.ExecuteSqlRawAsync("EXEC sp_AgregarCliente @NombreCliente ={0}, @ApellidoCliente ={1}, @Telefono ={2}", cliente.NombreCliente,
                
                cliente.ApellidoCliente, cliente.Telefono);

        }

    }
}
