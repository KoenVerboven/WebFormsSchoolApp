using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.Interfaces
{
    internal interface IUserBLL
    {
        List<User> GetUsers();

        bool AddUser(User user);

        bool UpdateUser(User user);

        bool DeleteUser(int userId);

        User GetUserById(int userId);

        User GetUserByUserNameAndPassword(String userName, String passWord);
    }
}
