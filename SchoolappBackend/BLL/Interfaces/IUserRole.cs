using SchoolappBackend.BLL.models;
using System.Collections.Generic;


namespace SchoolappBackend.BLL.Interfaces
{
    internal interface IUserRole
    {
        List<UserRole> GetUserRoles();

        bool Add(UserRole userRole);

        bool Update(UserRole userRole);
        bool Delete(int userRoleId);
        UserRole GetUserRole(int userRoleId);

        // an user can have more than 1 role, example user adim has the roles admin, Manager, Developer, + .....
    }
}
