using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace SchoolappBackend.DAL
{
    internal class SchoolDepartmentDal
    {   //select from schoolgroup -> tabel moet nog toegevoegd worden
        //select * from school
        //select * from schooldepartment
        //select * from schoolclass
        //select * from schoolclassdepartment ->> deze tabel moet nog toegevoegd worden

        readonly string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        public List<SchoolClass> GetSchoolClasses(string filter, string orderby) {
            var classesList = new List<SchoolClass>();

            var query = "SELECT SchoolClassId, Code, ClassDescription, Degree," +
                               "Grade, SchoolDepartmentId " +  
                        "FROM SchoolClass ";

            if (filter.Trim() != string.Empty)
            {
                query += "WHERE Code like '%" + filter + "%' ";
                query += "OR ClassDescription like '%" + filter + "%' ";
            }
            if (orderby.Trim() != string.Empty)
            {
                query += "ORDER BY " + orderby;
            }
            else
            {
                query += "ORDER BY SchoolClassId";
            }

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var schoolClass = new SchoolClass()
                    {
                        ClassId = Convert.ToInt32(reader["SchoolClassId"]),
                        ClassCode = Convert.ToString(reader["Code"]),
                        Description = Convert.ToString(reader["ClassDescription"]),
                        Degree = Convert.ToInt32(reader["Degree"]),
                        Grade = Convert.ToInt32(reader["Grade"]),
                        SchoolDepartmentId = Convert.ToInt32(reader["SchoolDepartmentId"]),
                    };
                    classesList.Add(schoolClass);
                }
            }
            reader.Close();
            return classesList;
        }


        public int GetSchoolClassCount()
        {
            var query = "SELECT count(*) FROM SchoolClass";

            try
            {
                var connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
