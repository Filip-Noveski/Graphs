namespace Graphs.Exceptions;

public class IdNotFoundException : Exception
{
    public IdNotFoundException(string entityType, char id)
        : base($"The entity of type '{entityType}' with the id '{id}' was not found")
    {
        
    }
}
