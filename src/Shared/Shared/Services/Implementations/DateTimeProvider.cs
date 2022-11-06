using HelpFullUi.Shared.Services.Contracts;

namespace HelpFullUi.Shared.Services.Implementations;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTimeOffset GetCurrentDateTime()
    {
        return DateTimeOffset.UtcNow;
    }
}
