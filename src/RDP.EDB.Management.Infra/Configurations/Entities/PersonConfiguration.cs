using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RDP.EDB.Management.Domain.Entities;

namespace RDP.EDB.Management.Infra.Configurations.Entities;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(x => x.Id);
        builder.ToTable("People", "mgt");
    }
}
