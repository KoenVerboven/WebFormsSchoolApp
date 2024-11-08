using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SchoolappBackend.DAL
{
    internal class TeacherDal
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        public List<Teacher> GetTeachers(string filter, string orderby, string sortDirection)
        {
            var teachersList = new List<Teacher>();

            var query = "SELECT TeacheId, FirstName, MiddleName, LastName, StreetAndNumber, ZipCode, PhoneNumber, EmailAddress, " +
                            "Gender, DateOfBirth, MaritalStatusId, NationalRegisterNumber, NationalityId, MoederTongueId," +
                            "LanguageSkill, HireDate, LeaveDate, SaleryCategorieId, SeniorityYears, WorkSchedule," +
                            "WorkingHoursPerWeek, HighestDegreeId, StudyDirection " +
                        "FROM Teacher ";

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
                query += "ORDER BY TeacheId desc";
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
                }
            }
            catch (Exception)
            {

                throw;
            }
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
                using (var connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@TeacheId", SqlDbType.Int, 50).Value = teacherId;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            var leaveDate = new DateTime(1900, 01, 01);
                            if (reader["LeaveDate"].GetType() != typeof(DBNull))
                                leaveDate = Convert.ToDateTime(reader["LeaveDate"]);

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
                                HireDate = Convert.ToDateTime(reader["HireDate"]),
                                LeaveDate = leaveDate
                            };
                            return teacher;
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

        public int GetTeacherCount()
        {
            var query = "SELECT count(*) FROM Teacher";

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



        public bool DeleteTeacher(int teacherId)
        {
            var query = "DELETE FROM teacher WHERE teacheId = @TeacherId";
           

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@TeacherId", SqlDbType.Int, 50).Value = teacherId;
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    return true;
                }
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
                var query = "INSERT into Teacher " +
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
                            "HireDate = @HireDate," +
                            "LeaveDate = @LeaveDate," + 
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
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(queryString, connection);

                    if (action == RecordAction.update)
                    {
                        command.Parameters.Add("@TeacheId", SqlDbType.Int).Value = teacher.PersonId;
                    }

                    command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = teacher.Firstname;
                    command.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = teacher.MiddleName;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = teacher.LastName;
                    command.Parameters.Add("@StreetAndNumber", SqlDbType.VarChar, 60).Value = teacher.StreetAndNumber;
                    command.Parameters.Add("@ZipCode", SqlDbType.VarChar, 6).Value = teacher.ZipCode;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar, 10).Value = teacher.PhoneNumber;
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar, 60).Value = teacher.EmailAddress;
                    command.Parameters.Add("@Gender", SqlDbType.Char).Value = 'M'; //student.Gender; //todo gender
                    command.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = teacher.DateOfBirth;
                    command.Parameters.Add("@MaritalStatusId", SqlDbType.TinyInt, 1).Value = 1;//
                    command.Parameters.Add("@NationalRegisterNumber", SqlDbType.SmallInt, 50).Value = 1;// todo student.NationalRegisterNumber;
                    command.Parameters.Add("@NationalityId", SqlDbType.SmallInt).Value = 1;//todo student.Nationality; 
                    command.Parameters.Add("@MoederTongueId", SqlDbType.SmallInt).Value = 1; //todo student.MoederTongueId;
                    command.Parameters.Add("@LanguageSkill", SqlDbType.SmallInt).Value = 1;//teacher.la;
                    command.Parameters.Add("@HireDate", SqlDbType.Date).Value = teacher.HireDate;
                    command.Parameters.Add("@LeaveDate", SqlDbType.Date).Value = teacher.LeaveDate; //doto leavedate klop niet helemaal
                    command.Parameters.Add("@SaleryCategorieId", SqlDbType.Int).Value = 1;//teacher.SaleryCategorie;
                    command.Parameters.Add("@SeniorityYears", SqlDbType.TinyInt).Value = 1;// teacher.SeniorityYears;
                    command.Parameters.Add("@WorkSchedule", SqlDbType.Int).Value = 1;//teacher.w;
                    command.Parameters.Add("@WorkingHoursPerWeek", SqlDbType.TinyInt).Value = 1;//teacher.w;
                    command.Parameters.Add("@HighestDegreeId", SqlDbType.TinyInt).Value = 1;//teacher.h;
                    command.Parameters.Add("@StudyDirection", SqlDbType.SmallInt).Value = 1;//teacher.st;

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
