using ghibli.API;
using ghibli.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ghibli.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private readonly APICaller _api;
        
        public FilmRepository(APICaller api)
        {
            _api = api;
        }
        
        public async Task<List<Film>> GetAllFilms()
        {
            var response = await _api.GetAllFilms();
            
            return response;           
        }

        public async Task<List<Person>> GetAllPersons()
        {
            var response = await _api.GetAllPersons();

            return response;
        }
    }
}
