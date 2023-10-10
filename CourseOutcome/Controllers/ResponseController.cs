using CourseOutcome.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CourseOutcome.Models;
using System.Linq;

namespace CourseOutcome.Controllers
{
    public class ResponseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ResponseController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Responses()
        {
            SubmissionView obj = new SubmissionView();
            obj.Subjects = _db.Subject.ToList();
            return View(obj);
        }

        public IActionResult Result(SubmissionView submissionview)
        {
            SubmissionResult obj = new SubmissionResult();
            obj.FilledResponses = _db.Response
                .Where(x => x.SId == submissionview.SubjectCode && x.SubmissionTimestamp.Year == submissionview.Year)
                .ToList();
            obj.SId=submissionview.SubjectCode;
            obj.TotalEntries = obj.FilledResponses.Count;

            return View(obj);
        }


        public IActionResult ViewForm()
        {
            string enrollmentno = HttpContext.Request.Query["Enrollmentno"].ToString().ToUpper();
            string subject_id = HttpContext.Request.Query["SubjectCode"].ToString().ToUpper();
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

            Response obj = _db.Response.Where(x => x.Enrollmentno == enrollmentno).FirstOrDefault();
            var view = new ViewModel
            {
                courseFormView = viewModel,
                response = obj
            };

            return View(view);
        }
        public IActionResult Update()
        {
            string subject_id = HttpContext.Request.Query["SubjectCode"].ToString().ToUpper();
            var subjectId = subject_id;
            var subject = _db.Subject.FirstOrDefault(s => s.SId == subjectId);

            var view = new CourseFormView();

            if (subject != null)
            {
                view.Questions = _db.Question
                    .Where(q => q.SId == subjectId)
                    .ToList();
                view.SubjectId = subjectId;
                view.SubjectName = subject.SubjectName;
            }
            else
            {
                view.SubjectId = subjectId;
                view.SubjectName = "Unknown";
                view.Questions = new List<Question>();
            }

            return View("Update", view);

        }
        public IActionResult RetrieveQuestion()
        {
            string questionId = HttpContext.Request.Query["QuestionId"].ToString().ToUpper();
            Question question = _db.Question.Find(questionId);
            if (question == null) { return NotFound(); }
            return View("EditQuestion", question);
        }
        [HttpPost]
        public IActionResult EditQuestion(Question obj)
        {


            _db.Question.Update(obj);
            _db.SaveChanges();
            TempData["success"] = "Question Updated Sucessfully";
            return RedirectToAction("Update", new { SubjectCode = obj.SId });

        }   
        public IActionResult calculateAverage([FromQuery] string SubjectCode)
        {
            var sId = SubjectCode;
            // Filter responses based on the provided SId
            var responsesForSId = _db.Response
                .Where(response => response.SId == sId)
                .ToList();

            var questionCount = _db.Question.Where(question => question.SId == sId).Count();

            // Calculate average ratings for each response individually
            var averageRatings = new Dictionary<string, double>();

            for (int i = 1; i <= questionCount; i++)
            {
                string propertyName = $"Response{i}";

                double totalAverageRating = 0;
                int count = 0;

                foreach (var response in responsesForSId)
                {
                    int? rating = (int?)response.GetType().GetProperty(propertyName).GetValue(response, null);

                    if (rating != null)
                    {
                        totalAverageRating += rating.Value;
                        count++;
                    }
                }

                double averageRating = count > 0 ? totalAverageRating / count : 0;
                averageRatings.Add($"Question{i}", averageRating);
            }

            ViewData["AverageRatings"] = averageRatings;

            return View("showAverage");
        }
    }

    }
