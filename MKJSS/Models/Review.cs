namespace MKJSS.Models
{
    public class Review
    {
        public int Id { get; set; }
        public Learner Learner { get; set; }
        public Lesson Lesson { get; set; }
        public int Rating { get; set; }
        public string ReviewText { get; set; }
        public Coach Coach { get; set; }

      
    }
}
