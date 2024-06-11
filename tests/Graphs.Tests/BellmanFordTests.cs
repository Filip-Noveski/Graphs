using Graphs.DataStructures;
using Graphs.Exceptions;
using Graphs.Tests.Helpers;

namespace Graphs.Tests;

public class BellmanFordTests : ShortestPathsTests
{
    [Fact]
    public void ShouldFindShortestPathsFromA()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.BellmanFord('A');

        // Assert
        AssertGraphWithSolutionForSourceA(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromA()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.BellmanFord('A'));
    }
    
    [Fact]
    public void ShouldFindShortestPathsFromB()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.BellmanFord('B');

        // Assert
        AssertGraphWithSolutionForSourceB(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromB()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.BellmanFord('B'));
    }
    
    [Fact]
    public void ShouldFindShortestPathsFromC()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.BellmanFord('C');

        // Assert
        AssertGraphWithSolutionForSourceC(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromC()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.BellmanFord('C'));
    }
    
    [Fact]
    public void ShouldFindShortestPathsFromD()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.BellmanFord('D');

        // Assert
        AssertGraphWithSolutionForSourceD(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromD()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.BellmanFord('D'));
    }
    
    [Fact]
    public void ShouldFindShortestPathsFromE()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.BellmanFord('E');

        // Assert
        AssertGraphWithSolutionForSourceE(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromE()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.BellmanFord('E'));
    }
    
    [Fact]
    public void ShouldFindShortestPathsFromF()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.BellmanFord('F');

        // Assert
        AssertGraphWithSolutionForSourceF(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromF()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.BellmanFord('F'));
    }
    
    [Fact]
    public void ShouldFindShortestPathsFromG()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.BellmanFord('G');

        // Assert
        AssertGraphWithSolutionForSourceG(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromG()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.BellmanFord('G'));
    }
    
    [Fact]
    public void ShouldFindShortestPathsFromH()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.BellmanFord('H');

        // Assert
        AssertGraphWithSolutionForSourceH(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromH()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.BellmanFord('H'));
    }
    
    [Fact]
    public void ShouldFindAllPairsShortestPaths()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.BellmanFord();

        // Assert
        AssertGraphWithSolutionForSourceA(graph);
        AssertGraphWithSolutionForSourceB(graph);
        AssertGraphWithSolutionForSourceC(graph);
        AssertGraphWithSolutionForSourceD(graph);
        AssertGraphWithSolutionForSourceE(graph);
        AssertGraphWithSolutionForSourceF(graph);
        AssertGraphWithSolutionForSourceG(graph);
        AssertGraphWithSolutionForSourceH(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleForAllPairs()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(graph.BellmanFord);
    }
}
