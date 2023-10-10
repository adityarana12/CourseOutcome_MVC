using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseOutcome.Models
{
    public class Question
    {
        [Key] 
        public string QId { get; set; }
        [ForeignKey("Subject")]
        public string SId { get; set; }
        public string Qtext { get; set; }
        public Subject Subject { get; set; }
    }
}
