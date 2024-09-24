namespace MKJSS.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Learner Learner { get; set; }
        public BookingStatus BookingStatus { get; set; }    

        public Lesson Lesson { get; set; }


      
       
    }

    public enum BookingStatus
    {
        Booked,
        Cancelled,
        Completed
    }
}
