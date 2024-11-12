

namespace SchoolappBackend.BLL.models
{
    public class SchoolClass
    {
        public int ClassId { get; set; }
        public string ClassCode { get; set; } //bv IW4, 4F1 
        public string Description { get; set; }// bv 2Gr Industiele wetenschappen
        public string ClassCodeAndDescription { get => ClassCode + "    " + Description; }
        public  int Degree { get; set; }//graad bv2
        public int Grade { get; set; } //bv 1  leerjaar
        public int EducationKind { get; set; }//dagonderwijs, avondonderwijs// TSO, BSO
        public int SchoolDepartmentId { get; set; }
    }
}
