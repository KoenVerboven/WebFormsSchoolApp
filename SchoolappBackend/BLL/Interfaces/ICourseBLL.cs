using SchoolappBackend.BLL.BLLClasses;
using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.Interfaces
{
    internal interface ICourseBLL
    {
        List<Course> GetCourses(string searchField, string orderBy, ActiveType activeType);

        Course GetCourseById(int courseId);

        List<Course> GetCoursesByStudentId(int studentId);

        bool AddCourse(Course course);

        bool UpdateCourse(Course course);

        bool DeleteCourse(int CourseId);

    }
}
