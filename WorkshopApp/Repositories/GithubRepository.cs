using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WorkshopApp.Models;

namespace WorkshopApp.Repositories
{
    public class GithubRepository : IGithubRepository
    {
        private readonly HttpClient _client;

        public GithubRepository(HttpClient client)
        {
            _client = client;
        }

        public async Task<UserInfo> GetUser(string userName)
        {
            var response = await _client.GetAsync($"/users/{userName}");

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return JsonSerializer.Parse<UserInfo>(json);
        }
    }
}
