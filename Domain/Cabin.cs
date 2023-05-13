using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Cabin
    {
        public Guid Id { get; set; }        
        public string Name { get; set; } 
        public int nbBeds { get; set; }
        public string PictureUrl   { get; set; }   
        public bool Available { get; set; } 
        public string DateRecorded { get; set; }

    }
}