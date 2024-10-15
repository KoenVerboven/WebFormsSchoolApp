using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolappBackend.BLL.models
{
    public class Student : Person
    {
        public DateTime RegistrationDate { get; set; }

        //public Address HomeAddress { get; set; }

        //public  Address StudyAddress { get; set; }
        //public List<Course>? EnrolledCourse { get; set; } // Aggregation
    }
}
