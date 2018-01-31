using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using wen.ABPcore.Configuration.Dto;

namespace wen.ABPcore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPcoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
