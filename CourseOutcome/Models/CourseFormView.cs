using CourseOutcome.Models;

namespace CourseOutcome.Models
{
    public class CourseFormView
    {
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public List<Question> Questions { get; set; }
    }
}
