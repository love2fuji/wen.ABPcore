using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace wen.ABPcore.Controllers
{
    public abstract class ABPcoreControllerBase: AbpController
    {
        protected ABPcoreControllerBase()
        {
            LocalizationSourceName = ABPcoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
