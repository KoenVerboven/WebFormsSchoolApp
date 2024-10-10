using System;

namespace WebFormsSchoolApp.models
{
    public enum CourseType
    {
        DaySchool,
        NightSchool,
        WeekendSchool
    }

    public class Course
    {
        public int CourseId { get; set; }
        public  string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool CourseIsActive { get => CourseIsActiveMethod(); }
        public CourseType? CourseType { get; set; }
        public decimal? CoursePrice { get; set; }
        
        private bool CourseIsActiveMethod()
        {
            if (EndDate > DateTime.Now)
            {
                return true;
            }
            else return false;
        }
    }
}
