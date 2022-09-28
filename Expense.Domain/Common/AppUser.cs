namespace Expense.Domain.Common
{
    public class AppUser : BaseEntity
    {
        public AppUser()
        {
            Expenses = new List<AppExpense>();
        }

        public string FirstName { get; set; }
        public List<AppExpense> Expenses { get; private set; }

    }
}
