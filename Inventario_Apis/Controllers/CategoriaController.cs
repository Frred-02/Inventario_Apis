using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;
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
        {                                 
            var categorias = await _service.ListaCategoria();
            return Ok(categorias);
        }

        [HttpPost]

        public async Task<IActionResult> Crear([FromBody] InsertarCategoria dto)
        {
            try
            {
                var categoria = await _service.CrearCategoria(dto); 
                 return Ok(categoria);  

            }
            catch (ArgumentException ex) { return BadRequest(ex.Message); }
            {

                
            }
        }


    }
}
