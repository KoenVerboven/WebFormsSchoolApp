
namespace SchoolappBackend.BLL.models
{
    internal class MultiplechoiseExamen
    {
        public int MultiplechoiseExamenId { get; set; }
        public string ExamenName { get; set; }
        public int TotalPoints { get; set; }
        public int CreatedByTeacherId { get; set; }
    }
}
