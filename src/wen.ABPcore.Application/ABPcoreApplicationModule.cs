using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using wen.ABPcore.Authorization;

namespace wen.ABPcore
{
    [DependsOn(
        typeof(ABPcoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPcoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPcoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPcoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
