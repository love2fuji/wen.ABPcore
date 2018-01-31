using System.Collections.Generic;
using wen.ABPcore.Roles.Dto;

namespace wen.ABPcore.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
