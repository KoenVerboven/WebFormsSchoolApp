using System;


namespace SchoolappBackend.BLL.models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserRoleId { get; set; }
        public DateTime? ActiveFrom { get; set; }
        public bool Blocked { get; set; }
        public int PersonId { get; set; }
    }
}
