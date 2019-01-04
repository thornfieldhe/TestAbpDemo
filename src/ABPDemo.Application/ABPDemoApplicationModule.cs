using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPDemo.Authorization;

namespace ABPDemo
{
    [DependsOn(
        typeof(ABPDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
