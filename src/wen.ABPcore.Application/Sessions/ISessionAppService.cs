using System.Threading.Tasks;
using Abp.Application.Services;
using wen.ABPcore.Sessions.Dto;

namespace wen.ABPcore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
