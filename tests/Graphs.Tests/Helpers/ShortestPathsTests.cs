using Graphs.DataStructures;

namespace Graphs.Tests.Helpers;

public abstract class ShortestPathsTests
{
    protected static Graph GraphWithSolution 
    { 
        get
        {
            Graph g = new();
            for (char c = 'A'; c <= 'H'; c++)
            {
                g.CreateVertex(c);
            }

            g.CreateEdge('\u0000', 'A', 'B', 8);
            g.CreateEdge('\u0001', 'A', 'E', 5);
            g.CreateEdge('\u0002', 'B', 'C', 6);
            g.CreateEdge('\u0003', 'C', 'H', 5);
            g.CreateEdge('\u0004', 'D', 'B', 5);
            g.CreateEdge('\u0005', 'E', 'F', 3);
            g.CreateEdge('\u0006', 'E', 'G', 2);
            g.CreateEdge('\u0007', 'F', 'G', 6);
            g.CreateEdge('\u0008', 'G', 'C', -1);
            g.CreateEdge('\u0009', 'G', 'D', 1);
            g.CreateEdge('\u000a', 'H', 'G', -2);

            return g;
        }
    }
    
    protected static Graph GraphWithNWCycle
    {
        get
        {
            Graph g = new();
            for (char c = 'A'; c <= 'H'; c++)
            {
                g.CreateVertex(c);
            }

            g.CreateEdge('\u0000', 'A', 'B', 8);
            g.CreateEdge('\u0001', 'A', 'E', 5);
            g.CreateEdge('\u0002', 'B', 'C', 6);
            g.CreateEdge('\u0003', 'C', 'H', 4);
            g.CreateEdge('\u0004', 'D', 'B', 5);
            g.CreateEdge('\u0005', 'E', 'F', 3);
            g.CreateEdge('\u0006', 'E', 'G', 2);
            g.CreateEdge('\u0007', 'F', 'G', 6);
            g.CreateEdge('\u0008', 'G', 'C', -1);
            g.CreateEdge('\u0009', 'G', 'D', 1);
            g.CreateEdge('\u000a', 'H', 'G', -7);

            return g;
        }
    }

    protected static void AssertGraphWithSolutionForSourceA(Graph graph)
    {
        // assert A
        (float weight, char[] path) = graph.GetPathBetween('A', 'A');
        Assert.Equal(0, weight);
        Assert.Empty(path);

        // assert B
        (weight, path) = graph.GetPathBetween('A', 'B');
        Assert.Equal(8, weight);
        Assert.Single(path);
        Assert.Equal('B', path[0]);

        // assert C
        (weight, path) = graph.GetPathBetween('A', 'C');
        Assert.Equal(6, weight);
        Assert.Equal(3, path.Length);
        Assert.Equal('E', path[0]);
        Assert.Equal('G', path[1]);
        Assert.Equal('C', path[2]);

        // assert D
        (weight, path) = graph.GetPathBetween('A', 'D');
        Assert.Equal(8, weight);
        Assert.Equal(3, path.Length);
        Assert.Equal('E', path[0]);
        Assert.Equal('G', path[1]);
        Assert.Equal('D', path[2]);

        // assert E
        (weight, path) = graph.GetPathBetween('A', 'E');
        Assert.Equal(5, weight);
        Assert.Single(path);
        Assert.Equal('E', path[0]);

        // assert F
        (weight, path) = graph.GetPathBetween('A', 'F');
        Assert.Equal(8, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('E', path[0]);
        Assert.Equal('F', path[1]);

        // assert G
        (weight, path) = graph.GetPathBetween('A', 'G');
        Assert.Equal(7, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('E', path[0]);
        Assert.Equal('G', path[1]);

        // assert H
        (weight, path) = graph.GetPathBetween('A', 'H');
        Assert.Equal(11, weight);
        Assert.Equal(4, path.Length);
        Assert.Equal('E', path[0]);
        Assert.Equal('G', path[1]);
        Assert.Equal('C', path[2]);
        Assert.Equal('H', path[3]);
    }
}
