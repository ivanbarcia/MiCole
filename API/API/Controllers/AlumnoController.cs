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
    public class AlumnoController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public AlumnoController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// Doy de alta un alumno
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
        [ProducesResponseType(typeof(IEnumerable<Alumno>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Add(Alumno datos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Alumno.Add(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Edita alumno
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
        [ProducesResponseType(typeof(IEnumerable<Alumno>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Update(Alumno datos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Alumno.Update(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Elimino un alumno
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
        [ProducesResponseType(typeof(IEnumerable<Alumno>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var datos = _context.Alumno.Find(Id);

            _context.Alumno.Remove(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Obtengo alumnos
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
        [ProducesResponseType(typeof(IEnumerable<Alumno>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Get([FromQuery] string Filtro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.Alumno.Where(x => x.Nombre.Contains(Filtro) || x.Apellido.Contains(Filtro) || x.NroDocumento.Contains(Filtro));

            return new ObjectResult(result);
        }

        /// <summary>
        /// Obtengo alumno
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
        [ProducesResponseType(typeof(IEnumerable<Alumno>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Find([FromQuery] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.Alumno.Find(Id);

            return new ObjectResult(result);
        }

        /// <summary>
        /// Obtengo todos los alumnos
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
        [ProducesResponseType(typeof(IEnumerable<Alumno>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetAll()
        {
            var result = _context.Alumno.AsEnumerable();

            return new ObjectResult(result);
        }
    }
}
