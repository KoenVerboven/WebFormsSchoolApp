using SchoolappBackend.BLL.models;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace SchoolappBackend.DAL
{

    public enum RecordAction
    {
        insert,
        update,
        delete,
    }

    internal class UserDal
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;

        public List<User> GetUsers(string filter, string orderby)
        {
            var userList = new List<User>();

            var query = "SELECT UserId, UserName, UserPassword, UserRoleId, ActiveFrom, Blocked, PersonId " +
                        "FROM InlogUser ";
            if (filter.Trim() != string.Empty)
            {
                query += "WHERE UserName like '%" + filter + "%' ";
            }
            if(orderby.Trim() != string.Empty)
            {
                query += "ORDER BY " + orderby;
            }
            else
            {
                query += "ORDER BY UserId";
            }

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var user = new User()
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            UserName = Convert.ToString(reader["UserName"]),
                            UserRoleId = Convert.ToInt32(reader["UserRoleId"]),
                            ActiveFrom = Convert.ToDateTime(reader["ActiveFrom"]),
                            Blocked = Convert.ToBoolean(reader["Blocked"]),
                            PersonId = Convert.ToInt32(reader["PersonId"]),
                        };
                        userList.Add(user);
                    }
                }
                return userList;
            }

        }


        public User GetUserById(int userId)
        {
            var query = "SELECT UserId ,UserName ,UserRoleId , ActiveFrom , Blocked , PersonId " +
                        "FROM InlogUser " +
                        "WHERE UserId = @userId";

            try
            {
                var courseDal = new CourseDal();

                using (var connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@userId", SqlDbType.Int, 50).Value = userId;
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var user = new User()
                            {
                                UserId = Convert.ToInt32(reader["UserId"]),
                                UserName = Convert.ToString(reader["UserName"]),
                                UserRoleId = Convert.ToInt32(reader["UserRoleId"]),
                                ActiveFrom = Convert.ToDateTime(reader["ActiveFrom"]),
                                Blocked = Convert.ToBoolean(reader["Blocked"]),
                                PersonId = Convert.ToInt32(reader["PersonId"]),
                            };
                            return user;
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


        public int GetUserCount()
        {
            var query = "SELECT count(*) FROM InlogUser";

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

        public bool AddNewUser(User user)
        {
            try
            {
                var query = "INSERT into InlogUser " +
                            "(UserName, UserPassword, UserRoleId, ActiveFrom, Blocked, PersonId)" +
                            "VALUES (" +
                            "@UserName, @UserPassword, @UserRoleId, @ActiveFrom, @Blocked, @PersonId" +
                            ")";

                CreateCommand(connectionString, query, user, RecordAction.insert);

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }


        public bool UpdateUser(User user)
        {
            var query = "UPDATE InlogUser " +
                        "SET " +
                        "UserName = @UserName, " +
                        "UserRoleId = @UserRoleId, " +
                        "ActiveFrom = @ActiveFrom, " +
                        "Blocked = @Blocked, " +
                        "PersonId = @PersonId " +
                        "WHERE UserId = @UserId ";

            try
            {
                CreateCommand(connectionString, query, user, RecordAction.update);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        private static void CreateCommand(string connectionString, string queryString, User user, RecordAction action)
        {
            try
            {
                       
                using(var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(queryString, connection);

                    if (action == RecordAction.update)
                    {
                        command.Parameters.Add("@UserId", SqlDbType.Int).Value = user.UserId;
                    }

                    if (action == RecordAction.insert)
                    {
                        command.Parameters.Add("@UserPassword", SqlDbType.VarChar).Value = user.Password;
                    }

                    command.Parameters.Add("@UserName", SqlDbType.VarChar).Value = user.UserName;
                    command.Parameters.Add("@UserRoleId", SqlDbType.Int).Value = user.UserRoleId;
                    command.Parameters.Add("@ActiveFrom", SqlDbType.DateTime).Value = user.ActiveFrom;
                    command.Parameters.Add("@Blocked", SqlDbType.Bit).Value = user.Blocked;
                    command.Parameters.Add("@PersonId", SqlDbType.Int).Value = user.PersonId;

                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
               
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteUser(int userId)
        {
            var query = "DELETE FROM InlogUser WHERE UserId = @UserId";
            

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(query, connection);
                    command.Parameters.Add("@UserId", SqlDbType.Int, 50).Value = userId;
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public User GetValidUser(string userName, string password)
        {

            var query = "SELECT UserId, UserRoleId, ActiveFrom, Blocked, PersonId " +
                        "FROM InlogUser " +
                        "WHERE UserName = @UserName " +
                        "and UserPassword = @UserPassword " +
                        "and Blocked = 0 " +
                        "and ActiveFrom < getdate() ";

            //todo : try catch and label for show errormessage

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@UserName", SqlDbType.VarChar, 50).Value = userName;
                command.Parameters.Add("@UserPassword", SqlDbType.VarChar, 50).Value = password;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var user = new User()
                        {
                            UserRoleId = Convert.ToInt32(reader["UserRoleId"]),
                            PersonId = Convert.ToInt32(reader["PersonId"]),
                        };
                        return user;
                    }
                }
            }

            return null;
        }


    }
}
