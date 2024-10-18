using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace SchoolappBackend.DAL
{
    internal class TeacherDal
    {
        string connectionString = "Data Source=KOENI7;Initial Catalog=School1;Integrated Security=True";

        public List<Teacher> GetTeachers()
        {
            var teachersList = new List<Teacher>();

            var query = "SELECT TeacheId, FirstName, MiddleName, LastName, StreetAndNumber, ZipCode, PhoneNumber, EmailAddress, " +
                         "Gender, DateOfBirth, MaritalStatusId, NationalRegisterNumber, NationalityId, MoederTongueId," +
                         "LanguageSkill, HireDate, LeaveDate, SaleryCategorieId, SeniorityYears, WorkSchedule," +
                         "WorkingHoursPerWeek, HighestDegreeId, StudyDirection " +
                         "FROM Teacher " +
                         "ORDER BY  TeacheId";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var teacher = new Teacher()
                    {
                        PersonId = Convert.ToInt32(reader["TeacheId"]),
                        LastName = Convert.ToString(reader["LastName"]),
                        MiddleName = Convert.ToString(reader["MiddleName"]),
                        Firstname = Convert.ToString(reader["FirstName"]),
                        StreetAndNumber = Convert.ToString(reader["StreetAndNumber"]),
                        ZipCode = Convert.ToString(reader["ZipCode"]),
                        PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                        EmailAddress = Convert.ToString(reader["EmailAddress"]),
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                    };
                    teachersList.Add(teacher);
                }
            }
            reader.Close();
            return teachersList;
        }

        public Teacher GetTeacherById(int teacherId)
        {
            var query = "SELECT TeacheId, FirstName, MiddleName, LastName, StreetAndNumber, ZipCode, PhoneNumber, EmailAddress, " +
                          "Gender, DateOfBirth, MaritalStatusId, NationalRegisterNumber, NationalityId, MoederTongueId," +
                          "LanguageSkill, HireDate, LeaveDate, SaleryCategorieId, SeniorityYears, WorkSchedule," +
                          "WorkingHoursPerWeek, HighestDegreeId, StudyDirection " +
                          "FROM Teacher " +
                          "WHERE TeacheId = @TeacheId";

            try
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@TeacheId", SqlDbType.Int, 50).Value = teacherId;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var teacher = new Teacher()
                        {
                            PersonId = Convert.ToInt32(reader["TeacheId"]),
                            LastName = Convert.ToString(reader["LastName"]),
                            MiddleName = Convert.ToString(reader["MiddleName"]),
                            Firstname = Convert.ToString(reader["FirstName"]),
                            StreetAndNumber = Convert.ToString(reader["StreetAndNumber"]),
                            ZipCode = Convert.ToString(reader["ZipCode"]),
                            PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                            EmailAddress = Convert.ToString(reader["EmailAddress"]),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                        };
                        return teacher;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public bool DeleteTeacher(int teacherId)
        {
            var query = "DELETE FROM teacher WHERE teacheId = @TeacherId";
            var connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@TeacherId", SqlDbType.Int, 50).Value = teacherId;
                command.Connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool AddNewTeacher(Teacher teacher)
        {
            try
            {
                var query = "INSERT into Teacher," +
                            "(FirstName, MiddleName, LastName, StreetAndNumber, ZipCode, PhoneNumber, EmailAddress," +
                             "Gender, DateOfBirth, MaritalStatusId, NationalRegisterNumber, NationalityId, MoederTongueId," +
                             "LanguageSkill, HireDate, LeaveDate, SaleryCategorieId, SeniorityYears, WorkSchedule," +
                             "WorkingHoursPerWeek, HighestDegreeId, StudyDirection)" +
                            "VALUES (" +
                             "@FirstName, @MiddleName, @LastName, @StreetAndNumber, @ZipCode, @PhoneNumber, @EmailAddress," +
                             "@Gender, @DateOfBirth, @MaritalStatusId, @NationalRegisterNumber, @NationalityId, @MoederTongueId," +
                             "@LanguageSkill, @HireDate, @LeaveDate, @SaleryCategorieId, @SeniorityYears, @WorkSchedule," +
                             "@WorkingHoursPerWeek, @HighestDegreeId, @StudyDirection" +
                            ")";

               
                CreateCommand(connectionString, query, teacher, RecordAction.insert);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public bool Update(Teacher teacher)
        {
            var query = "UPDATE Teacher " +
                        "SET " +
                        "FirstName = @FirstName," +
                        "MiddleName = @MiddleName," +
                        "LastName = @LastName," +
                        "StreetAndNumber = @StreetAndNumber," +
                        "ZipCode = @ZipCode," +
                        "PhoneNumber = @PhoneNumber," +
                        "EmailAddress = @EmailAddress," +
                        "Gender = @Gender," +
                        "DateOfBirth = @DateOfBirth," +
                        "MaritalStatusId = @MaritalStatusId," +
                        "NationalRegisterNumber = @NationalRegisterNumber," +
                        "NationalityId = @NationalityId," +
                        "MoederTongueId = @MoederTongueId," +
                        "LanguageSkill = @LanguageSkill," +
                        //"HireDate = "+ DateTime.Now +"," +
                        //"LeaveDate = " + DateTime.Now + "," + 
                        "SaleryCategorieId = @SaleryCategorieId," +
                        "SeniorityYears = @SeniorityYears," +
                        "WorkSchedule = @WorkSchedule," +
                        "WorkingHoursPerWeek = @WorkingHoursPerWeek," +
                        "HighestDegreeId = @HighestDegreeId," +
                        "StudyDirection = @StudyDirection " +
                        "WHERE TeacheId = @TeacheId ";

            try
            {
                CreateCommand(connectionString, query, teacher, RecordAction.update);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        private static void CreateCommand(string connectionString, string queryString, Teacher teacher, RecordAction action)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                var command = new SqlCommand(queryString, connection);

                if (action == RecordAction.update)
                {
                    command.Parameters.Add("@TeacheId", SqlDbType.Int).Value = teacher.PersonId;
                }

                command.Parameters.Add("@FirstName", SqlDbType.VarChar, 50).Value = teacher.Firstname;
                command.Parameters.Add("@MiddleName", SqlDbType.VarChar, 50).Value = teacher.MiddleName;
                command.Parameters.Add("@LastName", SqlDbType.VarChar, 50).Value = teacher.LastName;
                command.Parameters.Add("@StreetAndNumber", SqlDbType.VarChar, 50).Value = teacher.StreetAndNumber;
                command.Parameters.Add("@ZipCode", SqlDbType.VarChar, 50).Value = teacher.ZipCode;
                command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 50).Value = teacher.PhoneNumber;
                command.Parameters.Add("@EmailAddress", SqlDbType.VarChar, 50).Value = teacher.EmailAddress;
                command.Parameters.Add("@Gender", SqlDbType.Char, 50).Value = 'M'; //student.Gender; //todo gender
                command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime, 50).Value = DateTime.Now; //todo student.DateOfBirth;
                command.Parameters.Add("@MaritalStatusId", SqlDbType.TinyInt, 50).Value = 1;//
                command.Parameters.Add("@NationalRegisterNumber", SqlDbType.SmallInt, 50).Value = 1;// todo student.NationalRegisterNumber;
                command.Parameters.Add("@NationalityId", SqlDbType.SmallInt).Value = 1;//todo student.Nationality; 
                command.Parameters.Add("@MoederTongueId", SqlDbType.SmallInt).Value = 1; //todo student.MoederTongueId;
                command.Parameters.Add("@LanguageSkill", SqlDbType.SmallInt).Value = //teacher.la;
                //command.Parameters.Add("@HireDate",SqlDbType.DateTime, 50).Value = DateTime.Now; //todo teacher.HireDate;//hiredate and leavedate gives error
                //command.Parameters.Add("@LeaveDate", SqlDbType.DateTime,50).Value = DateTime.Now;// teacher.LeaveDate;//
                command.Parameters.Add("@SaleryCategorieId", SqlDbType.Int).Value = 1;//teacher.SaleryCategorie;
                command.Parameters.Add("@SeniorityYears", SqlDbType.TinyInt).Value = 1;// teacher.SeniorityYears;
                command.Parameters.Add("@WorkSchedule", SqlDbType.Int).Value = 1;//teacher.w;
                command.Parameters.Add("@WorkingHoursPerWeek", SqlDbType.TinyInt).Value = 1;//teacher.w;
                command.Parameters.Add("@HighestDegreeId", SqlDbType.TinyInt).Value = 1;//teacher.h;
                command.Parameters.Add("@StudyDirection", SqlDbType.SmallInt).Value = 1;//teacher.st;

                command.Connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
