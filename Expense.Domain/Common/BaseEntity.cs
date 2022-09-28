
namespace Expense.Domain.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? Modified { get; set; }
    }
}
