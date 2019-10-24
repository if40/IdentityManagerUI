using System;
using System.Threading.Tasks;
using IdentityManager.Assets;
using IdentityManager.Configuration;
using IdentityManager.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Api.Controllers
{
    [SecurityHeaders]
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public class PageController : Controller
    {
        private readonly IdentityManagerOptions config;
        public PageController(IdentityManagerOptions config)
        {
            this.config = config ?? throw new ArgumentNullException(nameof(config));
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("", Name = Constants.RouteNames.Home)]
        public IActionResult Index()
        {
            return new EmbeddedHtmlResult(
                Request.PathBase, 
                "IdentityManager.Assets.Templates.index.html",
                config.SecurityConfiguration);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("logout", Name = Constants.RouteNames.Logout)]
        public async Task<IActionResult> Logout()
        {
            await config.SecurityConfiguration.SignOut(HttpContext);
            return RedirectToRoute(Constants.RouteNames.Home, null);
        }
    }
}