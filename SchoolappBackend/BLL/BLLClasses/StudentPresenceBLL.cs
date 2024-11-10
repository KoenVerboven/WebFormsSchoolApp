using SchoolappBackend.BLL.Interfaces;
using SchoolappBackend.BLL.models;
using SchoolappBackend.DAL;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.BLLClasses
{
    public class StudentPresenceBLL : IStudentPresenceBLL
    {
        public List<StudentPresenceNotation> GetStudentPresence(int classId)
        {
            var studentPresenceDal = new StudentPresenceDal();
            return studentPresenceDal.GetStudentPrecence(classId);
        }

        public bool Add(StudentPresenceNotation studentPresenceNotation)
        {
            var studentPresenceDal = new StudentPresenceDal();
            return studentPresenceDal.AddStudentPresence(studentPresenceNotation);
        }


    }
}
