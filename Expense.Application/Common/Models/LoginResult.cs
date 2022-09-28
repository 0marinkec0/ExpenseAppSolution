namespace Expense.Application.Common.Models
{
    public class LoginResult
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public int Id { get; set; }

        public LoginResult(bool success, string error, int id)
        {
            Success = success;
            Error = error;
            Id = id;
        }

        public static LoginResult Successfull(int id)
        {
            return new LoginResult(true, string.Empty, id);
        }

        public static LoginResult Failure(string error)
        {
            return new LoginResult(false, error, 0);
        }
    }
}
