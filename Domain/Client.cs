using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }   
        public string Address { get; set; } 
        public string Phone { get; set; }   
        public bool FromWeb { get; set; }
        public string DateRecorded { get; set; }
    }
}