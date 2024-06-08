﻿using Graphs.Exceptions;
using Graphs.Extensions;
using Graphs.Interfaces;

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
    }

    public void DeleteEdge(char id)
    {
        throw new NotImplementedException();
    }

    public void UpdateEdgeWeight(char id, int newWeight)
    {
        throw new NotImplementedException();
    }

    public void BellmanFord()
    {
        throw new NotImplementedException();
    }

    public void BellmanFord(char sourceVertexId)
    {
        throw new NotImplementedException();
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
