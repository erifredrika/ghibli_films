using ghibli.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ghibli.Services
{
    public interface IGhibliService
    {
        public Task<ServiceResponse<IEnumerable<FilmInfo>>> FetchAllFilms();
        public Task<ServiceResponse<IEnumerable<PersonInfo>>> FetchAllPersons();
        public Task<ServiceResponse<IEnumerable<PersonInfo>>> FetchPersonsByFilmId(string id);
    }
}
