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
}
