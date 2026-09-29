using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;

namespace Inventario_Apis.Services
{
    public class VentaService : IVentaService
    {
        private readonly IVentaRepository _repository;

        public VentaService(IVentaRepository repo) => _repository = repo;

        public async Task<List<VentaReponseDto>> ListaVenta()
        {
           

            var venta = await _repository.ListaVenta();
            return venta.Select(MapToDto).ToList();
        }


        private static VentaReponseDto MapToDto(Venta v) => new()
        {   IdVenta = v.IdVenta, 
            IdCliente = v.IdCliente,
            NombreCliente = v.NombreCliente,
            Fecha = v.Fecha,
            Estado = v.Estado,
        };

       public async  Task<VentaReponseDto>CrearVenta(InsertarVenta dto)
        {
            var venta = new Venta { IdCliente = dto.IdCliente, Fecha = dto.Fecha, };
            await _repository.CrearVenta(venta);
            return new VentaReponseDto { IdCliente = venta.IdCliente, Fecha = venta.Fecha, };
        }
    }
}
