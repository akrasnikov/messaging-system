using Koshelek.Messaging.Domain.Common.Interfaces;
using Koshelek.Messaging.Domain.Entities;
using Koshelek.Messaging.Infrastructure.Persistence.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Options;

namespace Koshelek.Messaging.Infrastructure.Persistence.Context
{
    public sealed class ApplicationDbContext : BaseDbContext
    {
        
        public ApplicationDbContext(
                    DbContextOptions<ApplicationDbContext> options,
                    ISerializerService serializer,
                    IOptions<DatabaseSettings> settings) 
            : base(options, serializer, settings)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

         
        public DbSet<Message> Messages => Set<Message>(); 
        
    }
}
