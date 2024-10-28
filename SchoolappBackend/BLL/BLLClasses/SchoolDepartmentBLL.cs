using SchoolappBackend.BLL.models;
using SchoolappBackend.DAL;
using System.Collections.Generic;

namespace SchoolappBackend.BLL.BLLClasses
{
    public class SchoolDepartmentBLL
    {
        public List<SchoolClass> GetClasses(string searchField, string orderBy)
        {
            var schooDepartmentDal = new SchoolDepartmentDal();
            return schooDepartmentDal.GetSchoolClasses(searchField, orderBy);
        }

        public int SchoolClassCount()
        {
            var schoolDepartmentDal = new SchoolDepartmentDal();
            return schoolDepartmentDal.GetSchoolClassCount();
        }

    }
}
