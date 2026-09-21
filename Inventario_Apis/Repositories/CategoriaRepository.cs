using Microsoft.EntityFrameworkCore;
using Inventario_Apis.Data;
using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;

namespace Inventario_Apis.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }



        public async Task<IEnumerable<Categoria>> ListaCategoria()
        {
            return await _context.Categorias
                .FromSqlRaw("EXEC sp_ListaCategoria")
                .ToListAsync();
        }




    }
}
