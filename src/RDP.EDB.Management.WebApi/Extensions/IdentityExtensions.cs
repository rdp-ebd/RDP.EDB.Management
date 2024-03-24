using Microsoft.AspNetCore.Identity;
using RDP.EDB.Management.Application.Identification;
using RDP.EDB.Management.Infra.Contexts;

namespace RDP.EDB.Management.WebApi.Extensions;

public static class IdentityExtensions
{
    public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services)
    {
        services.AddIdentity<EbdUser, IdentityRole<string>>(options =>
        {
            options.User.RequireUniqueEmail = true;
            options.Password.RequiredLength = 6;
        })
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultTokenProviders();

        return services;
    }
}
