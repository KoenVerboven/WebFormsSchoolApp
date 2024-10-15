using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;

namespace SchoolappBackend.BLL.Interfaces
{
    internal interface ITeacherBLL
    {
        Teacher GetTeacherById(int Id);

         List<Teacher> GetTeachers(string searchField, string orderBy);
    }
}
