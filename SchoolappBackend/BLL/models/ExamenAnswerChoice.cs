
namespace SchoolappBackend.BLL.models
{
    public class ExamenAnswerChoice
    {
        public int ExamenAnswerChoiceId { get; set; }
        public  string  AnswerText { get; set; }
        public bool IsCorrectAnswer { get; set; } // in case of multiplechoice
        public int ExamenQuestionId { get; set; }
    }
}
