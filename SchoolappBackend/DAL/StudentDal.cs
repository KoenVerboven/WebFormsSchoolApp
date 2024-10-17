using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace SchoolappBackend.DAL
{
    public class StudentDal
    {
        string connectionString = "Data Source=KOENI7;Initial Catalog=School1;Integrated Security=True";

        public List<Student> GetStudents()
        {
            var studentsList = new List<Student>();

            var query = "SELECT StudentId ,FirstName ,MiddleName ,LastName ,StreetAndNumber  ,ZipCode, " +
                             "PhoneNumber ,EmailAddress ,Gender ,DateOfBirth ,MaritalStatusId  ,NationalRegisterNumber," +
                             "Nationality ,MoederTongueId ,LanguageSkill ,Registrationdate " +
                        "FROM Student " +
                        "ORDER BY StudentId ";



            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var student = new Student()
                    {
                        PersonId = Convert.ToInt32(reader["StudentId"]),
                        LastName = Convert.ToString(reader["LastName"]),
                        MiddleName = Convert.ToString(reader["MiddleName"]),
                        Firstname = Convert.ToString(reader["FirstName"]),
                        StreetAndNumber = Convert.ToString(reader["StreetAndNumber"]),
                        ZipCode = Convert.ToString(reader["ZipCode"]),
                        PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                        EmailAddress = Convert.ToString(reader["EmailAddress"]),
                        DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                        RegistrationDate = Convert.ToDateTime(reader["Registrationdate"])
                    };
                    studentsList.Add(student);
                }
            }
            reader.Close();
            return studentsList;
        }

        public Student GetStudentById(int studentId)
        {
            var query = "SELECT StudentId ,FirstName ,MiddleName ,LastName ,StreetAndNumber  ,ZipCode," +
                             "PhoneNumber ,EmailAddress ,Gender ,DateOfBirth ,MaritalStatusId  ,NationalRegisterNumber," +
                             "Nationality ,MoederTongueId ,LanguageSkill ,Registrationdate " +
                         "FROM Student " +
                         "WHERE StudentId = @StudentId";

            try
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@StudentId", SqlDbType.Int, 50).Value = studentId;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var student = new Student()
                        {
                            PersonId = Convert.ToInt32(reader["StudentId"]),
                            LastName = Convert.ToString(reader["LastName"]),
                            MiddleName = Convert.ToString(reader["MiddleName"]),
                            Firstname = Convert.ToString(reader["FirstName"]),
                            StreetAndNumber = Convert.ToString(reader["StreetAndNumber"]),
                            ZipCode = Convert.ToString(reader["ZipCode"]),
                            PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                            EmailAddress = Convert.ToString(reader["EmailAddress"]),
                            DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]),
                            RegistrationDate = Convert.ToDateTime(reader["Registrationdate"]),
                        };
                        return student;
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
