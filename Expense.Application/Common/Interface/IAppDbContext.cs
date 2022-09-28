using Expense.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Expense.Application.Common.Interface
{
    public interface IAppDbContext
    {
         DbSet<AppUser> AppUsers { get;}
         DbSet<AppExpense> AppExpenses { get;}
         Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
