using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Payment
    {
        public int Id { get; set; }
        public string Type  { get; set; }
        public string Created_at { get; set; }  
        public string Updated_at { get; set; }
        public int Recorded_by { get; set; }
    }
}