using Graphs.Exceptions;

namespace Graphs.Interfaces;

/// <summary>
/// Interface for a graph with the contained vertices and edges.
/// </summary>
public interface IGraph
{
    /// <summary>
    /// Adds a new vertex with the specified <paramref name="id"/>.
    /// </summary>
    /// <param name="id">The id of the vertex to add.</param>
    /// <exception cref="DuplicateIdException"></exception>
    void CreateVertex(char id);

    /// <summary>
    /// Deletes the vertex with the specified <paramref name="id"/> if it exists.
    /// </summary>
    /// <param name="id">The id of the vertex to delete.</param>
    void DeleteVertex(char id);

    /// <summary>
    /// Creates an edge between the specified <paramref name="sourceVertex"/> and
    /// <paramref name="targetVertex"/> with the specified <paramref name="id"/> and 
    /// <paramref name="weight"/>.
    /// </summary>
    /// <param name="id">The id of the edge to add.</param>
    /// <param name="sourceVertex">The id of the source vertex of the edge.</param>
    /// <param name="targetVertex">The id of the terminal vertex of the edge.</param>
    /// <param name="weight">The weight of the edge.</param>
    /// <exception cref="DuplicateIdException"></exception>
    void CreateEdge(char id, char sourceVertex, char targetVertex, float weight);

    /// <summary>
    /// Replaces the old weight with the provided <paramref name="newWeight"/>
    /// on the edge with the specified <paramref name="id"/>.
    /// </summary>
    /// <param name="id">The id of the edge to update.</param>
    /// <param name="newWeight">The new weight to set.</param>
    /// <exception cref="IdNotFoundException"></exception>
    void UpdateEdgeWeight(char id, int newWeight);

    /// <summary>
    /// Deletes the edge with the specified <paramref name="id"/> if it exists.
    /// </summary>
    /// <param name="id">The id of the edge.</param>
    void DeleteEdge(char id);

    /// <summary>
    /// Sets the order of the edges based on Depth-First Search.
    /// </summary>
    /// <param name="vertexId">The vertex to start from.</param>
    void OrderEdgesByDfs(char vertexId);

    /// <summary>
    /// Sets the order of the edges based on Breadth-First Search.
    /// </summary>
    /// <param name="vertexId">The vertex to start from.</param>
    void OrderEdgesByBfs(char vertexId);

    /// <summary>
    /// Returns the currently found shortest path between the specified vertices.
    /// </summary>
    /// <param name="source">The id of the source vertex.</param>
    /// <param name="target">The id of the target vertex.</param>
    /// <returns>A tuple with the total weight and list of vertex ids to go through.</returns>
    (float Weight, char[] VertexIds) GetPathBetween(char source, char target);
    
    /// <summary>
    /// Performs Bellman-Ford over all vertices.
    /// </summary>
    void BellmanFord();

    /// <summary>
    /// Preforms Bellman-Ford over the specified vertex.
    /// </summary>
    /// <param name="sourceVertexId">The id of the source vertex.</param>
    void BellmanFord(char sourceVertexId);

    /// <summary>
    /// Performs Dependency lists shortest paths over all vertices.
    /// </summary>
    void DependencyListSP();

    /// <summary>
    /// Performs Dependency lists shortest paths over the specified vertex.
    /// </summary>
    /// <param name="sourceVertexId">The id of the source vertex.</param>
    void DependencyListSP(char sourceVertexId);

    /// <summary>
    /// Performs Queue-based shortest paths over all vertices.
    /// </summary>
    void QueuedSP();

    /// <summary>
    /// Performs Queue-based shortest paths over the specified vertex.
    /// </summary>
    /// <param name="sourceVertexId">The id of the source vertex.</param>
    void QueuedSP(char sourceVertexId);
}
