using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceData.Models;
using Microsoft.EntityFrameworkCore;
using EcommerceData.Interface;

namespace EcommerceData.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly SchoolContext _dbContext;
        public UserRepository(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddUser(User model)
        {
            try
            {
                _dbContext.Add(model);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(string Id)
        {
            throw new NotImplementedException();
        }
               

        public async Task<List<User>> GetUsers()
        {
            //Eager Loading
            var users = await _dbContext.Users
                        .Include(s => s.Security)
                        .Include(c => c.Cars)
                        .Include(x => x.Roles).ToListAsync();


            return users;
        }

        public bool UpdateUser(User model)
        {
            try
            {
                _dbContext.Update(model);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
