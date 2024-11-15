using SchoolappBackend.BLL.Interfaces;
using SchoolappBackend.BLL.models;
using SchoolappBackend.DAL;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.BLLClasses
{
    public class StudentPresenceBLL : IStudentPresenceBLL
    {
        StudentPresenceDal studentPresenceDal = new StudentPresenceDal();

        public StudentPresenceBLL()
        {
        }

        public List<StudentPresenceNotation> GetStudentPresence(int classId)
        {
            return studentPresenceDal.GetStudentPrecence(classId);
        }

        public bool Add(StudentPresenceNotation studentPresenceNotation)
        {
            return studentPresenceDal.AddStudentPresence(studentPresenceNotation);
        }

    }
}
