using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData.Models
{
    public class Security
    {
        
        public string Id { get; set; }
        public string BVN{ get; set; }
        public string NIN { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}
