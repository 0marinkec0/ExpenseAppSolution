﻿namespace Expense.Domain.Common
{
    public class AppExpense : BaseEntity
    {
        public string Description { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }

        public int UserId { get; set; }
        public AppUser User { get; set; }
    }
}
