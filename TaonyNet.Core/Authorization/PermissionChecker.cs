using Abp.Authorization;
using TaonyNet.Authorization.Roles;
using TaonyNet.MultiTenancy;
using TaonyNet.Users;

namespace TaonyNet.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
