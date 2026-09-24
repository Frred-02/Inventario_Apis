using Inventario_Apis.Interfaces;
using Inventario_Apis.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventario_Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService) => _clienteService = clienteService;

        [HttpGet]
        public async Task<IActionResult> ObtenerClientes()
        {
            var clientes = await _clienteService.ListaCliente();
            return Ok(clientes);
        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] InsertarCliente dto)
        {
            try
            {
                var cliente = await _clienteService.CrearCliente(dto);
                return Ok(cliente);



            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        
        }


    }
}
