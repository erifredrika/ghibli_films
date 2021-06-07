using ghibli.API;
using ghibli.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ghibli.Repositories
{
    public interface IFilmRepository
    {
        public Task<List<Film>> GetAllFilms();
        public Task<List<Person>> GetAllPersons();
    }
}
