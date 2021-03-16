using System.Collections.Generic;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly object _context;

        public UsersController(Data.DataContext context)
        {
            _context=context;
        }
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<AppUser>>GetUsers()
        {
              var user = 
        }
    }
}