using CourseOutcome.Models;

namespace CourseOutcome.Models
{
    public class SubmissionView
    {
        public List<Subject> Subjects { get; set; }
        public string SubjectCode { get; set; }
        public int Year { get; set; }
    }
}
