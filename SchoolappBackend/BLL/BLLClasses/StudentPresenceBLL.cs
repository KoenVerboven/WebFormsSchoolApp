using SchoolappBackend.BLL.models;
using SchoolappBackend.DAL;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.BLLClasses
{
    public class StudentPresenceBLL
    {
        public List<StudentPresenceNotation> GetStudentPresence()
        {
            var studentPresenceDal = new StudentPresenceDal();
            return studentPresenceDal.GetStudentPrecence();
        }

        public bool Add(StudentPresenceNotation studentPresenceNotation)
        {
            var studentPresenceDal = new StudentPresenceDal();
            return studentPresenceDal.AddStudentPresence(studentPresenceNotation);
        }


    }
}
