using Expense.Application.Common.Interface;
using Expense.Application.Common.Models;
using Expense.Domain.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Expense.Application.Expense.Queries
{
    public record GetAllExpensesQuery(int id) : IRequest<List<ExpenseModel>>;

    public class GetAllExpensesQuryHandler : IRequestHandler<GetAllExpensesQuery, List<ExpenseModel>>
    { 
        private readonly IAppDbContext _appDbContext;

        public GetAllExpensesQuryHandler(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<ExpenseModel>> Handle(GetAllExpensesQuery request, CancellationToken cancellationToken)
        {
            var query = await _appDbContext.AppExpenses.Where(i => i.UserId == request.id)
                .Select(n => new ExpenseModel
                {
                    Id = n.Id,
                    Amount = n.Amount,
                    Category = n.Category,
                    Description = n.Description,
                    Type = n.Type,
                    DateTime = n.Date
                }).ToListAsync();

            return query;
        }
    }
}
