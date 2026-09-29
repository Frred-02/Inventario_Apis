using Inventario_Apis.Models;
using System.Collections;

namespace Inventario_Apis.Interfaces
{
    public interface IVentaRepository
    {
        Task<IEnumerable<Venta>> ListaVenta();
        Task CrearVenta(Venta venta);
    }
}
