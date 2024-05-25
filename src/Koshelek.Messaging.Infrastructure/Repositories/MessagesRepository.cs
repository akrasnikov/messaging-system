using Koshelek.Messaging.Domain.Entities;
using Koshelek.Messaging.Domain.Interfaces.Repositories;
using System.Linq.Expressions;

namespace Koshelek.Messaging.Infrastructure.Repositories
{
    public class MessagesRepository : IMessagesRepository
    {
        public Task<bool> CreateAsync(Message message, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Message>> FindAsync(Expression<Func<DateTime, DateTime, bool>> predicat, int pageIndex, int pageSize, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Message>> FindAsync(Expression<Func<Message, bool>> predicate, int pageIndex, int pageSize, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Message>> GetAllAsync(int pageIndex, int pageSize, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
