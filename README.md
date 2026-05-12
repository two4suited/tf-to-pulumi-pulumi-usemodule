# tf-to-pulumi-pulumi-usemodule

Pulumi C# stack that consumes the private Terraform Cloud module
`app.terraform.io/BS_INC/string-formatter/BPS//modules/name-formatter` (v2026.512.2)
via Pulumi's native `pulumi package add terraform-module` feature.

## Prerequisites

| Tool | Notes |
|------|-------|
| [Pulumi CLI](https://www.pulumi.com/docs/install/) ≥ 3.x | `brew install pulumi` |
| .NET 8 SDK | `brew install dotnet` |
| Terraform Cloud token | Set `TF_TOKEN_app_terraform_io` (see below) |

### Authenticate to Terraform Cloud

The module lives in a private Terraform Cloud registry. Export your token before
running any Pulumi commands:

```bash
export TF_TOKEN_app_terraform_io="<your-terraform-cloud-token>"
```

Alternatively, configure it via the Terraform CLI:

```bash
terraform login app.terraform.io
```

## One-time SDK generation

Run this once (or whenever the module version changes) to generate the local C# SDK:

```bash
pulumi package add terraform-module \
  app.terraform.io/BS_INC/string-formatter/BPS//modules/name-formatter \
  2026.512.2 \
  name-formatter
```

This will:
1. Download and introspect the Terraform module.
2. Generate a strongly-typed C# SDK under `sdks/name-formatter/dotnet/`.
3. Add a `<ProjectReference>` to `StringFormatterNameFormatter.csproj` automatically.

## Usage

Edit `Program.cs` and supply real values for `FirstName` / `LastName`, then:

```bash
pulumi stack init dev
pulumi up
```

## Project structure

```
Pulumi.yaml                         # Pulumi project metadata
StringFormatterNameFormatter.csproj # C# project (updated by pulumi package add)
Program.cs                          # Stack entrypoint – uses the generated SDK
sdks/name-formatter/                # Generated after running pulumi package add (git-ignored)
```

## Module inputs

| Variable     | Type   | Description             |
|--------------|--------|-------------------------|
| `first_name` | string | The person's first name |
| `last_name`  | string | The person's last name  |
