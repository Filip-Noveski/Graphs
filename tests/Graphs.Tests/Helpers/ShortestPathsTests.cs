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
            g.CreateEdge('\u0004', 'D', 'B', 2);
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

    protected static void AssertGraphWithSolutionForSourceB(Graph graph)
    {
        // assert A
        (float weight, char[] path) = graph.GetPathBetween('B', 'A');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert B
        (weight, path) = graph.GetPathBetween('B', 'B');
        Assert.Equal(0, weight);
        Assert.Empty(path);

        // assert C
        (weight, path) = graph.GetPathBetween('B', 'C');
        Assert.Equal(6, weight);
        Assert.Single(path);
        Assert.Equal('C', path[0]);

        // assert D
        (weight, path) = graph.GetPathBetween('B', 'D');
        Assert.Equal(10, weight);
        Assert.Equal(4, path.Length);
        Assert.Equal('C', path[0]);
        Assert.Equal('H', path[1]);
        Assert.Equal('G', path[2]);
        Assert.Equal('D', path[3]);

        // assert E
        (weight, path) = graph.GetPathBetween('B', 'E');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert F
        (weight, path) = graph.GetPathBetween('B', 'F');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert G
        (weight, path) = graph.GetPathBetween('B', 'G');
        Assert.Equal(9, weight);
        Assert.Equal(3, path.Length);
        Assert.Equal('C', path[0]);
        Assert.Equal('H', path[1]);
        Assert.Equal('G', path[2]);

        // assert H
        (weight, path) = graph.GetPathBetween('B', 'H');
        Assert.Equal(11, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('C', path[0]);
        Assert.Equal('H', path[1]);
    }

    protected static void AssertGraphWithSolutionForSourceC(Graph graph)
    {
        // assert A
        (float weight, char[] path) = graph.GetPathBetween('C', 'A');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert B
        (weight, path) = graph.GetPathBetween('C', 'B');
        Assert.Equal(6, weight);
        Assert.Equal(4, path.Length);
        Assert.Equal('H', path[0]);
        Assert.Equal('G', path[1]);
        Assert.Equal('D', path[2]);
        Assert.Equal('B', path[3]);

        // assert C
        (weight, path) = graph.GetPathBetween('C', 'C');
        Assert.Equal(0, weight);
        Assert.Empty(path);

        // assert D
        (weight, path) = graph.GetPathBetween('C', 'D');
        Assert.Equal(4, weight);
        Assert.Equal(3, path.Length);
        Assert.Equal('H', path[0]);
        Assert.Equal('G', path[1]);
        Assert.Equal('D', path[2]);

        // assert E
        (weight, path) = graph.GetPathBetween('C', 'E');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert F
        (weight, path) = graph.GetPathBetween('C', 'F');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert G
        (weight, path) = graph.GetPathBetween('C', 'G');
        Assert.Equal(3, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('H', path[0]);
        Assert.Equal('G', path[1]);

        // assert H
        (weight, path) = graph.GetPathBetween('C', 'H');
        Assert.Equal(5, weight);
        Assert.Single(path);
        Assert.Equal('H', path[0]);
    }

    protected static void AssertGraphWithSolutionForSourceD(Graph graph)
    {
        // assert A
        (float weight, char[] path) = graph.GetPathBetween('D', 'A');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert B
        (weight, path) = graph.GetPathBetween('D', 'B');
        Assert.Equal(2, weight);
        Assert.Single(path);
        Assert.Equal('B', path[0]);

        // assert C
        (weight, path) = graph.GetPathBetween('D', 'C');
        Assert.Equal(8, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('B', path[0]);
        Assert.Equal('C', path[1]);

        // assert D
        (weight, path) = graph.GetPathBetween('D', 'D');
        Assert.Equal(0, weight);
        Assert.Empty(path);

        // assert E
        (weight, path) = graph.GetPathBetween('D', 'E');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert F
        (weight, path) = graph.GetPathBetween('D', 'F');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert G
        (weight, path) = graph.GetPathBetween('D', 'G');
        Assert.Equal(11, weight);
        Assert.Equal(4, path.Length);
        Assert.Equal('B', path[0]);
        Assert.Equal('C', path[1]);
        Assert.Equal('H', path[2]);
        Assert.Equal('G', path[3]);

        // assert H
        (weight, path) = graph.GetPathBetween('D', 'H');
        Assert.Equal(13, weight);
        Assert.Equal(3, path.Length);
        Assert.Equal('B', path[0]);
        Assert.Equal('C', path[1]);
        Assert.Equal('H', path[2]);
    }

    protected static void AssertGraphWithSolutionForSourceE(Graph graph)
    {
        // assert A
        (float weight, char[] path) = graph.GetPathBetween('E', 'A');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert B
        (weight, path) = graph.GetPathBetween('E', 'B');
        Assert.Equal(5, weight);
        Assert.Equal(3, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('D', path[1]);
        Assert.Equal('B', path[2]);

        // assert C
        (weight, path) = graph.GetPathBetween('E', 'C');
        Assert.Equal(1, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('C', path[1]);

        // assert D
        (weight, path) = graph.GetPathBetween('E', 'D');
        Assert.Equal(3, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('D', path[1]);

        // assert E
        (weight, path) = graph.GetPathBetween('E', 'E');
        Assert.Equal(0, weight);
        Assert.Empty(path);

        // assert F
        (weight, path) = graph.GetPathBetween('E', 'F');
        Assert.Equal(3, weight);
        Assert.Single(path);
        Assert.Equal('F', path[0]);

        // assert G
        (weight, path) = graph.GetPathBetween('E', 'G');
        Assert.Equal(2, weight);
        Assert.Single(path);
        Assert.Equal('G', path[0]);

        // assert H
        (weight, path) = graph.GetPathBetween('E', 'H');
        Assert.Equal(6, weight);
        Assert.Equal(3, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('C', path[1]);
        Assert.Equal('H', path[2]);
    }

    protected static void AssertGraphWithSolutionForSourceF(Graph graph)
    {
        // assert A
        (float weight, char[] path) = graph.GetPathBetween('F', 'A');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert B
        (weight, path) = graph.GetPathBetween('F', 'B');
        Assert.Equal(9, weight);
        Assert.Equal(3, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('D', path[1]);
        Assert.Equal('B', path[2]);

        // assert C
        (weight, path) = graph.GetPathBetween('F', 'C');
        Assert.Equal(5, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('C', path[1]);

        // assert D
        (weight, path) = graph.GetPathBetween('F', 'D');
        Assert.Equal(7, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('D', path[1]);

        // assert E
        (weight, path) = graph.GetPathBetween('F', 'E');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert F
        (weight, path) = graph.GetPathBetween('F', 'F');
        Assert.Equal(0, weight);
        Assert.Empty(path);

        // assert G
        (weight, path) = graph.GetPathBetween('F', 'G');
        Assert.Equal(6, weight);
        Assert.Single(path);
        Assert.Equal('G', path[0]);

        // assert H
        (weight, path) = graph.GetPathBetween('F', 'H');
        Assert.Equal(10, weight);
        Assert.Equal(3, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('C', path[1]);
        Assert.Equal('H', path[2]);
    }

    protected static void AssertGraphWithSolutionForSourceG(Graph graph)
    {
        // assert A
        (float weight, char[] path) = graph.GetPathBetween('G', 'A');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert B
        (weight, path) = graph.GetPathBetween('G', 'B');
        Assert.Equal(3, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('D', path[0]);
        Assert.Equal('B', path[1]);

        // assert C
        (weight, path) = graph.GetPathBetween('G', 'C');
        Assert.Equal(-1, weight);
        Assert.Single(path);
        Assert.Equal('C', path[0]);

        // assert D
        (weight, path) = graph.GetPathBetween('G', 'D');
        Assert.Equal(1, weight);
        Assert.Single(path);
        Assert.Equal('D', path[0]);

        // assert E
        (weight, path) = graph.GetPathBetween('G', 'E');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert F
        (weight, path) = graph.GetPathBetween('G', 'F');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert G
        (weight, path) = graph.GetPathBetween('G', 'G');
        Assert.Equal(0, weight);
        Assert.Empty(path);

        // assert H
        (weight, path) = graph.GetPathBetween('G', 'H');
        Assert.Equal(4, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('C', path[0]);
        Assert.Equal('H', path[1]);
    }

    protected static void AssertGraphWithSolutionForSourceH(Graph graph)
    {
        // assert A
        (float weight, char[] path) = graph.GetPathBetween('H', 'A');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert B
        (weight, path) = graph.GetPathBetween('H', 'B');
        Assert.Equal(1, weight);
        Assert.Equal(3, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('D', path[1]);
        Assert.Equal('B', path[2]);

        // assert C
        (weight, path) = graph.GetPathBetween('H', 'C');
        Assert.Equal(-3, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('C', path[1]);

        // assert D
        (weight, path) = graph.GetPathBetween('H', 'D');
        Assert.Equal(-1, weight);
        Assert.Equal(2, path.Length);
        Assert.Equal('G', path[0]);
        Assert.Equal('D', path[1]);

        // assert E
        (weight, path) = graph.GetPathBetween('H', 'E');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert F
        (weight, path) = graph.GetPathBetween('H', 'F');
        Assert.Equal(float.PositiveInfinity, weight);
        Assert.Empty(path);

        // assert G
        (weight, path) = graph.GetPathBetween('H', 'G');
        Assert.Equal(-2, weight);
        Assert.Single(path);
        Assert.Equal('G', path[0]);

        // assert H
        (weight, path) = graph.GetPathBetween('H', 'H');
        Assert.Equal(0, weight);
        Assert.Empty(path);
    }
}
