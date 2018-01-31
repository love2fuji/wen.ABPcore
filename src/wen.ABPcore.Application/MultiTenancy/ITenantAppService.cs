using Abp.Application.Services;
using Abp.Application.Services.Dto;
using wen.ABPcore.MultiTenancy.Dto;

namespace wen.ABPcore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
