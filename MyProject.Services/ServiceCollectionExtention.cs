using Microsoft.Extensions.DependencyInjection;
using MyProject.Services.Interfaces;
using MyProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services
{
    public static class ServiceCollectionExtention
    {
        public static IServiceCollection addServices(this IServiceCollection services)
        {
            services.AddScoped<IRoleService,RoleService>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IClaimService, ClaimService>();
            return services;
        }
    }
}
