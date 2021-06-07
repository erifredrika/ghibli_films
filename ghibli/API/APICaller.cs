using ghibli.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ghibli.API
{
    public class APICaller
    {
        private readonly RestClient client = new RestClient("https://ghibliapi.herokuapp.com/");

        public async Task<List<Film>> GetAllFilms()
        {
            var request = new RestRequest("films", DataFormat.Json)
            {
                Method = Method.GET
            };

            var response = await client.ExecuteAsync<List<Film>>(request);

            var content = JsonConvert.DeserializeObject<List<Film>>(response.Content);
            
            return content;
        }

        public async Task<List<Person>> GetAllPersons()
        {
            var request = new RestRequest("people", DataFormat.Json)
            {
                Method = Method.GET
            };

            var response = await client.ExecuteAsync<List<Person>>(request);

            var content = JsonConvert.DeserializeObject<List<Person>>(response.Content);
            
            return content;
        }
    }
}
