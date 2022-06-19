using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceData.Models;

namespace EcommerceData.Interface
{
    public interface IUserRepository
    {
        // CRUD Create Read Update Delete
        Task<List<User>> GetUsers();

        bool AddUser(User model); // Create 
        bool UpdateUser(User model); // Update

        bool Delete(string Id); // Delete 
    }
}
