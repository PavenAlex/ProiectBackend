namespace ProiectBackend.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
