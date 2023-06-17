using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Reservation
    {
        public int Id { get; set; } 
        public string Customer_id { get; set; }  
        public User Customer { get; set; } 
        public Guid Cabin_id { get; set; }   
        public Cabin Cabin { get; set; }
        public string Checkin { get; set; } 
        public string Checkout { get; set; }
        public int Price { get; set; }
         ///Paid got 3 values :
       /// 0 : not paid
       /// 20% of total price : 20% paid
       ///  : Full Amount
        public float Amount_Paid { get; set; }
        public string Created_at { get; set; }  
        public string Updated_at { get; set; }
        public int Payment_id { get; set; }
        public Payment Payment { get; set; }
        public int? Review_Id { get; set; }
        public Review? Review { get; set; }
        
    }
}