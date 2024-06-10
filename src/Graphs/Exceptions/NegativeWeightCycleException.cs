namespace Graphs.Exceptions;

/// <summary>
/// Represents an error that there was a negative-weight cycle in the graph 
/// where shortest paths were calculated.
/// </summary>
public class NegativeWeightCycleException : Exception
{
    /// <summary>
    /// Creates an instance of the <see cref="NegativeWeightCycleException"/> class.
    /// </summary>
    public NegativeWeightCycleException() : base($"There was a negative-weight cycle")
    {
    }
}
