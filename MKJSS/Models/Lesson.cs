using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace MKJSS.Models
{
    public class Lesson
    {
        public string Id { get; set; }
        public Coach Coach { get; set; }
        public int Grade { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
        public List<Learner> Learners { get; set; }
        public List<Review> Reviews { get; set; }
        public int LessonSize { get; set; }
        public string Month { get; set; }

    }
}
