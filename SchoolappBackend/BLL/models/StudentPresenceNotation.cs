
using System;

namespace SchoolappBackend.BLL.models
{
    internal class StudentPresenceNotation
    {
        public int StudentPresenceNotationId { get; set; }
        public int StudentId { get; set; }
        public DateTime NotationDate { get; set; }
        public int CourseLessonId { get; set; }
        public int NotedByTeacherId { get; set; }
        public bool StudentPresence { get; set; }
        public bool Sick { get; set; }
        public bool UnlawfullyAbsent { get; set; }
        public bool ParentsAreNotified { get; set; }
        public string AbsenceReason { get; set; }


    }
}
