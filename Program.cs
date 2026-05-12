using System.Collections.Generic;
using Pulumi;

return await Deployment.RunAsync(() =>
{
    var nameFormatter = new NameFormatterModule("name-formatter", new NameFormatterArgs
    {
        FirstName = "Jane",
        LastName  = "Doe",
    });

    return new Dictionary<string, object?>
    {
        ["wholeName"] = nameFormatter.WholeName,
    };
});
