namespace Expense.Application.Common.Models
{
    public class ExpenseModel
    {
        public string Description { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
    }
}
