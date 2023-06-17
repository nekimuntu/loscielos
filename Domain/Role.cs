using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class Role : IdentityRole
    {
        /// 2 roles :
        ///  - admin
        ///  - customer
        public string Description { get; set; }
        public string Created_at { get; set; }  
        public string Updated_by { get; set; }
        public ICollection<RoleByUsers> RoleByUsers { get; set; }
    }
}