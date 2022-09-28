using Expense.Application.Common.Interface;
using Expense.Application.Common.Models;
using Expense.Domain.Common;
using MediatR;

namespace Expense.Application.Auth.Register
{
    public record RegisterCommand(
        string email, 
        string firstName,
        string lastName,
        string password
        ) : IRequest<RegisterResult>;

    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, RegisterResult>
    {
        private readonly IIdentityService _identityService;
        private readonly IAppDbContext _appDbContext;

        public RegisterCommandHandler(IIdentityService identityService, IAppDbContext appDbContext)
        {
            _identityService = identityService;
            _appDbContext = appDbContext;
        }

        public async Task<RegisterResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var registerResult = await _identityService.Register(request.email, request.password, request.firstName, request.lastName);

            if (registerResult.Success)
            {

                var user = new AppUser()
                {
                    FirstName = request.firstName,
                    DateCreated = DateTime.Now
                };
                _appDbContext.AppUsers.Add(user);
                await _appDbContext.SaveChangesAsync();
            }

            return registerResult;
        }
    }
}
