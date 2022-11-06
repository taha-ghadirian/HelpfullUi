using HelpFullUi.Shared.Dtos.Account;

namespace HelpFullUi.Client.Shared.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
