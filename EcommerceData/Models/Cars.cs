using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceData.Models
{
    public class Cars
    {
        public string Id { get; set; }
        public string Model { get; set; }
        public string PlateNumber { get; set; }       
        public string ChasisName { get; set; }
        public string YearOfMan { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
