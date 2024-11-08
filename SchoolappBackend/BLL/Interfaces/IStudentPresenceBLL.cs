using SchoolappBackend.BLL.models;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.Interfaces
{
    internal interface IStudentPresenceBLL
    {
         List<StudentPresenceNotation> GetStudentPresence();

        bool Add(StudentPresenceNotation studentPresenceNotation);
    }
}
