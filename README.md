[![](https://img.shields.io/nuget/v/soenneker.documents.general.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.documents.general.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.general.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.documents.general.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.documents.general.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.documents.general.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.documents.general.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.documents.general.named/actions/workflows/codeql.yml)

# Soenneker.Documents.General.Named

Provides a semantic base type for general-purpose documents that have both a type discriminator and a name.

## Installation

```bash
dotnet add package Soenneker.Documents.General.Named
```

## Usage

```csharp
using Soenneker.Documents.General.Named;

public sealed class TemplateDocument : NamedGeneralDocument
{
    public override string EntityType { get; set; } = "template";

    public string Content { get; set; } = null!;
}

var template = new TemplateDocument
{
    DocumentId = "welcome-email",
    PartitionKey = "tenant-7",
    CreatedAt = DateTimeOffset.UtcNow,
    Name = "Welcome email",
    Content = "Hello..."
};
```

The inherited fields serialize as `id`, `partitionKey`, `createdAt`, `modifiedAt`, `entityType`, and `name` with both System.Text.Json and Newtonsoft.Json attributes.

`NamedGeneralDocument` adds no persistence, validation, or discriminator logic. Derived types must implement `EntityType`; callers must initialize identity, timestamps, and `Name` before persistence. Keep `EntityType` stable if it is used to select a concrete model during reads.

`INamedGeneralDocument` combines the `IGeneralDocument` and `INamedTypedDocument` marker contracts without adding members. Use it when registration or persistence code needs to select this document family.
