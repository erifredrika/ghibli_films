using ghibli.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ghibli.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmController : Controller
    {
        private readonly IGhibliService _ghibliService;
        
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

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _ghibliService.FetchFilmById(id);

            if (!result.Success)
                return NotFound();

            return Ok(result.Entity);
        }
    }
}
