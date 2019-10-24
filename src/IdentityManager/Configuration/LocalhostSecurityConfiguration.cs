using IdentityManager.Configuration.Hosting;
using IdentityManager.Core;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityManager.Configuration
{
    public class LocalhostSecurityConfiguration : SecurityConfiguration
    {
        public LocalhostSecurityConfiguration()
        {
            HostAuthenticationType = Constants.LocalAuthenticationType;
            HostChallengeType = Constants.LocalAuthenticationType;
        }

        public override void Configure(IServiceCollection services)
        {
            services.AddAuthentication()
                .AddScheme<LocalhostAuthenticationOptions, LocalhostAuthenticationHandler>(
                    HostAuthenticationType, opt => { });

            base.Configure(services);
        }
    }
}