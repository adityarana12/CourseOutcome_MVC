namespace CourseOutcome.Models
{
    public class SubmissionResult
    {
        public List<Response> FilledResponses { get; set; }
        public string SId { get; set; }
        public int TotalEntries { get; set; }
        public CourseFormView courseform { get; set; }
    }
}
