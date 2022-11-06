using HelpFullUi.Server.Api.Models.Account;
using HelpFullUi.Shared.Dtos.Account;

namespace HelpFullUi.Server.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
