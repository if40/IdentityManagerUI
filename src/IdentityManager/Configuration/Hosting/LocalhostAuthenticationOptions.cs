using Microsoft.AspNetCore.Authentication;

namespace IdentityManager.Configuration.Hosting
{
    internal class LocalhostAuthenticationOptions : AuthenticationSchemeOptions
    {
        public SecurityConfiguration Configuration { get; set; } 
            = new LocalhostSecurityConfiguration();
    }
}