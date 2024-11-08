using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SchoolappBackend.DAL
{
        
    public class StudentDal
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        public List<Student> GetStudents(string filter , string orderby, string sortDirection)
        {
            var studentsList = new List<Student>();

            var query = "SELECT StudentId ,FirstName ,MiddleName ,LastName ,StreetAndNumber  ,ZipCode, " +
                             "PhoneNumber ,EmailAddress ,Gender ,DateOfBirth ,MaritalStatusId  ,NationalRegisterNumber," +
                             "Nationality ,MoederTongueId ,LanguageSkill ,Registrationdate " +
                        "FROM Student ";

            if (filter.Trim() != string.Empty)
            {
                query += "WHERE LastName like '%" + filter + "%' ";
                query += "OR FirstName like '%" + filter + "%' ";
            }
            if (orderby.Trim() != string.Empty)
            {
                query += "ORDER BY " + orderby + " " + sortDirection;
            }
            else
            {
                query += "ORDER BY StudentId desc";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
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
                                RegistrationDate = Convert.ToDateTime(reader["Registrationdate"]),
                                Gender = Convert.ToInt32(reader["gender"])
                            };
                            studentsList.Add(student);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return studentsList;
        }


        public int GetStudentCount()
        {
            var query = "SELECT count(*) FROM Student";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
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
                using (var connection = new SqlConnection(connectionString))
                {
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
                                Gender = Convert.ToInt32(reader["Gender"]),
                                Nationality = Convert.ToInt32(reader["Nationality"]),
                                NationalRegisterNumber = Convert.ToString(reader["NationalRegisterNumber"]),
                                MaritalStatus = Convert.ToInt32(reader["MaritalStatusId"])
                            };
                            reader.Close(); //ToDo : overal nakijken of Close aanwezig is
                            return student;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }


        public bool AddNewStudent(Student student)
        {
            try
            {
                var query = "Insert into Student" +
                            "(FirstName, MiddleName, LastName, StreetAndNumber, ZipCode, PhoneNumber, " +
                            "EmailAddress,Gender, DateOfBirth, MaritalStatusId, NationalRegisterNumber, Nationality," +
                            "MoederTongueId, Registrationdate ) " +
                            " values (" +
                                        "@FirstName, @MiddleName, @LastName, @StreetAndNumber, @ZipCode, @PhoneNumber," +
                                        "@EmailAddress, @Gender, @DateOfBirth,@MaritalStatusId," +
                                        " @NationalRegisterNumber,@Nationality,@MoederTongueId, @Registrationdate" +
                                    ")";

                CreateCommandStudent(connectionString, query, student, RecordAction.insert);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public bool UpdateStudent(Student student)
        {
            var query = "UPDATE student " +
                        "SET " +
                            "FirstName = @FirstName, " +
                            "LastName = @LastName, " +
                            "MiddleName = @MiddleName, " +
                            "StreetAndNumber = @StreetAndNumber, " +
                            "ZipCode = @ZipCode, " +
                            "PhoneNumber = @PhoneNumber, " +
                            "EmailAddress = @EmailAddress, " +
                            "Gender = @Gender, " +
                            "DateOfBirth = @DateOfBirth, " +
                            "MaritalStatusId = @MaritalStatusId, " +
                            "NationalRegisterNumber = @NationalRegisterNumber, " +
                            "Nationality = @Nationality, " +
                            "MoederTongueId = @MoederTongueId " +
                        "WHERE StudentId = @StudentId ";

            try
            {
                CreateCommandStudent(connectionString, query, student, RecordAction.update);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteStudent(int studentId)
        {
            var query = "delete from student where StudentId = @StudentId";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@StudentId", SqlDbType.Int, 50).Value = studentId;
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }



        private static void CreateCommandStudent(string connectionString, string queryString, Student student, RecordAction action)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(queryString, connection);

                    if (action == RecordAction.update)
                    {
                        command.Parameters.Add("@StudentId", SqlDbType.Int).Value = student.PersonId;
                    }

                    if (action == RecordAction.insert)
                    {
                        command.Parameters.Add("@Registrationdate", SqlDbType.DateTime).Value = student.RegistrationDate;
                    }

                    command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = student.Firstname;
                    command.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = student.MiddleName;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = student.LastName;
                    command.Parameters.Add("@StreetAndNumber", SqlDbType.VarChar, 60).Value = student.StreetAndNumber;
                    command.Parameters.Add("@ZipCode", SqlDbType.VarChar, 6).Value = student.ZipCode;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 10).Value = student.PhoneNumber;
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar, 60).Value = student.EmailAddress;
                    command.Parameters.Add("@Gender", SqlDbType.Int).Value = student.Gender;
                    command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = student.DateOfBirth;
                    command.Parameters.Add("@MaritalStatusId", SqlDbType.Int).Value = student.MaritalStatus;
                    command.Parameters.Add("@NationalRegisterNumber", SqlDbType.VarChar, 50).Value = student.NationalRegisterNumber;
                    command.Parameters.Add("@Nationality", SqlDbType.Int).Value = student.Nationality;
                    command.Parameters.Add("@MoederTongueId", SqlDbType.Int).Value = 1; //todo student.MoederTongueId;

                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
