namespace Koshelek.Messaging.Infrastructure.Persistence.Configuration;

using Koshelek.Messaging.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class MessageEntityTypeConfiguration : IEntityTypeConfiguration<Message>
{
    public void Configure(EntityTypeBuilder<Message> builder)
    {

        builder.ToTable("messages", nameof(Message));

    }
}
