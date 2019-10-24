using System;
using Microsoft.Extensions.DependencyInjection;

namespace IdentityManager.Configuration
{
    public class IdentityManagerBuilder : IIdentityManagerBuilder
    {
        public IdentityManagerBuilder(IServiceCollection services)
        {
            Services = services ?? throw new ArgumentNullException(nameof(services));
        }

        public IServiceCollection Services { get; }
    }
}