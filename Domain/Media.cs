using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Media
    {
        public int Id { get; set; } 
        public int Cabin_id { get; set; }   
        public string Media_type { get; set; }  
        public string file_name { get; set; }   
        public string Mime_type { get; set; }
    }
}