using System.Collections.Generic;
using Pulumi;

// Generated SDK namespace produced by:
//   pulumi package add terraform-module \
//     app.terraform.io/BS_INC/stringformatter/bps//modules/name-formatter \
//     2026.512.2 \
//     string-formatter
//
// Pulumi derives the C# namespace from the package name ("string-formatter" → "StringFormatter").
// Run the command above before building; it will generate the SDK under sdks/string-formatter/
// and add a ProjectReference to this .csproj automatically.
using Pulumi.NameFormatter;

return await Deployment.RunAsync(() =>
{
    // Instantiate the Terraform module as a first-class Pulumi resource.
    // The strongly-typed Args class is generated from the module's variable declarations:
    //   first_name  string  The person's first name
    //   last_name   string  The person's last name
    var nameFormatter = new Module("string-formatter", new ModuleArgs
    {
        First_name = "Jane",
        Last_name  = "Doe",
    });

    return new Dictionary<string, object?>
    {
        ["wholeName"] = nameFormatter.Whole_name,
    };
});
