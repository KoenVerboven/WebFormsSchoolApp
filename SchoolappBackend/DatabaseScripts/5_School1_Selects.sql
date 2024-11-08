
select * from Student S 
	inner join StudentCourse SC
		on S.StudentId = SC.StudentId 
	inner join Course C
		on C.CourseId = SC.CourseId


 select S.LastName, S.FirstName , SP.Presence,SP.Comment,SP.SchoolClassId,SP.CourseLessonId,
	    C.CourseName,SP.NotationDate,T.LastName, T.FirstName
from StudentPresence SP left join Student S
	on SP.StudentId = S.StudentId
left join Course C 
	on SP.CourseLessonId = C.CourseId
left join Teacher T 
	on SP.NotedByTeacherId = T.TeacheId