	USE School1


	if object_id('Student') is null
	begin
		create table Student
		(
			StudentId int identity(1,1) not null,
			FirstName varchar(50) not null,
			MiddleName varchar(50) null,
			LastName varchar(50) not null,
			StreetAndNumber varchar(60) not null,
			ZipCode varchar(6) not null,
			PhoneNumber varchar(10) null,
			EmailAddress varchar(60) null,
			Gender tinyint not null,
			DateOfBirth date not null,
			MaritalStatusId tinyint not null, 
			NationalRegisterNumber varchar(11) null, 
			Nationality smallint null, 
			MoederTongueId smallint null, 
			LanguageSkill smallint null, 
			Registrationdate date not null,
			constraint PK_Student primary key(StudentId),
		)
	end


	if object_id('Teacher') is null
	begin
		create table Teacher
		(
			TeacheId int identity(1,1) not null,
			FirstName varchar(50) not null,
			MiddleName varchar(50) null,
			LastName varchar(50) not null,
			StreetAndNumber varchar(60) not null,
			ZipCode varchar(6) not null,
			PhoneNumber varchar(10) null,
			EmailAddress varchar(60) null,
			Gender char not null,
			DateOfBirth date not null,
			MaritalStatusId tinyint not null, 
			NationalRegisterNumber int null, 
			NationalityId smallint null, 
			MoederTongueId smallint null, 
			LanguageSkill smallint null, 
			HireDate date not null,
			LeaveDate date null,
			SaleryCategorieId int null,
			SeniorityYears tinyint null,
			WorkSchedule tinyint null,
			WorkingHoursPerWeek tinyint null,
			HighestDegreeId tinyint not null,
			StudyDirection smallint not null,
			constraint PK_Teacher primary key(TeacheId),
		)
		end

	if object_id('Course') is null
	begin
		create table Course
		(
			CourseId int identity(1,1) not null,
			CourseName varchar(60) not null,
			CourseStartDate date null,
			CourseEndDate date null,
			MinimumGradeToPassTheCourse decimal(5,2) null,
			MaximumTestCourseGrade int null,
			CourseTypeId int null,
			CostPrice  money null,
			constraint PK_Course primary key (CourseId)
		);
	end

	if object_id('StudentCourse') is null
	begin
		create table StudentCourse
		(
			StudentCourseId int identity(1,1) not null,
			StudentId int not null,
			CourseId int not null,
			CourseTestGrade decimal(5,2) null,
			constraint PK_StudentCourse primary key (StudentCourseId),
			constraint FK_StudentCourseStudent
				foreign key(StudentId)
				references Student(StudentId),
			constraint FK_StudentCourseCourse
				foreign key(CourseId)
				references Course(CourseId)
		);
	end

	if object_id('InlogUser') is null
	begin
		create table InlogUser
		(
			UserId int identity(1,1) not null,
			UserName varchar(30) not null,
			UserPassword varchar(100) not null,
			UserRoleId smallint not null,
			ActiveFrom datetime null,
			Blocked bit not null,
			PersonId int not null
			constraint PK_User primary key(UserId),
		)
	end

	if object_id('School') is null
	begin
		create table School
		(
			SchoolId int identity(1,1) not null,
			SchoolName varchar(60) not null,
			SchoolGroupId int  not null,
			StreetAndNumer varchar(60) null,
			Zipcode varchar(6) null,
			PhoneNumber varchar(10) null,
			Constraint PK_School primary key(SchoolId),
		)
	end



	if object_id('SchoolDepartment') is null
	begin
		create table SchoolDepartment
		(
			SchoolDepartmentId int identity(1,1) not null,
			SchoolDepartmentName varchar(70) not null,
			SchoolId varchar(70) null,
			Constraint PK_SchoolDepartment primary key(SchoolDepartmentId),
		)
	end


	if object_id('SchoolClass') is null
	begin
		create table SchoolClass
		(
			SchoolClassId int identity(1,1) not null,
			Code varchar(10) not null,
			ClassDescription varchar(60) null,
			Degree int null,
			Grade int null,
			SchoolDepartmentId int not null,
			Constraint PK_SchoolClass primary key(SchoolClassId),
		)
	end


	if object_id('StudentPresence') is null
	begin
		create table StudentPresence
		(
			StudentPresenceId int identity(1,1) not null,
			StudentId int not null,
			NotationDate datetime not null,
			SchoolClassId int not null,
			CourseLessonId int not null,
			NotedByTeacherId int not null,
			Presence int not null,
			Comment varchar(50) null,
			constraint PK_StudentPresence primary key(StudentPresenceId),
		)
	end


	if object_id('StudentClass') is null
	begin
		create table StudentClass
		(
			StudentClassId int identity(1,1) not null,
			StudentId int not null,
			ClassId int not null,
			StartDate date not null,
			StopDate date not null,
			constraint PK_StudentClass primary key(StudentClassId),
		)
	end


	-- tables related to examens an excercises :
	
	if object_id('Examen') is null
	begin
		create table  Examen
		(
			ExamenId int identity(1,1) not null,
			ExamenName varchar(50) not null,
			Description varchar(150) null,
			ExamenKind tinyInt not null,
			CreatedByTeacherId int not null,
			CreateDate datetime not null,
			UpdatedByTeacherId int null,
			UpdateDate datetime null,
			constraint PK_Examen primary key( ExamenId)
		)
	end

	if object_id('ExamenQuestion') is null
	begin
		create table ExamenQuestion
		(
			ExamenQuestionId int  identity(1,1) not null,
			Question varchar(150) not null,
			Answer varchar(200) null,
			ExamenQuestionPointsWeight decimal(5,2) null, -- misschien niet nodig?
			ExamenId int not null,
			constraint PK_EQuestionAnswer primary key(ExamenQuestionId),
			constraint FK_ExamenQuestionExamen
				foreign key( ExamenId)
				references  Examen( ExamenId)
		)
	end

	if object_id('ExamenAnswer') is null
	begin
		create table ExamenAnswer
		(
			ExamenAnswerId int  identity(1,1) not null,
			Answer varchar(150) not null,
			CorrectAnswer bit not null, -- for multiplechoice questions
			ExamenQuestionId int not null,
			constraint PK_ExamenAnswer primary key(ExamenAnswerId),
			constraint ExamenAnswerExamenQuestion
				foreign key( ExamenQuestionId)
				references  ExamenQuestion( ExamenQuestionId)
		)
	end