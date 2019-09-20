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
    public class TipoProfesionalController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public TipoProfesionalController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// Doy de alta un TipoProfesional
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
        [ProducesResponseType(typeof(IEnumerable<TipoProfesional>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Add(TipoProfesional datos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.TipoProfesional.Add(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Edita TipoProfesional
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
        [ProducesResponseType(typeof(IEnumerable<TipoProfesional>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Update(TipoProfesional datos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.TipoProfesional.Update(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Elimino un TipoProfesional
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
        [ProducesResponseType(typeof(IEnumerable<TipoProfesional>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var datos = _context.TipoProfesional.Find(Id);

            _context.TipoProfesional.Remove(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Obtengo TipoProfesionals
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
        [ProducesResponseType(typeof(IEnumerable<TipoProfesional>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Get([FromQuery] string Filtro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.TipoProfesional.Where(x => x.Codigo.Contains(Filtro) || x.Descripcion.Contains(Filtro));

            return new ObjectResult(result);
        }

        /// <summary>
        /// Obtengo TipoProfesional
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
        [ProducesResponseType(typeof(IEnumerable<TipoProfesional>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Find([FromQuery] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.TipoProfesional.Find(Id);

            return new ObjectResult(result);
        }
    }
}
