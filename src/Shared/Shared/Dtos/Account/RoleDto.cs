using HelpFullUi.Shared.Attributes;
using HelpFullUi.Shared.Resources;

namespace HelpFullUi.Shared.Dtos.Account;

[DtoResourceType(typeof(AppStrings))]
public class RoleDto
{
    public int Id { get; set; }

    public string? Name { get; set; }
}
