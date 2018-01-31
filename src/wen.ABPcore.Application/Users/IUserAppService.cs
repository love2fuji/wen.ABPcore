using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using wen.ABPcore.Roles.Dto;
using wen.ABPcore.Users.Dto;

namespace wen.ABPcore.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
