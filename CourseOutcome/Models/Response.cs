using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Primitives;

namespace CourseOutcome.Models{
    public class Response
    {
        [Key]
        public string Enrollmentno { get; set; }
        public DateTime SubmissionTimestamp { get; set; }

        [Key]
        public string SId { get; set; }

        public int? Response1 { get; set; }
        public int? Response2 { get; set; }
        public int? Response3 { get; set; }
        public int? Response4 { get; set; }
        public int? Response5 { get; set; }
        public int? Response6 { get; set; }
        public string? Suggestion { get; set; }

        public Subject Subject { get; set; }
    }
}
