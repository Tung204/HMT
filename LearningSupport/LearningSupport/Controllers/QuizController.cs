using LearningSupport.Data;
using LearningSupport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearningSupport.Controllers
{
	public class QuizController : Controller
	{
		private readonly ApplicationDbContext _context;

		public QuizController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var quizzes = _context.Quizzes.Include(q => q.Questions).ToList();
			return View(quizzes);
		}

		public IActionResult TakeQuiz(int id)
		{
			var quiz = _context.Quizzes.Include(q => q.Questions).ThenInclude(q => q.Options).FirstOrDefault(q => q.Id == id);
			if (quiz == null) return NotFound();
			return View(quiz);
		}

		[HttpPost]
		public IActionResult SubmitQuiz(QuizResult quizResult)
		{
			var quiz = _context.Quizzes.Include(q => q.Questions).ThenInclude(q => q.Options)
						.FirstOrDefault(q => q.Id == quizResult.QuizId);

			if (quiz == null) return NotFound();

			int correctAnswers = 0;

			foreach (var question in quiz.Questions)
			{
				var selectedOptionId = quizResult.Answers[question.Id];
				var selectedOption = question.Options.FirstOrDefault(o => o.Id == selectedOptionId);

				if (selectedOption != null && selectedOption.IsCorrect)
				{
					correctAnswers++;
				}
			}

			// Tính toán điểm số và đưa ra phản hồi
			ViewBag.Score = correctAnswers;
			ViewBag.TotalQuestions = quiz.Questions.Count;

			return View("QuizResult", quizResult);  // Hiển thị trang kết quả
		}

	}

}
