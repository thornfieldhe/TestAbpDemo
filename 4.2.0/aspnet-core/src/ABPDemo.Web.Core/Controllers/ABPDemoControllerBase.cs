using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPDemo.Controllers
{
    public abstract class ABPDemoControllerBase: AbpController
    {
        protected ABPDemoControllerBase()
        {
            LocalizationSourceName = ABPDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
