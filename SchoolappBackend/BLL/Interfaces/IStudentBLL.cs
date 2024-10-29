using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolappBackend.BLL.Interfaces
{
    public  interface IStudentBLL
    {
         Student GetStudentById(int Id);

         List<Student> GetStudents(string searchField, string orderBy, string sortDirection);

         bool Add(Student student);

         bool Update(Student student);

         bool Delete(int StudentId);
    }
}
