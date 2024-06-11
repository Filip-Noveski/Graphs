using Graphs.DataStructures;
using Graphs.Exceptions;
using Graphs.Tests.Helpers;

namespace Graphs.Tests;

public class DependencyListsSPTests : ShortestPathsTests
{
    [Fact]
    public void ShouldFindShortestPathsFromA()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.DependencyListSP('A');

        // Assert
        AssertGraphWithSolutionForSourceA(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromA()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.DependencyListSP('A'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromB()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.DependencyListSP('B');

        // Assert
        AssertGraphWithSolutionForSourceB(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromB()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.DependencyListSP('B'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromC()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.DependencyListSP('C');

        // Assert
        AssertGraphWithSolutionForSourceC(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromC()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.DependencyListSP('C'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromD()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.DependencyListSP('D');

        // Assert
        AssertGraphWithSolutionForSourceD(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromD()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.DependencyListSP('D'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromE()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.DependencyListSP('E');

        // Assert
        AssertGraphWithSolutionForSourceE(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromE()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.DependencyListSP('E'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromF()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.DependencyListSP('F');

        // Assert
        AssertGraphWithSolutionForSourceF(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromF()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.DependencyListSP('F'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromG()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.DependencyListSP('G');

        // Assert
        AssertGraphWithSolutionForSourceG(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromG()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.DependencyListSP('G'));
    }

    [Fact]
    public void ShouldFindShortestPathsFromH()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.DependencyListSP('H');

        // Assert
        AssertGraphWithSolutionForSourceH(graph);
    }

    [Fact]
    public void ShouldThrowNegativeWeightCycleFromH()
    {
        // Arrange
        Graph graph = GraphWithNWCycle;

        // Act / Assert
        Assert.Throws<NegativeWeightCycleException>(() => graph.DependencyListSP('H'));
    }

    [Fact]
    public void ShouldFindAllPairsShortestPaths()
    {
        // Arrange
        Graph graph = GraphWithSolution;

        // Act
        graph.DependencyListSP();

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
        Assert.Throws<NegativeWeightCycleException>(graph.DependencyListSP);
    }
}
