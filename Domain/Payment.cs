namespace Domain
{
    public class Payment
    {
        public int Id { get; set; }
        public int Type_Id  { get; set; }
        public PaymentType Type { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public string Details { get; set; }
        public string Created_at { get; set; }  
        public string Updated_at { get; set; }
        public string Recorded_by { get; set; }
    }
}