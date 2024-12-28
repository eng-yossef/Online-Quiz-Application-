namespace Online_Quiz_Application.Models
{
    public class Result
    {
        public int ResultID { get; set; }
        public int UserID { get; set; }
        public int QuizID { get; set; }
        public int Score { get; set; }
        public DateTime CompletionTime { get; set; }

        public User User { get; set; } // Relationship with User
        public Quiz Quiz { get; set; } // Relationship with Quiz
    }


}
