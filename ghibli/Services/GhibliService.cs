using ghibli.Models;
using ghibli.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ghibli.Services
{
    public class GhibliService : IGhibliService
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IPersonRepository _personRepository;
        
        public GhibliService(IFilmRepository filmRepository, IPersonRepository personRepository)
        {
            _filmRepository = filmRepository;
            _personRepository = personRepository;
        }

        public async Task<ServiceResponse<IEnumerable<FilmInfo>>> FetchAllFilms()
        {
            List<FilmInfo> filmsInfos = new();
            var films = await _filmRepository.GetAllFilms();

            if (films.Count <= 0)
                return new ServiceResponse<IEnumerable<FilmInfo>>("Films not found");

            foreach (var film in films)
            {
                filmsInfos.Add(film.ToFilmInfo());
            }

            return new ServiceResponse<IEnumerable<FilmInfo>>(filmsInfos);
        }

        public async Task<ServiceResponse<IEnumerable<PersonInfo>>> FetchAllPersons()
        {
            List<PersonInfo> personInfos = new();
            
            var people = await _personRepository.GetAllPersons();
            
            if (people.Count <= 0)
                return new ServiceResponse<IEnumerable<PersonInfo>>("People not found");

            foreach (var p in people)
            {
                personInfos.Add(p.ToPersonInfo());
            }

            return new ServiceResponse<IEnumerable<PersonInfo>>(personInfos);
        }

        public async Task<ServiceResponse<IEnumerable<PersonInfo>>> FetchPersonsByFilmId(string id)
        {
            var people = await _personRepository.GetAllPersons();

            if (people.Count <= 0)
                return new ServiceResponse<IEnumerable<PersonInfo>>("People not found");

            var toReturn = people
                .Where(f => f.Films[0].Replace("https://ghibliapi.herokuapp.com/films/", "") == id)
                .Select(p => p.ToPersonInfo())
                .ToList();

            return new ServiceResponse<IEnumerable<PersonInfo>>(toReturn);
        }
    }
}
