using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolappBackend.BLL.Interfaces
{
    public  interface IStudentBLL
    {
         Student GetStudentById(int Id);

         List<Student> GetStudents(string searchField, string orderBy);

         bool AddStudent(Student student);

         bool UpdateStudent(Student student);

         bool DeleteStudent(int StudentId);
    }
}
