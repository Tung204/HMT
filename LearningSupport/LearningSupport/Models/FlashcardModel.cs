namespace LearningSupport.Models
{
    public class Flashcard
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ImageUrl { get; set; } // Thêm thuộc tính cho hình ảnh
        public string Term { get; set; }
        public string Definition { get; set; }
    }

}
