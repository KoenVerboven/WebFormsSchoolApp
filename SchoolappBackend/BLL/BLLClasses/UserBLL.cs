using SchoolappBackend.BLL.Interfaces;
using SchoolappBackend.BLL.models;
using SchoolappBackend.DAL;
using System;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.BLLClasses
{
    public class UserBLL : IUserBLL
    {
        UserDal userDal = new UserDal();

        public UserBLL()
        {
        }

        public bool Add(User user)
        {
            return userDal.AddNewUser(user);
        }

        public bool Delete(int userId)
        {
            throw new System.NotImplementedException();
        }

        public User GetUserById(int userId)
        {
            return userDal.GetUserById(userId);
        }

        public int UserCount()
        {
            return (int)userDal.GetUserCount();
        }


        public User GetUserByUserNameAndPassword(string userName)
        {
            User user = null;
            if (userName != string.Empty)
            {
                return userDal.GetValidUser(userName);
            }
            return user;
        }

        public List<User> GetUsers(string searchField, string orderBy, string sortDirection)
        {
            return userDal.GetUsers(searchField,orderBy, sortDirection);
        }

        public bool Update(User user)
        {
            return userDal.UpdateUser(user);
        }


        public bool UpdatePassword(string newPassword,string userName)
        {
            return userDal.UpdatePassword(newPassword, userName);
        }


        [Obsolete]

        List<User> users;
        private void FillUserList()
        {
            users = new List<User>()
            {
                new User()
                {
                    UserId=0,
                    UserName="admin",
                    Password="admin@School4",
                    UserRoleId=0,
                    ActiveFrom = new System.DateTime(2024,09,01),
                    Blocked = false,
                    PersonId=0,
                },
                new User()
                {
                    UserId=0,
                    UserName="koen",
                    Password="koen@Home",
                    UserRoleId=0,
                    ActiveFrom = new System.DateTime(2024,09,01),
                    Blocked = false,
                    PersonId=0,
                },
                new User()
                {
                    UserId=0,
                    UserName="Maria",
                    Password="Maria@Vosselaar3",
                    UserRoleId=0,
                    ActiveFrom = new System.DateTime(2024,09,01),
                    Blocked = false,
                    PersonId=0,
                },

            };
        }



    }
}
