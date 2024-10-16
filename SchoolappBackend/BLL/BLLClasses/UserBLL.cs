using SchoolappBackend.BLL.Interfaces;
using SchoolappBackend.BLL.models;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.BLLClasses
{
    internal class UserBLL : IUserBLL
    {
        List<User> users;

        public UserBLL()
        {
                FillUserList();
        }

        public bool AddUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteUser(int userId)
        {
            throw new System.NotImplementedException();
        }

        public User GetUserById(int userId)
        {
            throw new System.NotImplementedException();
        }

        public User GetUserByUserNameAndPassword(string userName, string passWord)
        {
            User user = null;
            if (userName != string.Empty)
            {
                //var userDal = new UserDal();
                //return userDal.GetValidUser(userName, passWord);
                return user;
            }
            return user;
        }

        public List<User> GetUsers()
        {
            throw new System.NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        private void FillUserList()
        {
            users = new List<User>()
            {
                new User()
                {
                    UserId=0,
                    UserName="admin",
                    Password="admin@School4",
                    SecurityGroupId=0,
                    ActiveFrom = new System.DateTime(2024,09,01),
                    Blocked = false,
                    PersonId=0,
                },
                new User()
                {
                    UserId=0,
                    UserName="koen",
                    Password="koen@Home",
                    SecurityGroupId=0,
                    ActiveFrom = new System.DateTime(2024,09,01),
                    Blocked = false,
                    PersonId=0,
                },
                new User()
                {
                    UserId=0,
                    UserName="Maria",
                    Password="Maria@Vosselaar3",
                    SecurityGroupId=0,
                    ActiveFrom = new System.DateTime(2024,09,01),
                    Blocked = false,
                    PersonId=0,
                },

            };
        }



    }
}
