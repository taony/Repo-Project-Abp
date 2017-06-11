using System.Threading.Tasks;
using Abp.Application.Services;
using TaonyNet.Roles.Dto;

namespace TaonyNet.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
