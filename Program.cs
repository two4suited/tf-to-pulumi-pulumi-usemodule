using System.Collections.Generic;
using Pulumi;

return await Deployment.RunAsync(() =>
{
    var nameFormatter = new NameFormatterModule("name-formatter", new NameFormatterArgs
    {
        FirstName = "Brian",
        LastName  = "Sheridan",
    });

    return new Dictionary<string, object?>
    {
        ["WholeName"] = nameFormatter.WholeName,
    };
});
