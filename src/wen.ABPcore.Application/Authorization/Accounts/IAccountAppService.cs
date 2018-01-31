using System.Threading.Tasks;
using Abp.Application.Services;
using wen.ABPcore.Authorization.Accounts.Dto;

namespace wen.ABPcore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
