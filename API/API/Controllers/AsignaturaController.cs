﻿using Microsoft.AspNetCore.Mvc;
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
    public class AsignaturaController : Controller
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public AsignaturaController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        /// <summary>
        /// Doy de alta una Asignatura
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
        [ProducesResponseType(typeof(IEnumerable<Asignatura>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Add(Asignatura datos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Asignatura.Add(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Edita Asignatura
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
        [ProducesResponseType(typeof(IEnumerable<Asignatura>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Update(Asignatura datos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Asignatura.Update(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Elimino una Asignatura
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
        [ProducesResponseType(typeof(IEnumerable<Asignatura>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Delete([FromQuery] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var datos = _context.Asignatura.Find(Id);

            _context.Asignatura.Remove(datos);
            _context.SaveChanges();

            return new ObjectResult(datos);
        }

        /// <summary>
        /// Obtengo Asignaturas
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
        [ProducesResponseType(typeof(IEnumerable<Asignatura>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Get([FromQuery] string Filtro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.Asignatura.Where(x => x.Codigo.Contains(Filtro) || x.Descripcion.Contains(Filtro));

            return new ObjectResult(result);
        }

        /// <summary>
        /// Obtengo Asignatura
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
        [ProducesResponseType(typeof(IEnumerable<Asignatura>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorDetails), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Unauthorized)]
        public async Task<IActionResult> Find([FromQuery] int Id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var result = _context.Asignatura.Find(Id);

            return new ObjectResult(result);
        }
    }
}
