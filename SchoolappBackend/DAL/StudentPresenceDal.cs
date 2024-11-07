using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Configuration;

namespace SchoolappBackend.DAL
{
    internal class StudentPresenceDal
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        public List<StudentPresenceNotation> GetStudentPrecence()
        {
            var studentPresenceList = new List<StudentPresenceNotation>();

            var query = "SELECT StudentId ,FirstName ,MiddleName ,LastName  " +
                        "FROM Student " +
                        "ORDER BY LastName";

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
                            var studentPresence = new StudentPresenceNotation()
                            {
                                StudentPresenceNotationId = Convert.ToInt32(reader["StudentId"]),//todo aanpassen
                                StudentId = Convert.ToInt32(reader["StudentId"]),
                                StudentFullName = Convert.ToString(reader["LastName"] + " " + reader["FirstName"]),
                                Presence = false,
                                Comment = "ziekte"
                            };
                            studentPresenceList.Add(studentPresence);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return studentPresenceList;
        }


        public bool AddStudentPresence(StudentPresenceNotation studentPresenceNotation)
        {
            try
            {
                var query = "Insert into StudentPresence" +
                            "(StudentId, NotationDate, SchoolClassId," +
                            "CourseLessonId, NotedByTeacherId, Presence, Comment)" +
                            "values" +
                            "(" +
                                "@StudentId, @NotationDate, @SchoolClassId," +
                                "@CourseLessonId, @NotedByTeacherId, @Presence, @Comment" +
                            ")";

                CreateCommandStudentPresence(connectionString, query, studentPresenceNotation, RecordAction.insert);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        private static void CreateCommandStudentPresence(string connectionString, string queryString, StudentPresenceNotation studentPresenceNotation, RecordAction action)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(queryString, connection);

                    command.Parameters.Add("@StudentId", SqlDbType.Int).Value = studentPresenceNotation.StudentId;
                    command.Parameters.Add("@NotationDate", SqlDbType.DateTime).Value = studentPresenceNotation.NotationDate;
                    command.Parameters.Add("@SchoolClassId", SqlDbType.Int).Value = studentPresenceNotation.ClassId;
                    command.Parameters.Add("@CourseLessonId", SqlDbType.Int).Value = studentPresenceNotation.CourseLessonId;//todo int? replace by smallint?
                    command.Parameters.Add("@NotedByTeacherId", SqlDbType.Int).Value = studentPresenceNotation.NotedByTeacherId;
                    command.Parameters.Add("@Presence", SqlDbType.Bit).Value = studentPresenceNotation.Presence;
                    command.Parameters.Add("@Comment", SqlDbType.VarChar, 50).Value = studentPresenceNotation.Comment;

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
