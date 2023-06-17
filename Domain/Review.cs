namespace Domain
{
    public class Review
    {
        public int Id { get; set; }         
        public int Rating { get; set; } 
        public string Comment { get; set; } 
        public string Update_At { get; set; }
        public int Reservation_Id { get; set; }
        public Reservation Reservation { get; set; }
        public ICollection<Media> Medias { get; set; }
        
    }
}