﻿using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Elvet.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Elvet.Plugins.RequestRole
{
    public class RequestRolePlugin : IModBotPlugin
    {
        [SuppressMessage("Usage", "CA1801:Review unused parameters", Justification = "Standard for all plugins to use the same parameters.")]
        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Standard for all plugins to use the same parameters.")]
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            services.AddSingleton<RequestRolePlugin>();
            services.AddSingleton<RequestRoleModule>();

            services.AddScoped<RequestRoleService>();
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
        }
    }
}