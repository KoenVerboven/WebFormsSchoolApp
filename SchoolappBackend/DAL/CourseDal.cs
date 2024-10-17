using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SchoolappBackend.BLL.models;

namespace SchoolappBackend.DAL
{
    internal class CourseDal
    {
        string connectionString = "Data Source=KOENI7;Initial Catalog=School1;Integrated Security=True";

        public List<Course> GetCourses()
        {
            var coursesList = new List<Course>();

            var query = "SELECT CourseId ,CourseName ,CourseStartDate ,CourseEndDate ,MinimumGradeToPassTheCourse," +
                            "MaximumTestCourseGrade ,CourseIsActive ,CourseTypeId ,CostPrice " +
                         "FROM Course " +
                         "ORDER BY CourseId ";

            var connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var course = new Course()
                    {
                        CourseId = Convert.ToInt32(reader["CourseId"]),
                        CourseName = Convert.ToString(reader["CourseName"]),
                        CourseDescription = "",//  Convert.ToString(reader["CourseDescription"]),
                        //CourseCode = "",//  Convert.ToString(reader["CourseCode"]),
                        StartDate = Convert.ToDateTime(reader["CourseStartDate"]),
                        EndDate = Convert.ToDateTime(reader["CourseEndDate"]),
                        //MinimumGradeToPassTheCourse = Convert.ToDouble(reader["MinimumGradeToPassTheCourse"]),
                        //MaximumTestCourseGrade = Convert.ToInt32(reader["MaximumTestCourseGrade"]),
                        CourseType = null,
                        CoursePrice = Convert.ToDecimal(reader["CostPrice"]),
                        //Teacher = null
                    };
                    coursesList.Add(course);
                }
            }
            reader.Close();
            return coursesList;
        }


        public Course GetCourseById(int courseId)
        {
            var query = "SELECT CourseId ,CourseName ,CourseStartDate ,CourseEndDate ,MinimumGradeToPassTheCourse," +
                            "MaximumTestCourseGrade ,CourseIsActive ,CourseTypeId ,CostPrice " +
                         "FROM Course " +
                         "WHERE CourseId = @CourseId";

            try
            {
                 var connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@CourseId", SqlDbType.Int, 50).Value = courseId;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var course = new Course()
                        {
                            CourseId = Convert.ToInt32(reader["CourseId"]),
                            CourseName = Convert.ToString(reader["CourseName"]),
                            CourseDescription = "",//  Convert.ToString(reader["CourseDescription"]),
                            //CourseCode = "",//  Convert.ToString(reader["CourseCode"]),
                            StartDate = Convert.ToDateTime(reader["CourseStartDate"]),
                            EndDate = Convert.ToDateTime(reader["CourseEndDate"]),
                            //MinimumGradeToPassTheCourse = Convert.ToDouble(reader["MinimumGradeToPassTheCourse"]),
                            //MaximumTestCourseGrade = Convert.ToInt32(reader["MaximumTestCourseGrade"]),
                            CourseType = null,
                            CoursePrice = Convert.ToDecimal(reader["CostPrice"]),
                            //Teacher = null
                        };
                        return course;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }


        public bool DeleteCourse(int courseId)
        {
            var query = "delete from course where CourseId = @CourseId";
            var connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@CourseId", SqlDbType.Int, 50).Value = courseId;
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


    }
}
