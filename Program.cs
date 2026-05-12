using System.Collections.Generic;
using Pulumi;

// Generated SDK namespace produced by:
//   pulumi package add terraform-module \
//     app.terraform.io/BS_INC/stringformatter/bps \
//     2026.512.2 \
//     string-formatter
//
// Pulumi derives the C# namespace from the package name ("string-formatter" → "StringFormatter").
// Run the command above before building; it will generate the SDK under sdks/string-formatter/
// and add a ProjectReference to this .csproj automatically.
using Pulumi.StringFormatter;

return await Deployment.RunAsync(() =>
{
    // Instantiate the Terraform module as a first-class Pulumi resource.
    // The strongly-typed Args class is generated from the module's variable declarations:
    //   first_name  string  The person's first name
    //   last_name   string  The person's last name
    var nameFormatter = new Module("string-formatter", new ModuleArgs
    {
        FirstName = "Jane",
        LastName  = "Doe",
    });

    // Expose any module outputs as Pulumi stack outputs.
    // Replace the keys/values below with the actual output names declared by the module.
    return new Dictionary<string, object?>
    {
        // Example: ["formattedName"] = nameFormatter.FormattedName,
    };
});
