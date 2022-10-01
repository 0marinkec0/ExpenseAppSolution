using Expense.Application.Common.Interface;
using MediatR;

namespace Expense.Application.Expense.Queries
{
    public record GetIncomeAmountQuery : IRequest<double>;

    public class GetIncomeAmountQueryHandler : IRequestHandler<GetIncomeAmountQuery, double>
    {
        private readonly IAppDbContext _appDbContext;

        public GetIncomeAmountQueryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<double> Handle(GetIncomeAmountQuery request, CancellationToken cancellationToken)
        {
            var sum = _appDbContext.AppExpenses
                .Where(t => t.Type == "Income")
                .Select(x => x.Amount)
                .Sum();

            return sum;
        }
    }
}
