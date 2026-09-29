using Inventario_Apis.Data;
using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;
using Microsoft.EntityFrameworkCore;
namespace Inventario_Apis.Repositories

{
    public class VentaRepository : IVentaRepository
    {
        private readonly AppDbContext _context;


        public VentaRepository(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Venta>> ListaVenta()
        {

            return await _context.Ventas
                .FromSqlRaw("EXEC sp_ListaVenta")
                .ToListAsync(); 
        }


        public async Task CrearVenta(Venta venta)
        {
            await _context.Database.ExecuteSqlRawAsync("EXEC sp_AgregarVenta @IdCliente ={0}, @Fecha = {1}", venta.IdCliente, venta.Fecha);

        }


    }
}
