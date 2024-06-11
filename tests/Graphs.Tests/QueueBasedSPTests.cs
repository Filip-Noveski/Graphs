using Graphs.DataStructures;
using Graphs.Exceptions;
using Graphs.Tests.Helpers;

namespace Graphs.Tests;

public class QueueBasedSPTests : ShortestPathsTests
{
    [Fact]
    public void ShouldFindShortestPathsFromA()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.QueuedSP('A');

        // Assert
        AssertGraphWithSolutionForSourceA(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromA()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.QueuedSP('A'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromB()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.QueuedSP('B');

        // Assert
        AssertGraphWithSolutionForSourceB(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromB()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.QueuedSP('B'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromC()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.QueuedSP('C');

        // Assert
        AssertGraphWithSolutionForSourceC(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromC()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.QueuedSP('C'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromD()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.QueuedSP('D');

        // Assert
        AssertGraphWithSolutionForSourceD(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromD()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.QueuedSP('D'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromE()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.QueuedSP('E');

        // Assert
        AssertGraphWithSolutionForSourceE(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromE()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.QueuedSP('E'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromF()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.QueuedSP('F');

        // Assert
        AssertGraphWithSolutionForSourceF(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromF()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.QueuedSP('F'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromG()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.QueuedSP('G');

        // Assert
        AssertGraphWithSolutionForSourceG(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromG()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.QueuedSP('G'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromH()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.QueuedSP('H');

        // Assert
        AssertGraphWithSolutionForSourceH(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromH()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.QueuedSP('H'));
    }

    [Fact]
    public void ShouldFindAllPairsShortestPaths()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.QueuedSP();

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
        Assert.Throws<NegativeWeightCycleException>(graph.QueuedSP);
    }
}
