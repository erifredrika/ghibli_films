using ghibli.API;
using ghibli.Models;
using ghibli.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ghibli.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly APICaller _api;

        public PersonRepository(APICaller api)
        {
            _api = api;
        }

        public async Task<List<Person>> GetAllPersons()
        {
            var response = await _api.GetAllPersons();

            return response;
        }
    }
}
