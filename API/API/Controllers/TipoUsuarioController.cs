using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using API.Context;
using API.Infrastructure;
using API.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class TipoUsuarioController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public TipoUsuarioController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// Obtengo todos los tipos de usuario
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /GetAll
        ///     {
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("GetAll")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<TipoUsuario>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetAll()
        {
            var result = _context.TipoUsuario.AsEnumerable();

            return new ObjectResult(result);
        }

        /// <summary>
        /// Doy de alta un TipoUsuario
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Add
        ///     {
        ///        "Nombre": "Cosme",
        ///        "Apellido": "Fulanito",
        ///        "Documento": "32999999"
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("Add")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<TipoUsuario>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Add(TipoUsuario datos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.TipoUsuario.Add(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Edita TipoUsuario
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Update
        ///     {
        ///        "Nombre": "Cosme",
        ///        "Apellido": "Fulanito",
        ///        "Documento": "32999999"
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("Update")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<TipoUsuario>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Update(TipoUsuario datos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.TipoUsuario.Update(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Elimino un TipoUsuario
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Delete
        ///     {
        ///        "Id": "3"
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("Delete")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<TipoUsuario>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var datos = _context.TipoUsuario.Find(Id);

            _context.TipoUsuario.Remove(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Obtengo TipoUsuarios
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Get
        ///     {
        ///        "Filtro": "Cosme"
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("Get")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<TipoUsuario>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Get([FromQuery] string Filtro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.TipoUsuario.Where(x => x.Codigo.Contains(Filtro) || x.Descripcion.Contains(Filtro));

            return new ObjectResult(result);
        }

        /// <summary>
        /// Obtengo TipoUsuario
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Find
        ///     {
        ///        "Id": "3"
        ///     }
        /// </remarks>
        [HttpGet]
        [Route("Find")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<TipoUsuario>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Find([FromQuery] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.TipoUsuario.Find(Id);

            return new ObjectResult(result);
        }
    }
}
