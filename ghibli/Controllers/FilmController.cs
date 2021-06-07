using ghibli.Repositories;
using ghibli.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ghibli.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : Controller
    {
        private readonly IGhibliService _ghibliService;
       // private readonly IFilmRepository _filmRepository;
        
        public FilmController(IGhibliService ghibliService)
        {
            _ghibliService = ghibliService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _ghibliService.FetchAllFilms();

            if (!result.Success)
                return NotFound();

            return Ok(result.Entity);
        }
    }
}
