﻿using HelpFullUi.Server.Api.Data;
using HelpFullUi.Server.Api.Services.Contracts;

namespace HelpFullUi.Server.Api.Controllers;

public partial class AppControllerBase : ControllerBase
{
    [AutoInject] protected AppSettings AppSettings = default!;

    [AutoInject] protected IMapper Mapper = default!;

    [AutoInject] protected AppDbContext DbContext = default!;

    [AutoInject] protected IStringLocalizer<AppStrings> Localizer = default!;

    [AutoInject] protected IUserInformationProvider UserInformationProvider = default!;
}
