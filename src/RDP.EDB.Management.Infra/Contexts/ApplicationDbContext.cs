using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RDP.EDB.Management.Application.Identification;
using RDP.EDB.Management.Infra.Configurations.Entities;

namespace RDP.EDB.Management.Infra.Contexts;

public class ApplicationDbContext : IdentityDbContext<EbdUser>
{
    private readonly string _IdentitySchema = "auth";

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRoleClaim<string>>().ToTable("AspNetRoleClaims", _IdentitySchema);
        builder.Entity<IdentityRole>().ToTable("AspNetRoles", _IdentitySchema);
        builder.Entity<IdentityUserClaim<string>>().ToTable("AspNetUserClaims", _IdentitySchema);
        builder.Entity<IdentityUserLogin<string>>().ToTable("AspNetUserLogins", _IdentitySchema);
        builder.Entity<IdentityUserRole<string>>().ToTable("AspNetUserRoles", _IdentitySchema);
        builder.Entity<IdentityUserToken<string>>().ToTable("AspNetUserTokens", _IdentitySchema);
        builder.Entity<EbdUser>().ToTable("AspNetUsers", _IdentitySchema);

        builder.ApplyConfiguration(new PersonConfiguration());
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
    }
}
