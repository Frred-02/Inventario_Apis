using Inventario_Apis.Interfaces;
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
    }
}
