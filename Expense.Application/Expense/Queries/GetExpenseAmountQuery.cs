using Expense.Application.Common.Interface;
using MediatR;

namespace Expense.Application.Expense.Queries
{
    public record GetExpenseAmountQuery : IRequest<double>;

    public class GetExpenseAmountQueryHandler : IRequestHandler<GetExpenseAmountQuery, double>
    {
        private readonly IAppDbContext _appDbContext;

        public GetExpenseAmountQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<double> Handle(GetExpenseAmountQuery request, CancellationToken cancellationToken)
        {
            var sum = _appDbContext.AppExpenses.Select(x => x.Amount).Sum();

            return sum;
        }
    }
}
