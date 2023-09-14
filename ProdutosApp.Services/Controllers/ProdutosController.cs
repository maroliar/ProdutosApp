using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdutosApp.Services.Models;

namespace ProdutosApp.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        /// <summary>
        /// Serviço para cadastro de produtos.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(ProdutosGetModel), 201)]
        public IActionResult Post([FromBody] ProdutosPostModel model)
        {
            //HTTP 201 - CREATED!
            return StatusCode(201);
        }

        /// <summary>
        /// Serviço para edição de produtos.
        /// </summary>
        [HttpPut]
        [ProducesResponseType(typeof(ProdutosGetModel), 200)]
        public IActionResult Put([FromBody] ProdutosPutModel model)
        {
            //HTTP 200 - OK!
            return StatusCode(200);
        }

        /// <summary>
        /// Serviço para exclusão de produtos.
        /// </summary>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ProdutosGetModel), 200)]
        public IActionResult Delete(Guid id)
        {
            //HTTP 200 - OK!
            return StatusCode(200);
        }

        /// <summary>
        /// Serviço para consulta de produtos.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(List<ProdutosGetModel>), 200)]
        public IActionResult GetAll()
        {
            //HTTP 200 - OK!
            return StatusCode(200);
        }

        /// <summary>
        /// Serviço para consulta de 1 produto através do ID (código identificador).
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProdutosGetModel), 200)]
        public IActionResult GetById(Guid id)
        {
            //HTTP 200 - OK!
            return StatusCode(200);
        }
    }
}



