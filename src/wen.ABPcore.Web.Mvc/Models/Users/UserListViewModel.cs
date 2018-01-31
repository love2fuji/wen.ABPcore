using System.Collections.Generic;
using wen.ABPcore.Roles.Dto;
using wen.ABPcore.Users.Dto;

namespace wen.ABPcore.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
