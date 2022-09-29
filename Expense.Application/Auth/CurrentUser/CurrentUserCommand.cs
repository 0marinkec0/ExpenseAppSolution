

using Expense.Application.Common.Interface;
using MediatR;
using System.Runtime.CompilerServices;

namespace Expense.Application.Auth.CurrentUser
{
    public record CurrentUserCommand : IRequest<int>;

    //public class CurrentUserCommandHandler : IRequestHandler<CurrentUserCommand, int>
    //{
    //    private readonly IIdentityService _identityService;

    //    public CurrentUserCommandHandler(IIdentityService identityService)
    //    {
    //        _identityService = identityService;
    //    }

        //public Task<int> Handle(CurrentUserCommand request, CancellationToken cancellationToken)
        //{
        //    _identityService.ge
        //}
    //}
}
