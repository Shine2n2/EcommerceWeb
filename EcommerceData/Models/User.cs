using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Avatar { get; set; }
        public bool IsAdmin { get; set; }
        

        public Security Security { get; set; }
        public ICollection<Cars> Cars { get; set; }

        public ICollection<Role> Roles { get; set; }


    }
}
