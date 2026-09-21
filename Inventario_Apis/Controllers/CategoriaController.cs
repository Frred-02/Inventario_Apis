using Inventario_Apis.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventario_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _service;
        public CategoriaController(ICategoriaService service) => _service = service;


        [HttpGet]
        public async Task<IActionResult> ObtenerTodas()
        {                                 //ICategoriaService
            var categorias = await _service.ListaCategoria();
            return Ok(categorias);
        }

    }
}
