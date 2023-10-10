using CourseOutcome.Data;
using CourseOutcome.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic; 

namespace CourseOutcome.Controllers
{
    public class CourseOutcomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CourseOutcomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult FetchQuestions(string subject_id)
        {
            var subjectId = subject_id;
            var subject = _db.Subject.FirstOrDefault(s => s.SId == subjectId);

            var viewModel = new CourseFormView();

            if (subject != null)
            {
                viewModel.Questions = _db.Question
                    .Where(q => q.SId == subjectId) 
                    .ToList();
                viewModel.SubjectId = subjectId;
                viewModel.SubjectName = subject.SubjectName;
            }
            else
            {
                viewModel.SubjectId = subjectId;
                viewModel.SubjectName = "Unknown";
                viewModel.Questions = new List<Question>(); 
            }

            return View("CourseForm", viewModel);
        }

        [HttpPost]
        public IActionResult CourseForm(Response obj)
        {
            obj.SubmissionTimestamp= DateTime.Now;
            _db.Response.Add(obj);
            _db.SaveChanges();
            TempData["success1"] = "form submitted successfully";
            return RedirectToAction("Index", "CourseOutcome");
        }
       
    }
}
