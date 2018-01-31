using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace wen.ABPcore.Web.Views
{
    public abstract class ABPcoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ABPcoreRazorPage()
        {
            LocalizationSourceName = ABPcoreConsts.LocalizationSourceName;
        }
    }
}
