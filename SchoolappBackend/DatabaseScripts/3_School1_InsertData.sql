	Use School1


	Insert into Student(FirstName,MiddleName,LastName,StreetAndNumber,
                    ZipCode,PhoneNumber,Gender,DateOfBirth, MaritalStatusId,
					NationalRegisterNumber,Nationality, [MoederTongueId],Registrationdate
					)
		values 
		('Johan',null,'Verboven','Mpad 30' , '2351','08123445','M','2000-01-31',2,13737,1,1,'2024-06-01  10:00:00'),
		('Maria',null,'Poels','Mpad 30' , '2351','08123445','V','1999-04-12',2,17838,1,1,'1974-04-12  10:00:00'),
		('Koen','Maria Frans','Verboven','Mpad 30' , '2351','08123445','M','1966-06-01',2,17832,1,1,'2024-06-01  10:00:00'),
		('Leen',null,'Peeters','Eigenaarsstraat 45 bus7' , '4000','08123445','M','1986-01-15',2,1252872,1,1,'2024-06-01  10:00:00'),
		('Gert','Frans','Peeters','Molenpad' , '4000','08123445','M','1956-02-01',2,178,1,1,'2024-06-01  10:00:00'),
		('Jos',null,'Verhoeven','Guldensporenweg 501' , '4000','08123445','M','1944-03-19',2,1886,1,1,'2024-06-01  10:00:00'),
		('Koen',null,'Peeters','Molenstraat 23'  , '4000','08123445','M','1935-08-07',2,18528758,1,1,'2024-06-01  10:00:00'),
		('Lina','','Horton','kruispad 5' , '2500','08128845','V','2010-05-01',2,17832,1,1,'2024-06-01  10:00:00'),
		('Louise','','Beck','Antwerpsesteenweg 455' , '3000','07893445','V','2013-06-15',2,17832,1,1,'2024-07-01  10:00:00'),
		('Eva','','Fleming','bosdreef 4' , '4000','08145245','V','2011-09-14',2,17832,1,1,'2024-08-01  10:00:00'),
		('Anna','','Mendez','Bergeneinde 12' , '7889','01113445','V','2016-10-01',2,17832,1,1,'2024-02-01  10:00:00'),
		('Mila','','Janssens','Beerselaan 2' , '1235','08122245','V','2015-11-16',2,17832,1,1,'2024-11-01  10:00:00'),
		('Juliette','','Kruismans','Turnanovalaan 45a' , '6544','07422445','V','2001-12-25',2,17832,1,1,'2024-12-01  10:00:00'),
		('Clara','','Homans','lindelaan 56' , '7889','01113445','V','2007-10-03',2,17832,1,1,'2024-02-01  10:00:00'),
		('Ada','','Bale','Grotedreef 7' , '1235','08122245','V','2009-11-11',2,17832,1,1,'2024-11-01  10:00:00'),
		('Sofia','','Evenepoel','kleineweg 2' , '6544','07422445','V','2002-12-20',2,17832,1,1,'2024-12-01  10:00:00'),
		('Marc','','Timmermans','Brusselsebaan 788' , '6000','081245848','M','1999-01-12',2,17832,1,1,'2024-04-05  10:00:00'),
		('Piet','','Gevers','Brugsebaan 4' , '2000','0854448','M','2003-05-19',2,17832,1,1,'2024-04-06  10:00:00'),
		('Leo','','VanderElst','Molenpad 14' , '2000','455555','M','2006-10-18',2,17832,1,1,'2024-02-07  10:00:00'),
		('Bert','','Kruismans','Ziekenhuislaan 2' , '5444','4516987','M','2008-03-18',2,17832,1,1,'2024-01-07  10:00:00'),
		('Bart','','Sommers','verweg 12' , '5444','451257','M','1997-05-22',2,17832,1,1,'2024-04-02  10:00:00')


	Insert into Course(CourseName ,CourseStartDate,CourseEndDate ,MinimumGradeToPassTheCourse,
	MaximumTestCourseGrade, CourseTypeId, CostPrice  
	)
	values
	('Piano starter', '2024-06-01  10:00:00',  '2024-11-01  10:00:00', 6,10, 1,100),
	('Piano advanced', '2024-10-01  10:00:00',  '2044-06-01  10:00:00', 6,10, 1,100),
	('classical Giutar starter', '2024-01-01  10:00:00',  '2024-10-01  10:00:00', 6,10, 1,100),
	('classical Giutar advanced', '2024-10-01  10:00:00',  '2024-11-01  10:00:00', 6,10, 1,100),
	('Bass Giutar advanced', '2024-10-01  10:00:00',  '2024-11-01  10:00:00', 6,10, 1,100),
	('Singing', '2024-10-01  10:00:00',  '2024-11-01  10:00:00', 6,10, 1,100),
	('drum', '2023-10-01  10:00:00',  '2023-11-01  10:00:00', 6,10, 1,100),
	('Keyboard starter', '2023-10-01  10:00:00',  '2023-11-01  10:00:00', 6,10, 1,100),
	('saxophone', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,100),
	('French beginner', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,100),
	('French advanced', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,100),
	('Dutch beginner', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,100),
	('Dutch advanced', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,100),
	('Dutch beginner', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,100),
	('Mathematics1', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10,1,100),
	('Mathematics2', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10, 1,100),
	('Mathematics3', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10,1,100),
	('Chemistry1', '2023-11-01  10:00:00',  '2023-12-01  10:00:00', 6,10,1,100)


insert into Teacher
  ( FirstName  , MiddleName  , LastName  , StreetAndNumber  , ZipCode  , PhoneNumber  , EmailAddress ,
         Gender , DateOfBirth  , MaritalStatusId   , NationalRegisterNumber  , NationalityId  , MoederTongueId  ,
         LanguageSkill  , HireDate  , LeaveDate  , SaleryCategorieId   , SeniorityYears   , WorkSchedule 
      , WorkingHoursPerWeek , HighestDegreeId  , StudyDirection )
values
('Paul','','Janssens','Bospad 30', 3000,'5644684','pauljanssens@test.be','M','1988-11-01',0,444,1,0,1,'2008-11-01',null,1,10,1,38,1,1),
('Dirk','','Verhoeven','Hoofdbaan 45a', 5000,'5644684','dirkveroeven@test.be','M','1978-10-01',0,444,1,0,1,'2008-11-01',null,1,10,1,38,1,1),
('Leen','','Verachterd','Zijstraat ', 9000,'2224684','leenverachterd@test.be','V','2002-5-01',0,444,1,0,1,'2008-11-01',null,1,10,1,38,1,1),
('Jos','','Peeters','Zijstraat ', 9000,'1114684','jospeeters@test.be','M','2001-3-01',0,444,1,0,1,'2008-11-01',null,1,10,1,38,1,1),
('An','','Snels','Berksebaan 5', 4500,'1114684','ansnels@test.be','V','2000-3-01',0,444,1,0,1,'2008-11-01',null,1,10,1,38,1,1),
('James','','Dean','Turnhoutsebaan 456', 3000,'4564684','James@test.be','M','2000-3-01',0,444,1,0,1,'2004-11-02',null,1,10,1,38,1,1),
('Victor','','Verhulst','Kerstraat 33a', 3000,'3224684','victorverhulst@test.be','M','2000-3-01',0,444,1,0,1,'2000-11-02',null,1,10,1,38,1,1)



	Insert into StudentCourse(StudentId,CourseId,CourseTestGrade)
	values
	(1,1,null),
	(1,2,null),
	(1,3,null),
	(2,1,null),
	(2,2,null),
	(3,1,null),
	(3,7,null),
	(3,8,null),
	(3,9,null),
	(2,2,null),
	(3,2,null),
	(4,5,null),
	(4,6,null)


	Insert into InlogUser(UserName, UserPassword,UserRoleId,ActiveFrom,Blocked,PersonId)
	values 
	('admin','schoolSoft4you', 0,'2024-06-01  10:00:00',0,0),
	('koenverboven','rgSeg@45',1,'2024-06-01  10:00:00',0,1),
	('mariapoels','regreT@488',1,'2024-06-01  10:00:00',0,2),
	('johanverboven','threM@566',1,'2024-06-01  10:00:00',0,3)




	select * from Student S inner join StudentCourse SC
	on S.StudentId = SC.StudentId inner join Course C
	on C.CourseId = SC.CourseId