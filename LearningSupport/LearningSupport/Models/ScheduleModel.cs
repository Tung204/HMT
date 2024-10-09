namespace LearningSupport.Models
{
    public class StudySchedule
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StudyDate { get; set; }
        public bool IsCompleted { get; set; }
    }

}
