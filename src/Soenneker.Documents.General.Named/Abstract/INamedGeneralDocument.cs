using Soenneker.Documents.General.Abstract;
using Soenneker.Documents.Typed.Named.Abstract;

namespace Soenneker.Documents.General.Named.Abstract;

/// <summary>
/// Identifies a general-purpose typed document that has a name.
/// </summary>
public interface INamedGeneralDocument : INamedTypedDocument, IGeneralDocument;
