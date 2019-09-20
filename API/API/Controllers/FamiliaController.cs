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

    }
}
