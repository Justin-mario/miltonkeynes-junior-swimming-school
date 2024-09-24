namespace MKJSS.Models
{
    public class Learner
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public int Grade { get; set; }
        public List<Booking> Bookings { get; set; }
    }
}
