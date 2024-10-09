using LearningSupport.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearningSupport.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
        public DbSet<Flashcard> Flashcards { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<StudySchedule> StudySchedules { get; set; }
    }
}
