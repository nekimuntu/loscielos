using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }  
        public string Profile_Image { get; set; } 
        public string Address { get; set; } 
        public string Phone { get; set; }   
        public bool FromWeb { get; set; }
        public string Created_at { get; set; }
    }
}