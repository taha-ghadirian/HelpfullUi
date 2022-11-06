using HelpFullUi.Shared.Attributes;
using HelpFullUi.Shared.Resources;

namespace HelpFullUi.Shared.Dtos.Account;

[DtoResourceType(typeof(AppStrings))]
public class SignInResponseDto
{
    public string? AccessToken { get; set; }

    public long ExpiresIn { get; set; }
}
