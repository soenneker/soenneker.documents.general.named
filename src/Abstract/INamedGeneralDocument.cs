using Soenneker.Documents.General.Abstract;
using Soenneker.Documents.Named.Abstract;

namespace Soenneker.Documents.General.Named.Abstract;

/// <summary>
/// Essentially just adds Name to the document <para/>
/// <inheritdoc cref="IGeneralDocument"/>
/// </summary>
public interface INamedGeneralDocument : INamedDocument, IGeneralDocument
{
}