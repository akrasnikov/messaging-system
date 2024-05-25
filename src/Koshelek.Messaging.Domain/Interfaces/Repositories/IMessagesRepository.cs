using Koshelek.Messaging.Domain.Entities;
using System.Linq.Expressions;

namespace Koshelek.Messaging.Domain.Interfaces.Repositories
{
    public interface IMessagesRepository
    {
        public Task<bool> CreateAsync(Message message, CancellationToken cancellationToken = default);
        public Task<IReadOnlyList<Message>> GetAllAsync(
            int pageIndex, 
            int pageSize,
            CancellationToken cancellationToken = default);

        public Task<IReadOnlyList<Message>> FindAsync(
            Expression<Func<DateTime, DateTime, bool>> predicat,
            int pageIndex, 
            int pageSize, 
            CancellationToken cancellationToken = default);

        public Task<IReadOnlyList<Message>> FindAsync(
            Expression<Func<Message, bool>> predicate,
            int pageIndex, 
            int pageSize,
            CancellationToken cancellationToken = default);
    }
}
