using Pulumi;
using Pulumi.NameFormatter;

/// <summary>
/// PascalCase-friendly args wrapper — use instead of ModuleArgs directly.
/// </summary>
public sealed class NameFormatterArgs
{
    public Input<string> FirstName { get; set; } = null!;
    public Input<string> LastName  { get; set; } = null!;

    internal ModuleArgs ToModuleArgs() => new ModuleArgs
    {
        First_name = FirstName,
        Last_name  = LastName,
    };
}

/// <summary>
/// Thin subclass of the generated Module exposing PascalCase output properties.
/// </summary>
public sealed class NameFormatterModule : Module
{
    public Output<object?> WholeName => Whole_name;

    public NameFormatterModule(string name, NameFormatterArgs args, CustomResourceOptions? options = null)
        : base(name, args.ToModuleArgs(), options)
    {
    }
}
