using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventario_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _service;

        public ProductoController(IProductoService service) => _service = service;


        [HttpGet]
        public async Task<IActionResult> ObtenerProductos()
        {
            var producto = await _service.ListaProducto();
            return Ok(producto);

        }

        [HttpPost]

        public async Task<IActionResult> Crear([FromBody]InsertarProducto dto)
        {
            try
            {
                var producto = await _service.CrearProducto(dto);
                return Ok(producto);    
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }

    }
}
