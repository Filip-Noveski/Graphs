namespace Graphs.Exceptions;

/// <summary>
/// An error that the id was used by another entity of the same type.
/// </summary>
public class DuplicateIdException : Exception
{
    /// <summary>
    /// Creates an instance of the <see cref="DuplicateIdException"/> class.
    /// </summary>
    /// <param name="entityType">The type of entity that caused the error.</param>
    /// <param name="specifiedId">The requested id for the entity.</param>
    public DuplicateIdException(string entityType, char specifiedId)
        : base($"An entity of type '{entityType}' with the id '{specifiedId}' already exists")
    {
        
    }
}
