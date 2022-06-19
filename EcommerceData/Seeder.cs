using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EcommerceData.Models;
using Newtonsoft.Json;

namespace EcommerceData
{
    public class Seeder
    {
        public static async Task SeedData(SchoolContext dbContext)
        {
            var baseDir = Directory.GetCurrentDirectory();

            await dbContext.Database.EnsureCreatedAsync();

            if(!dbContext.Roles.Any())
            {
                List<Role> roles = new List<Role> {
                    new Role{Id = Guid.NewGuid().ToString(), RoleName="Admin", Description="hello admin"},
                    new Role{Id = Guid.NewGuid().ToString(), RoleName="Customer", Description="hello customer"},
                    new Role{Id = Guid.NewGuid().ToString(), RoleName="Staff", Description="hello staff"},
                };

                await dbContext.Roles.AddRangeAsync(roles);
            }

            if (!dbContext.Users.Any())
            {

                var path = File.ReadAllText(FilePath(baseDir, "Json/Users.json"));

                var users = JsonConvert.DeserializeObject<List<User>>(path);
                await dbContext.Users.AddRangeAsync(users);
                

               
            }


            await dbContext.SaveChangesAsync();
        }


        static string FilePath(string folderName, string fileName)
        {
            return Path.Combine(folderName, fileName);
        }
    }
}
