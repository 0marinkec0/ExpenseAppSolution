using Expense.Application.Common.Interface;
using Expense.Domain.Common;
using MediatR;

namespace Expense.Application.Auth.Expense.Commands
{
    public record AddExpenseCommand
        (string category,
        string description, 
        double amount,
        int userId, 
        string type, 
        DateTime time) : IRequest;

    public class AddExpenseCommandHandler : IRequestHandler<AddExpenseCommand>
    {
        private readonly IAppDbContext _dbContext;

        public AddExpenseCommandHandler(IAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(AddExpenseCommand request, CancellationToken cancellationToken)
        {
            var expense = new AppExpense
            {
                Amount = request.amount,
                Category = request.category,
                Date = request.time,
                UserId = request.userId,
                Type = request.type,
                Description = request.description
            };

            _dbContext.AppExpenses.Add(expense);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
