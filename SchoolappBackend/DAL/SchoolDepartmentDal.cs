using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        public List<SchoolClass> GetSchoolClasses(string filter, string orderby, string sortDirection) {
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
                query += "ORDER BY " + orderby + " " + sortDirection;
            }
            else
            {
                query += "ORDER BY SchoolClassId desc";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
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
        }


        public SchoolClass GetSchoolClassById(int schoolClassId)
        {
            var query = "SELECT SchoolClassId, Code, ClassDescription, Degree," +
                               "Grade, SchoolDepartmentId " +
                        "FROM SchoolClass " +
                        "WHERE SchoolClassId = @SchoolClassId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@SchoolClassId", SqlDbType.Int, 50).Value = schoolClassId;
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
                        reader.Close();
                        return schoolClass;
                    }
                }
            }
            return null;
        }




        public int GetSchoolClassCount()
        {
            var query = "SELECT count(*) FROM SchoolClass";

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



    }
}
