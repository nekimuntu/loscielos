namespace Domain
{
    public class Cabin
    {
        public Guid Id { get; set; }        
        public string Name { get; set; } 
        public int Nb_Bed { get; set; }
        public int Total_Occupancy { get; set; }
        public int Price { get; set; }
        public int Notation { get; set; }
        public string PictureUrl   { get; set; }   
        public bool Available { get; set; } 
        public string Summary { get; set; }     
        public string Adress { get; set; }  
        public bool Has_tv { get; set; }
        public bool Has_kitchen { get; set; }   
        public bool Has_aircon { get; set; }    
        public bool Has_internet { get; set; }          
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Created_at { get; set; }
         public string Update_At { get; set; }
        public string Published_at { get; set; }
        public int Recorded_by { get; set; }           
        public ICollection<Reservation> Reservations  { get; set; } 

    }
}