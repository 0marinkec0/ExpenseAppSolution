using Expense.Application.Common.Interface;
using Expense.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace Expense.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public IdentityService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

       public async Task<RegisterResult> Register(string email, string password, string firstName, string lastName)
        {
            if (await _userManager.FindByEmailAsync(email) != null)
                return RegisterResult.Failure("User with email already exists");

            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                UserName = email
            };

            var registerResult = await _userManager.CreateAsync(user, password);

            if (!registerResult.Succeeded)
                throw new Exception("Register is not successfull!");

            return RegisterResult.Successfull();
        }

        public async Task<LoginResult> Login(string email, string password)
        { 
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null || await _userManager.CheckPasswordAsync(user, password) == false)
                return LoginResult.Failure($"User with email {email} does not exist or password is wrong");

            return LoginResult.Successfull(user.Id);
        }
    }
}
