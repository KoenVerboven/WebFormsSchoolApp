using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolappBackend.BLL.Interfaces
{
    internal interface ISchoolDepartmentBLL
    {
         List<SchoolClass> GetClasses(string searchField, string orderBy, string sortDirection);
         int SchoolClassCount();
         SchoolClass GetSchoolClassById(int id);
    }
}
