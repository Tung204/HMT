using LearningSupport.Data;
using LearningSupport.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningSupport.Controllers
{
    public class FlashcardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FlashcardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var flashcards = _context.Flashcards.ToList();
            return View(flashcards);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Flashcard flashcard)
        {
            if (ModelState.IsValid)
            {
                flashcard.CreatedDate = DateTime.Now;
                _context.Flashcards.Add(flashcard);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flashcard);
        }

        public IActionResult Details(int id)
        {
            var flashcard = _context.Flashcards.Find(id);
            if (flashcard == null) return NotFound();
            return View(flashcard);
        }
    }

}
