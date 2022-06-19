using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceData.Models;

namespace EcommerceData.Services
{
    public interface IUserService
    {
        Task<User> GetAUser(string Id);
        Task<List<User>> GetUsers();
    }
}