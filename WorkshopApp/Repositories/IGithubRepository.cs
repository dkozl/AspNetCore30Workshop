using System.Threading.Tasks;
using WorkshopApp.Models;

namespace WorkshopApp.Repositories
{
    public interface IGithubRepository
    {
        Task<UserInfo> GetUser(string userName);
    }
}
