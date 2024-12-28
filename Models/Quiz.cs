namespace Online_Quiz_Application.Models
{
    public class Quiz
    {
        public int QuizID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<Question> Questions { get; set; } // Relationship with Questions
        public List<Result> Results { get; set; } // Relationship with Result
    }



}
