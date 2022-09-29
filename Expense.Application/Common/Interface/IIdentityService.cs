using Expense.Application.Common.Models;
using System.Reflection.Metadata;

namespace Expense.Application.Common.Interface
{
    public interface IIdentityService
    {
         Task<RegisterResult> Register(string email, string password, string firstName, string lastName);
         Task<LoginResult> Login(string email, string password);
    }
}
