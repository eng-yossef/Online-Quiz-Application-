using System.Text.Json.Serialization;

namespace Online_Quiz_Application.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int QuizID { get; set; }
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }

        public Quiz Quiz { get; set; } // Relationship with Quiz

        [JsonPropertyName("options")]
        public List<Option> Options { get; set; } // Relationship with Options
    }


}
