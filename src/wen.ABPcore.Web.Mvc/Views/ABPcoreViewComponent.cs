using Abp.AspNetCore.Mvc.ViewComponents;

namespace wen.ABPcore.Web.Views
{
    public abstract class ABPcoreViewComponent : AbpViewComponent
    {
        protected ABPcoreViewComponent()
        {
            LocalizationSourceName = ABPcoreConsts.LocalizationSourceName;
        }
    }
}
