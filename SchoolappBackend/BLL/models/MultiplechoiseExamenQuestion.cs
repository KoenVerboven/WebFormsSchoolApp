
namespace SchoolappBackend.BLL.models
{
    public class MultiplechoiseExamenQuestion
    {
        public int ExamenQuestionId { get; set; }
        public string QuestionText { get; set; }
        public int ExamenId { get; set; }
        public  int OrderNumber { get; set; }// sorting the question
    }
}
