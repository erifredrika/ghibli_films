using ghibli.Models;
using ghibli.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ghibli.Repositories
{
    public interface IPersonRepository
    {
        public Task<List<Person>> GetAllPersons();
    }
}
