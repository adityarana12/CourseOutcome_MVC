using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseOutcome.Models
{
    public class Subject
    {
        [Key]
        public string SId { get; set; }
        public string SubjectName { get; set; }
    }
}
