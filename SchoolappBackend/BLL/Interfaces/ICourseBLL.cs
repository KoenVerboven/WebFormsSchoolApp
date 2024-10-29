using SchoolappBackend.BLL.BLLClasses;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.Interfaces
{
    internal interface ICourseBLL
    {
        List<Course> GetCourses(string searchField, string orderBy,string sortDirection, ActiveType activeType);

        Course GetCourseById(int courseId);

        List<Course> GetCoursesByStudentId(int studentId);

        bool Add(Course course);

        bool Update(Course course);

        bool Delete(int CourseId);

    }
}
