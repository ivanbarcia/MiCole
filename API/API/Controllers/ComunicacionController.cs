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
    public class ComunicacionController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public ComunicacionController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// Envia mensaje a destinatario
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /SendMessage
        ///     {
        ///        "sender": "profesora1",
        ///        "receiver": "alumno1",
        ///        "message": "Notifico que el alumno...",
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("SendMessage")]
        [ETagFilter(200)]
        [ProducesResponseType(typeof(IEnumerable<string>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> SendMessage(Notificacion datosNotificacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Notificacion.Add(datosNotificacion);

            return new ObjectResult(datosNotificacion);
        }

        /// <summary>
        /// Actualizo los mensajes recibidos
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /GetMessages
        ///     {
        ///     }
        /// </remarks>
        /// <returns>Obtengo mensajes del momento</returns>
        [HttpGet]
        [Route("GetMessages")]
        [ETagFilter(200)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> GetMessages()
        {
            var result = _context.Notificacion.AsEnumerable();

            return new ObjectResult(result);
        }
    }
}
