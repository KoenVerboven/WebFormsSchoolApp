

namespace SchoolappBackend.BLL.models
{
    internal class SchoolClass
    {
        public int ClassId { get; set; }
        public string ClassCode { get; set; } //bv IW4, 4F1 
        public string Description { get; set; }// bv 2Gr Industiele wetenschappen
        public  int Degree { get; set; }//graad bv2
        public int Grade { get; set; } //bv 1  leerjaar
        public int EducationKind { get; set; }//dagonderwijs, avondonderwijs
        public int SchoolId { get; set; }
        public int DeparmentId { get; set; } //Department bv : D,K,V
    }
}
