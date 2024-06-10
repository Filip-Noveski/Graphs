using Graphs.Exceptions;
using Graphs.Extensions;
using Graphs.Interfaces;
using Graphs.Models;
using Graphs.Utilities;
using System.Runtime.InteropServices;

namespace Graphs.DataStructures;

/// <summary>
/// Graph data structure.
/// </summary>
public class Graph : IGraph
{
    private readonly List<Vertex> _vertices;
    private readonly List<Edge> _edges;

    public Graph()
    {
        _vertices = new();
        _edges = new();
    }

    public void CreateVertex(char id)
    {
        if (_vertices.Contains(v => v.Id == id))
        {
            throw new DuplicateIdException(nameof(Vertex), id);
        }

        Vertex v = new(id);
        _vertices.Add(v);
    }

    public void DeleteVertex(char id)
    {
        _vertices.Remove(v => v.Id == id);
    }

    public void CreateEdge(char id, char sourceVertex, char targetVertex, int weight)
    {
        if (_edges.Contains(e => e.Id == id))
        {
            throw new DuplicateIdException(nameof(Edge), id);
        }

        Vertex? source = null;
        Vertex? terminal = null;

        // TODO: extract this
        foreach (Vertex v in _vertices)
        {
            if (v.Id == sourceVertex)
            {
                source = v;
            }
            if (v.Id == targetVertex)
            {
                terminal = v;
            }
            if (source is not null && terminal is not null)
            {
                break;
            }
        }

        Edge e = new(
            id,
            source ?? throw new IdNotFoundException(nameof(Vertex), sourceVertex),
            terminal ?? throw new IdNotFoundException(nameof(Vertex), targetVertex),
            weight);

        source.OutgoingEdges.Add(e);
        _edges.Add(e);
    }

    public void DeleteEdge(char id)
    {
        _edges.Remove(e => e.Id == id);
    }

    public void UpdateEdgeWeight(char id, int newWeight)
    {
        _edges.First(e => e.Id == id).Weight = newWeight;
    }

    public (float Weight, char[] VertexIds) GetPathBetween(char source, char target)
    {
        Vertex s = _vertices.FirstOrDefault(e => e.Id == source) 
            ?? throw new IdNotFoundException(nameof(Vertex), source);

        Pathing pathing = s.Paths[target];
        return (pathing.TotalWeight, pathing.VertexIds.ToArray());
    }

    private static bool BellmanFordIteration(Vertex vertex, ref ReadOnlySpan<Edge> edges)
    {
        bool improved = false;
        for (int i = 0; i < edges.Length; i++)
        {
            Edge e = edges[i];
            ref Pathing pathingToTarget = ref CollectionsMarshal.GetValueRefOrAddDefault(vertex.Paths, e.TerminalVertex.Id, out _);
            ref Pathing pathingToSource = ref CollectionsMarshal.GetValueRefOrAddDefault(vertex.Paths, e.SourceVertex.Id, out _);
            float currentDistance = pathingToTarget.TotalWeight;
            float newDistance = pathingToSource.TotalWeight + e.Weight;

            if (currentDistance > newDistance)
            {
                improved = true;
                pathingToTarget.TotalWeight = newDistance;
                pathingToTarget.VertexIds.Clear();
                pathingToTarget.VertexIds.AddRange(pathingToSource.VertexIds);
                pathingToTarget.VertexIds.Add(e.TerminalVertex.Id);
            }
        }

        return improved;
    }

    private void BellmanFord(Vertex vertex)
    {
        VertexPathingUtilities.ResetPaths(vertex, _vertices);

        ReadOnlySpan<Edge> edges = CollectionsMarshal.AsSpan(_edges);
        int vertexCount = _vertices.Count;
        for (int i = 0; i < vertexCount; i++)
        {
            bool improved = BellmanFordIteration(vertex, ref edges);
            if (!improved)
            {
                return;
            }
        }

        throw new NegativeWeightCycleException();
    }

    public void BellmanFord()
    {
        foreach (Vertex v in _vertices)
        {
            BellmanFord(v);
        }
    }

    public void BellmanFord(char sourceVertexId)
    {
        BellmanFord(_vertices.First(v => v.Id == sourceVertexId));
    }

    public void DependencyListSP()
    {
        throw new NotImplementedException();
    }

    public void DependencyListSP(char sourceVertexId)
    {
        throw new NotImplementedException();
    }

    public void QueuedSP()
    {
        throw new NotImplementedException();
    }

    public void QueuedSP(char sourceVertexId)
    {
        throw new NotImplementedException();
    }
}
