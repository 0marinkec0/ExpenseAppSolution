using Expense.Application.Common.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Expense.Application.Expense.Commands
{
    public record DeleteByIdCommand(int id) : IRequest;

    public class DeleteByIdCommandHandler : IRequestHandler<DeleteByIdCommand>
    {
        private readonly IAppDbContext _appDbContext;

        public DeleteByIdCommandHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Unit> Handle(DeleteByIdCommand request, CancellationToken cancellationToken)
        {
            var expense = await _appDbContext.AppExpenses.FirstOrDefaultAsync(a => a.Id == request.id);
            _appDbContext.AppExpenses.Remove(expense);
            await _appDbContext.SaveChangesAsync();
           
            return Unit.Value;
        }
    }
}
