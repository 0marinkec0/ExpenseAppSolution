using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Expense.Application.Common.Models
{
    public class RegisterResult
    {
        public bool Success { get; set; }
        public string Error { get; set; }

        public RegisterResult(bool success, string error)
        {
            Success = success;
            Error = error;
        }

        public static RegisterResult Successfull()
        {
            return new RegisterResult(true, string.Empty);
        }

        public static RegisterResult Failure(string error)
        {
            return new RegisterResult(false, error);
        }
    }
}
