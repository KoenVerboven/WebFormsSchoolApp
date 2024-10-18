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


        public bool UpdateCourse(Teacher teacher)
        {
            var query = "Teacher InlogUser " +
                        "SET " +
                        "FirstName = @FirstName, " +
                        "MiddleName = @MiddleName, " +
                        "LastName = @LastName, " +
                        "StreetAndNumber = @, " +
                        "ZipCode = @ZipCode, " +
                        "PhoneNumber = @PhoneNumber, " +
                        "EmailAddress = @EmailAddress, " +
                        "Gender = @Gender, " +
                        "DateOfBirth = @DateOfBirth, " +
                        "MaritalStatusId = @MaritalStatusId, " +
                        "NationalRegisterNumber = @NationalRegisterNumber, " +
                        "NationalityId = @NationalityId, " +
                        "MoederTongueId = @MoederTongueId, " +
                        "LanguageSkill = @LanguageSkill, " +
                        "HireDate = @HireDate, " +
                        "LeaveDate = @LeaveDate, " +
                        "SaleryCategorieId = @SaleryCategorieId, " +
                        "SeniorityYears = @SeniorityYears, " +
                        "WorkSchedule = @WorkSchedule, " +
                        "WorkingHoursPerWeek = @WorkingHoursPerWeek, " +
                        "HighestDegreeId = @HighestDegreeId, " +
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
                    //command.Parameters.Add("@UserId", SqlDbType.Int).Value = user.UserId;
                }

                if (action == RecordAction.insert)
                {
                    //command.Parameters.Add("@UserPassword", SqlDbType.VarChar).Value = user.Password;
                }

                //command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = user.UserName;

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
