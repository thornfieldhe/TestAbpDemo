using Microsoft.AspNetCore.Antiforgery;
using ABPDemo.Controllers;

namespace ABPDemo.Web.Host.Controllers
{
    public class AntiForgeryController : ABPDemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
