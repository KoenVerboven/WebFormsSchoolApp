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
    }
}
