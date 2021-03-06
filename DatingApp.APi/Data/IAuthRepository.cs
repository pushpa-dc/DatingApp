using System.Threading.Tasks;
using DatingApp.APi.Models;

namespace DatingApp.APi.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UseExist(string username);
    }
}