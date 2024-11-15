using SchoolappBackend.BLL.Interfaces;
using SchoolappBackend.BLL.models;
using SchoolappBackend.DAL;
using System.Collections.Generic;

namespace SchoolappBackend.BLL.BLLClasses
{
    public class SchoolDepartmentBLL : ISchoolDepartmentBLL
    {
        SchoolDepartmentDal schoolDepartmentDal = new SchoolDepartmentDal();

        public SchoolDepartmentBLL()
        {
        }

        public List<SchoolClass> GetClasses(string searchField, string orderBy, string sortDirection)
        {
            return schoolDepartmentDal.GetSchoolClasses(searchField, orderBy, sortDirection);
        }

        public int SchoolClassCount()
        {
            return schoolDepartmentDal.GetSchoolClassCount();
        }

        public SchoolClass GetSchoolClassById(int id) {
            return schoolDepartmentDal.GetSchoolClassById(id);
        }

    }
}
