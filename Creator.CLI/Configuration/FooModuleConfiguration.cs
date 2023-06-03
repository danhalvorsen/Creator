
using Microsoft.Extensions.Options;
public interface IModule2
{ }
public class FooModule : IModule2
{
    public Foo2ModuleConfiguration config { get; set; }

    public FooModule(IOptions<Foo2ModuleConfiguration> config)
    {
        this.config = config.Value;
    }
}
#region configuration
//https://learn.microsoft.com/en-us/dotnet/core/extensions/options-library-authors

public class Foo2ModuleConfiguration
{
    public string? Foo { get; set; }
    public string? Bar { get; set; }
}

public class ModuleConfigurationOption
{
    public const string Module = nameof(Foo2ModuleConfiguration);
}
#endregion