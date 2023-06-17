using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class RoleByUsers
    {
        public string User_Id { get; set; }
        public User User { get; set; }

        public Role Role { get; set; }
        public string Role_Id { get; set; }

        public string Updated_at { get; set; }
        public string Updated_by { get; set; }
    }
}