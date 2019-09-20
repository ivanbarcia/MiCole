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
        ///     POST /AddAlumno
        ///     {
        ///        "Nombre": "Cosme",
        ///        "Apellido": "Fulanito",
        ///        "Documento": "32999999"
        ///     }
        /// </remarks>
        /// <param name="Documento">DNI del Alumno</param>  
        [HttpPost]
        [Route("AddAlumno")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<string>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> AddAlumno(Alumno dataosAlumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Alumno.Add(dataosAlumno);
            _context.SaveChanges();

            return new ObjectResult(dataosAlumno);
        }

        /// <summary>
        /// Edita alumno
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /EditAlumno
        ///     {
        ///        "Nombre": "Cosme",
        ///        "Apellido": "Fulanito",
        ///        "Documento": "32999999"
        ///     }
        /// </remarks>
        /// <param name="Documento">DNI del Alumno</param>  
        [HttpPut]
        [Route("EditAlumno")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<string>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> EditAlumno(Alumno dataosAlumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Alumno.Update(dataosAlumno);
            _context.SaveChanges();

            return new ObjectResult(dataosAlumno);
        }

        /// <summary>
        /// Elimino un alumno
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /DeleteAlumno
        ///     {
        ///        "Nombre": "Cosme",
        ///        "Apellido": "Fulanito",
        ///        "Documento": "32999999"
        ///     }
        /// </remarks>
        /// <param name="Documento">DNI del Alumno</param>  
        [HttpPost]
        [Route("DeleteAlumno")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<string>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> DeleteAlumno(Alumno dataosAlumno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Alumno.Remove(dataosAlumno);
            _context.SaveChanges();

            return new ObjectResult(dataosAlumno);
        }

        /// <summary>
        /// Obtengo alumnos
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /GetAlumno
        ///     {
        ///        "Filtro": "Cosme"
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("GetAlumno")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<string>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetAlumno([FromQuery] string Filtro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.Alumno.Where(x => x.Nombre.Contains(Filtro) || x.Apellido.Contains(Filtro) || x.NroDocumento.Contains(Filtro));

            return new ObjectResult(result);
        }
    }
}
