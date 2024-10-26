using SchoolappBackend.BLL.Interfaces;
using SchoolappBackend.BLL.models;
using SchoolappBackend.DAL;
using System;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.BLLClasses
{
    public class UserBLL : IUserBLL
    {
        List<User> users;

        public UserBLL()
        {
        }

        public bool Add(User user)
        {
            UserDal userDal = new UserDal();
            return userDal.AddNewUser(user);
        }

        public bool Delete(int userId)
        {
            throw new System.NotImplementedException();
        }

        public User GetUserById(int userId)
        {
            UserDal userDal=new UserDal();
            return userDal.GetUserById(userId);
        }

        public int UserCount()
        {
            UserDal userDal = new UserDal();
            return (int)userDal.GetUserCount();
        }


        public User GetUserByUserNameAndPassword(string userName, string passWord)
        {
            User user = null;
            if (userName != string.Empty)
            {
                var userDal = new UserDal();
                return userDal.GetValidUser(userName, passWord);
            }
            return user;
        }

        public List<User> GetUsers(string searchField, string orderBy)
        {
            UserDal userDal = new UserDal();
            return userDal.GetUsers(searchField,orderBy);
        }

        public bool Update(User user)
        {
            UserDal userDal = new UserDal();
            return userDal.UpdateUser(user);
        }

        [Obsolete]
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
