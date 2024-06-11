using Graphs.Exceptions;
using Graphs.Extensions;
using Graphs.Interfaces;
using Graphs.Models;
using Graphs.Utilities;

namespace Graphs.DataStructures;

/// <summary>
/// Graph data structure.
/// </summary>
public class Graph : IGraph
{
    private List<Vertex> _vertices;
    private List<Edge> _edges;

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

    public void BellmanFord()
    {
        BellmanFordService service = new(ref _vertices, ref _edges);
        foreach (Vertex v in _vertices)
        {
            service.Execute(v);
        }
    }

    public void BellmanFord(char sourceVertexId)
    {
        BellmanFordService service = new(ref _vertices, ref _edges);
        // TODO: consider trying to optimise search for vertex
        service.Execute(_vertices.First(v => v.Id == sourceVertexId));
    }

    public void DependencyListSP()
    {
        DependencyListSPService service = new(ref _vertices, ref _edges);
        foreach (Vertex v in _vertices)
        {
            service.Execute(v);
        }
    }

    public void DependencyListSP(char sourceVertexId)
    {
        DependencyListSPService service = new(ref _vertices, ref _edges);
        // TODO: consider trying to optimise search for vertex
        service.Execute(_vertices.First(v => v.Id == sourceVertexId));
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
