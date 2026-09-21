using Inventario_Apis.Data;
using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario_Apis.Repositories
{
    public class ProductoRepository : IProductoRepository 
    {

        private readonly AppDbContext _context;


        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> ListaProducto()
        {

            return await _context.Productos
                .FromSqlRaw("EXEC  sp_listaProductos")
                .ToListAsync();
        }
    }

}
