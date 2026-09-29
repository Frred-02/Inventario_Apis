using Inventario_Apis.Models;

namespace Inventario_Apis.Interfaces
{
    public interface IVentaService
    {

        Task<List<VentaReponseDto>> ListaVenta();

        Task<VentaReponseDto> CrearVenta(InsertarVenta dto);


    }
}
