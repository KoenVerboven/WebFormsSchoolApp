using SchoolappBackend.BLL.models;
using System;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.Interfaces
{
    internal interface IUserBLL
    {
        List<User> GetUsers(string searchField, string orderBy);

        bool Add(User user);

        bool Update(User user);

        bool Delete(int userId);

        User GetUserById(int userId);

        User GetUserByUserNameAndPassword(String userName, String passWord);
    }
}
