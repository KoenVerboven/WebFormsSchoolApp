﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SchoolappBackend.BLL.models;
using System.Configuration;

namespace SchoolappBackend.DAL
{
    internal class CourseDal
    {
        string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        public List<Course> GetCourses()
        {
            var coursesList = new List<Course>();

            var query = "SELECT CourseId ,CourseName ,CourseStartDate ,CourseEndDate ,MinimumGradeToPassTheCourse," +
                            "MaximumTestCourseGrade ,CourseTypeId ,CostPrice " +
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
                    decimal? coursePrice = null;
                    if(reader["CostPrice"] !=  DBNull.Value)
                    {
                        coursePrice = Convert.ToDecimal(reader["CostPrice"]);
                    }
                    
                    var course = new Course()
                    {
                        CourseId = Convert.ToInt32(reader["CourseId"]),
                        CourseName = Convert.ToString(reader["CourseName"]),
                        StartDate = Convert.ToDateTime(reader["CourseStartDate"]),
                        EndDate = Convert.ToDateTime(reader["CourseEndDate"]),
                        MinimumGradeToPassTheCourse = Convert.ToDouble(reader["MinimumGradeToPassTheCourse"]),
                        MaximumTestCourseGrade = Convert.ToInt32(reader["MaximumTestCourseGrade"]),
                        CourseType = null,
                        CoursePrice = coursePrice,
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
                            "MaximumTestCourseGrade ,CourseTypeId ,CostPrice " +
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

                        decimal? coursePrice = null;
                        if (reader["CostPrice"] != DBNull.Value)
                        {
                            coursePrice = Convert.ToDecimal(reader["CostPrice"]);
                        }

                        var course = new Course()
                        {
                            CourseId = Convert.ToInt32(reader["CourseId"]),
                            CourseName = Convert.ToString(reader["CourseName"]),
                            StartDate = Convert.ToDateTime(reader["CourseStartDate"]),
                            EndDate = Convert.ToDateTime(reader["CourseEndDate"]),
                            MinimumGradeToPassTheCourse = Convert.ToDouble(reader["MinimumGradeToPassTheCourse"]),
                            MaximumTestCourseGrade = Convert.ToInt32(reader["MaximumTestCourseGrade"]),
                            CourseType = null,
                            CoursePrice = coursePrice,
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

        public bool AddNewCourse(Course course)
        {
            try
            {
                var query = "Insert into Course" +
                             "(CourseName, CourseStartDate, CourseEndDate, MinimumGradeToPassTheCourse," +
                             "MaximumTestCourseGrade, CourseTypeId, CostPrice)" +
                             "VALUES (" +
                             "@CourseName, @CourseStartDate, @CourseEndDate, @MinimumGradeToPassTheCourse," +
                             "@MaximumTestCourseGrade, @CourseTypeId, @CostPrice" +
                             ")";

                CreateCommand(connectionString, query, course, RecordAction.insert);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public bool UpdateCourse(Course course)
        {
            var query = "UPDATE Course " +
                        "SET " +
                        "CourseName = @CourseName, " +
                        "CourseStartDate = @CourseStartDate, " +
                        "CourseEndDate = @CourseEndDate, " +
                        "MinimumGradeToPassTheCourse = @MinimumGradeToPassTheCourse, " +
                        "MaximumTestCourseGrade = @MaximumTestCourseGrade, " +
                        "CourseTypeId = @CourseTypeId, " +
                        "CostPrice = @CostPrice " +
                        "WHERE CourseId = @CourseId ";
            try
            {
                CreateCommand(connectionString, query, course, RecordAction.update);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        private static void CreateCommand(string connectionString, string queryString, Course course, RecordAction action)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                var command = new SqlCommand(queryString, connection);

                if (action == RecordAction.update)
                {
                    command.Parameters.Add("@CourseId", SqlDbType.Int).Value = course.CourseId;
                }

                command.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = course.CourseName;
                command.Parameters.Add("@CourseStartDate", SqlDbType.Date).Value = course.StartDate;
                command.Parameters.Add("@CourseEndDate", SqlDbType.Date).Value = course.EndDate;
                command.Parameters.Add("@MinimumGradeToPassTheCourse", SqlDbType.Int).Value = course.MinimumGradeToPassTheCourse;
                command.Parameters.Add("@MaximumTestCourseGrade", SqlDbType.Decimal).Value = course.MaximumTestCourseGrade;
                command.Parameters.Add("@CourseTypeId", SqlDbType.Int).Value = 1;// course.CourseType;
                command.Parameters.Add("@CostPrice", SqlDbType.Decimal).Value = course.CoursePrice ?? (object)DBNull.Value;
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
