using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPDemo.Configuration;

namespace ABPDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPDemoWebCoreModule))]
    public class ABPDemoWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPDemoWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPDemoWebHostModule).GetAssembly());
        }
    }
}
