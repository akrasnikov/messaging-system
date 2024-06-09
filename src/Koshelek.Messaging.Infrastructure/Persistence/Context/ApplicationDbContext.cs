using Koshelek.Messaging.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;

namespace Koshelek.Messaging.Infrastructure.Persistence.Context
{
    public sealed class ApplicationDbContext : BaseDbContext
    {

        private readonly ILoggerFactory _logger;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ILoggerFactory logger) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

         
        public DbSet<Message> Messages => Set<Message>(); 
        
    }
}
