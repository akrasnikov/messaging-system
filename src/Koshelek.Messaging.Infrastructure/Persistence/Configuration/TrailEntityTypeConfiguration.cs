using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Koshelek.Messaging.Infrastructure.Auditing;

namespace Koshelek.Messaging.Infrastructure.Persistence.Configuration;

public class TrailEntityTypeConfiguration : IEntityTypeConfiguration<Trail>
{
    public void Configure(EntityTypeBuilder<Trail> builder) =>
        builder
            .ToTable("audit_trails", "Auditing");
}