using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Reserve
    {
        public int Id { get; set; } 
        public int Price { get; set; }  
        public int Stars { get; set; }  
        public string Checkin { get; set; } 
        public string Checkout { get; set; }    
       ///Paid got 3 values :
       /// 0 : not paid
       /// 1 : partially paid
       /// 9 : Totally paid 
        public int Paid { get; set; }
        public int PaymentType { get; set; }    
        public string PaymentDetails { get; set; }  
        public string PaymentDate { get; set; } 
        public string Additional_details { get; set; }  
        public string DateRecorded { get; set; }    
    }
}