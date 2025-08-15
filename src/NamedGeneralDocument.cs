using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Documents.General.Named.Abstract;

namespace Soenneker.Documents.General.Named;

/// <inheritdoc cref="INamedGeneralDocument"/>
public abstract class NamedGeneralDocument : GeneralDocument, INamedGeneralDocument
{
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public virtual string Name { get; set; } = null!;
}