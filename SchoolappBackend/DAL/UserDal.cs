using SchoolappBackend.BLL.models;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;


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
        string connectionString = "Data Source=KOENI7;Initial Catalog=School1;Integrated Security=True";

        public List<User> GetUsers()
        {
            var userList = new List<User>();

            var query = "SELECT UserId, UserName, UserPassword, SecurityGroupId, ActiveFrom, Blocked, PersonId " +
                        "FROM InlogUser " +
                        "ORDER BY UserId ";

            var connection = new SqlConnection(connectionString);
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
                        SecurityGroupId = Convert.ToInt32(reader["SecurityGroupId"]),
                        ActiveFrom = Convert.ToDateTime(reader["ActiveFrom"]),
                        Blocked = Convert.ToBoolean(reader["Blocked"]),
                        PersonId = Convert.ToInt32(reader["PersonId"]),
                    };
                    userList.Add(user);
                }
            }
            reader.Close();
            return userList;
        }


        public User GetUserById(int userId)
        {
            var query = "SELECT UserId ,UserName ,SecurityGroupId , ActiveFrom , Blocked , PersonId " +
                        "FROM InlogUser " +
                        "WHERE UserId = @userId";

            try
            {
                var courseDal = new CourseDal();

                var connection = new SqlConnection(connectionString);
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
                            SecurityGroupId = Convert.ToInt32(reader["SecurityGroupId"]),
                            ActiveFrom = Convert.ToDateTime(reader["ActiveFrom"]),
                            Blocked = Convert.ToBoolean(reader["Blocked"]),
                            PersonId = Convert.ToInt32(reader["PersonId"]),
                        };
                        return user;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }


        public bool AddNewUser(User user)
        {
            try
            {
                var query = "INSERT into InlogUser " +
                            "(UserName, UserPassword, SecurityGroupId, ActiveFrom, Blocked, PersonId)" +
                            "VALUES (" +
                            "@UserName, @UserPassword, @SecurityGroupId, @ActiveFrom, @Blocked, @PersonId" +
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
                        "SecurityGroupId = @SecurityGroupId, " +
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
                var connection = new SqlConnection(connectionString);
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
                command.Parameters.Add("@SecurityGroupId", SqlDbType.Int).Value = user.SecurityGroupId;
                command.Parameters.Add("@ActiveFrom", SqlDbType.DateTime).Value = user.ActiveFrom;
                command.Parameters.Add("@Blocked", SqlDbType.Bit).Value = user.Blocked;
                command.Parameters.Add("@PersonId", SqlDbType.Int).Value = user.PersonId;

                command.Connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteUser(int userId)
        {
            var query = "DELETE FROM InlogUser WHERE UserId = @UserId";
            var connection = new SqlConnection(connectionString);

            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@UserId", SqlDbType.Int, 50).Value = userId;
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

        public User GetValidUser(string userName, string password)
        {

            var query = "SELECT UserId, SecurityGroupId, ActiveFrom, Blocked, PersonId " +
                        "FROM InlogUser " +
                        "WHERE UserName = @UserName " +
                        "and UserPassword = @UserPassword " +
                        "and Blocked = 0 " +
                        "and ActiveFrom < getdate() ";

            var connection = new SqlConnection(connectionString);
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
                        SecurityGroupId = Convert.ToInt32(reader["SecurityGroupId"]),
                        PersonId = Convert.ToInt32(reader["PersonId"]),
                    };
                    return user;
                }
            }

            return null;
        }


    }
}
