using ghibli.Repositories;
using ghibli.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ghibli.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IGhibliService _ghibliService;
        
        public PersonController(IGhibliService ghibliService)
        {
            _ghibliService = ghibliService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _ghibliService.FetchAllPersons();

            if (!result.Success)
                return NotFound();
            
            return Ok(result.Entity);
        }

        [HttpGet]
        [Route("search")]
        public async Task<IActionResult> GetByFilmId(string id)
        {
            var result = await _ghibliService.FetchPersonsByFilmId(id);

            if (!result.Success)
                return NotFound();

            return Ok(result.Entity);
        }
    }
}
