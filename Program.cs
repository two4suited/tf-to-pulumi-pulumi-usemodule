using System.Collections.Generic;
using Pulumi;

// Generated SDK namespace produced by:
//   pulumi package add terraform-module \
//     app.terraform.io/BS_INC/string-formatter/BPS//modules/name-formatter \
//     2026.512.2 \
//     name-formatter
//
// Pulumi derives the C# namespace from the package name ("name-formatter" → "NameFormatter").
// Run the command above before building; it will generate the SDK under sdks/name-formatter/
// and add a ProjectReference to this .csproj automatically.
using Pulumi.NameFormatter;

return await Deployment.RunAsync(() =>
{
    // Instantiate the Terraform module as a first-class Pulumi resource.
    // The strongly-typed Args class is generated from the module's variable declarations:
    //   first_name  string  The person's first name
    //   last_name   string  The person's last name
    var nameFormatter = new Module("string-formatter_name-formatter", new ModuleArgs
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
