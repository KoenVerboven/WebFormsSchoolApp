using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.Interfaces
{
    internal interface ICourseBLL
    {
        List<Course> GetCourses(string searchField, string orderBy);

        Course GetCourseById(int courseId);

        List<Course> GetCoursesByStudentId(int studentId);
    }
}
