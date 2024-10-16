using SchoolappBackend.BLL.models;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.Interfaces
{
    internal interface IUserRole
    {
        List<UserRole> GetUserRoles();

        bool AddUserRole(UserRole userRole);

        bool UpdateUserRole(UserRole userRole);
        bool DeleteUserRole(int userRoleId);
        UserRole GetUserRole(int userRoleId);

        // an user can have more than 1 role, example user adim has the roles admin, Manager, Developer, + .....
    }
}
