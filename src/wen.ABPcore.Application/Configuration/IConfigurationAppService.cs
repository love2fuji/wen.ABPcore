using System.Threading.Tasks;
using wen.ABPcore.Configuration.Dto;

namespace wen.ABPcore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
