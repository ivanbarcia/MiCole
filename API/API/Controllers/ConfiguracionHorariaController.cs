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
    public class ConfiguracionHorariaController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public ConfiguracionHorariaController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// Obtengo todas las configuraciones horarias
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
        [ProducesResponseType(typeof(IEnumerable<ConfiguracionHoraria>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetAll()
        {
            var result = _context.ConfiguracionHoraria.AsEnumerable();

            return new ObjectResult(result);
        }

        /// <summary>
        /// Doy de alta una ConfiguracionHoraria
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Add
        ///     {
        ///        "Codigo": "Cosme",
        ///        "Descripcion": "Fulanito"
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("Add")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<ConfiguracionHoraria>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Add(ConfiguracionHoraria datos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.ConfiguracionHoraria.Add(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Edita ConfiguracionHoraria
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /Update
        ///     {
        ///        "Codigo": "Cosme",
        ///        "Descripcion": "Fulanito"
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("Update")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<ConfiguracionHoraria>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Update(ConfiguracionHoraria datos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.ConfiguracionHoraria.Update(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Elimino una ConfiguracionHoraria
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
        [ProducesResponseType(typeof(IEnumerable<ConfiguracionHoraria>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var datos = _context.ConfiguracionHoraria.Find(Id);

            _context.ConfiguracionHoraria.Remove(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Obtengo ConfiguracionHorarias
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
        [ProducesResponseType(typeof(IEnumerable<ConfiguracionHoraria>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Get([FromQuery] string Filtro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.ConfiguracionHoraria.Where(x => x.Profesional.Nombre.Contains(Filtro) || x.Profesional.Apellido.Contains(Filtro));

            return new ObjectResult(result);
        }

        /// <summary>
        /// Obtengo ConfiguracionHoraria
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
        [ProducesResponseType(typeof(IEnumerable<ConfiguracionHoraria>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Find([FromQuery] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.ConfiguracionHoraria.Find(Id);

            return new ObjectResult(result);
        }
    }
}
