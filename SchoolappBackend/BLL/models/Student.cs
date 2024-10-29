using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolappBackend.BLL.models
{
    public class Student : Person
    {
        public DateTime RegistrationDate { get; set; }
        public string ParentOrContactPhoneNumber1 { get; set; } //todo : ParentPhoneNumber1 put in database + field on forms
        public string ParentOrContactPhoneNumber2 { get; set; } //todo : ParentPhoneNumber1 put in database + field on forms

        //public Address HomeAddress { get; set; }

        //public  Address StudyAddress { get; set; }
        //public List<Course>? EnrolledCourse { get; set; } // Aggregation
    }
}
