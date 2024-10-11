

using System;

namespace WebFormsSchoolApp.models
{
    public enum SaleryCategorie
    {
        A1,
        A2,
        B1,
        C1
    }

    public enum HighestDegree
    {
        HighSchool,
        University,
        Docktor,
        Professor
    }

    public enum StudyDirection
    {
        Physics,
        Electronics,
        Languages,
        Math,
        Mechanics,
        Chemistry
    }


    public class Teacher : Person
    {
        public DateTime HireDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public SaleryCategorie SaleryCategorie { get; set; }
        public int? SeniorityYears { get; set; }
        //public int? WorkSchedule { get; set; }
        //public int? WorkingHoursPerWeek { get; set; }
        //public HighestDegree HighestDegree { get; set; }
        //public StudyDirection StudyDirection { get; set; }
    }
}