using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class User:IdentityUser
    {        
        public string LastName { get; set; }
        public string FirstName { get; set; }        
        public string Profile_Image { get; set; } 
        public string Address { get; set; } 
        public string Phone { get; set; }   
        public bool FromWeb { get; set; }
        public string Created_at { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<RoleByUsers> RoleByUsers { get; set; }
    }
}