using Abp.Authorization;
using wen.ABPcore.Authorization.Roles;
using wen.ABPcore.Authorization.Users;

namespace wen.ABPcore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
