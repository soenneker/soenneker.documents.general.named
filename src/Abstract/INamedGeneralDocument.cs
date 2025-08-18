using Soenneker.Documents.General.Abstract;
using Soenneker.Documents.Named.Abstract;
using Soenneker.Documents.Typed.Named.Abstract;

namespace Soenneker.Documents.General.Named.Abstract;

/// <summary>
/// Essentially just adds Name to the document <para/>
/// <inheritdoc cref="IGeneralDocument"/>
/// </summary>
public interface INamedGeneralDocument : INamedTypedDocument, IGeneralDocument;