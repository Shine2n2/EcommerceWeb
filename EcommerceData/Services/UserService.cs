using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceData.Interface;
using EcommerceData.Models;

namespace EcommerceData.Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepositrory)
        {
            _userRepository = userRepositrory;
        }

        public async Task<User> GetAUser(string Id)
        {
            var users = await _userRepository.GetUsers();

            if (users != null)
            {
                var user = users.Find(x => x.Id == Id);

                return user;
            }

            return null;
        }

        public async Task<List<User>> GetUsers()
        {
            var users = await _userRepository.GetUsers();

            if (users == null)
            {
                return null;
            }

            return users;
        }
    }
}
