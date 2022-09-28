using Expense.Application.Common.Interface;
using Expense.Application.Common.Models;
using MediatR;

namespace Expense.Application.Auth.Login
{
    public record LoginCommand(string email, string password) : IRequest<LoginResult>;

    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResult>
    {
        private readonly IIdentityService _identityService;
        private readonly IAppDbContext _appDbContext;

        public LoginCommandHandler(IIdentityService identityService, IAppDbContext appDbContext)
        {
            _identityService = identityService;
            _appDbContext = appDbContext;
        }

        public async Task<LoginResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return await _identityService.Login(request.email, request.password);
        }
    }
}
