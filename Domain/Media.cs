namespace Domain
{
    public class Media
    {
        public int Id { get; set; } 
        public int Cabin_id { get; set; }   
        
        public string Media_type { get; set; }  
        public string File_name { get; set; }   
        public string Mime_type { get; set; }
        public bool IsValidated { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}