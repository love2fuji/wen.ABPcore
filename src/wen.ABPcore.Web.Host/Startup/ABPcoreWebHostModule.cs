using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using wen.ABPcore.Configuration;

namespace wen.ABPcore.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPcoreWebCoreModule))]
    public class ABPcoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPcoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPcoreWebHostModule).GetAssembly());
        }
    }
}
