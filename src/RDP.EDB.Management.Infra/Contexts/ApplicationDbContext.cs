using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RDP.EDB.Management.Application.Identification;

namespace RDP.EDB.Management.Infra.Contexts;

public class ApplicationDbContext : IdentityDbContext<EbdUser>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
}
