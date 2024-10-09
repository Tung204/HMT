namespace LearningSupport.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Option> Options { get; set; }
        public int CorrectOptionId { get; set; }
    }

    public class Option
    {
        public int Id { get; set; }
        public string Text { get; set; }
		public bool IsCorrect { get; set; }  // Cờ để đánh dấu đúng/sai
	}
	public class QuizResult
	{
		public int QuizId { get; set; }
		public Dictionary<int, int> Answers { get; set; }  // Key: QuestionId, Value: OptionId
	}


}
