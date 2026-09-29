using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventario_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IVentaService _ventaService;   

        public VentaController (IVentaService service) => _ventaService = service;

        [HttpGet]
        public  async Task<IActionResult> ObtenerTodas() {

            var venta = await _ventaService.ListaVenta();
            return Ok(venta);

        
        }

        [HttpPost]

        public async Task<IActionResult> Crear([FromBody] InsertarVenta dto)
        {
            try
            {
                var venta = await _ventaService.CrearVenta(dto);
                return Ok(venta);   
            }
            catch (ArgumentException ex) { return BadRequest(ex.Message); }
            {

                
            }
        }


    }
}
