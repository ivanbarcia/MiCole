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
    public class FamiliaController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public FamiliaController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// Agrego padres al alumno
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /AddPadres
        ///     {
        ///        "Alumno": "32999999",
        ///        "Nombre1": "PadreCosme",
        ///        "Apellido1": "PadreFulanito",
        ///        "Documento1": "3213213",
        ///        "Telefono1": "1131234567",
        ///        "Email1": "asd@asd.com"
        ///        "Nombre2": "MadreCosme",
        ///        "Apellido2": "MadreFulanito",
        ///        "Documento2": "2213213",
        ///        "Telefono2": "1331234567",
        ///        "Email2": "asd2@asd.com"
        ///     }
        /// </remarks>
        /// <returns>Actualizo Datos del Alumno con los datos de los Padres</returns>
        [HttpPut]
        [Route("AddPadres")]
        [ETagFilter(200)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> AddPadres(Padres datosPadres)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Padres.Add(datosPadres);

            return new ObjectResult(datosPadres);
        }
    }
}
