using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Role
    {
        public int id { get; set; } 
        public string name { get; set; }
        public string Description { get; set; }
        public string Created_at { get; set; }  
        public string Updated_by { get; set; }
    }
}