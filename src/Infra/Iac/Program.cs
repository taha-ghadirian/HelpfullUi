using Pulumi;
using HelpFullUi.Iac;

public class Program
{
    static Task<int> Main() => Deployment.RunAsync<TdStack>();
}
