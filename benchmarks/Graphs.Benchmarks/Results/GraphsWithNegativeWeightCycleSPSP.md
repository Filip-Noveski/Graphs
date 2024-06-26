﻿## Run 1 (**47-Vertex / 68-Edge Graph is irrelevant as NWC was unreachable**)

* Bellman-Ford using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>;
* Dependency-Lists using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code> and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span><span style="color: #0090C0">char</span><span style="color: #FFFFFF">, </span>List<span style="color: #FFFFFF">&lt;</span>Edge<span style="color: #FFFFFF">&gt;&gt;</span></code> to mark dependencies;
* Queues using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>, <code style="color: #00F091">HashSet<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">&gt;</span></code> to queue vertices and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">, <span style="color: #0090C0">int</span><span style="color: #FFFFFF">&gt;</span></code> to count number of enqueues;

| Method          | &#x007c;V&#x007c; | &#x007c;E&#x007c; | Mean      | Error     | StdDev    | Allocated |
|---------------- |------------------:|------------------:|----------:|----------:|----------:|----------:|
| BellmanFord     | 8                 | 11                |  8.538 us | 0.0539 us | 0.0450 us |    1.3 KB |
| DependencyLists | 8                 | 11                | 10.914 us | 0.0907 us | 0.0757 us |   3.16 KB |
| Queues          | 8                 | 11                | 14.621 us | 0.2924 us | 0.4002 us |   4.35 KB |
| BellmanFord     | 23                | 35                | 26.176 us | 0.2755 us | 0.2442 us |   7.53 KB |
| DependencyLists | 23                | 35                | 11.128 us | 0.1271 us | 0.1061 us |   3.15 KB |
| Queues          | 23                | 35                | 56.650 us | 0.5265 us | 0.4925 us |  18.17 KB |
| BellmanFord     | 47                | 68                |  3.738 us | 0.0525 us | 0.0465 us |   2.67 KB |
| DependencyLists | 47                | 68                |  6.866 us | 0.0783 us | 0.0654 us |  26.44 KB |
| Queues          | 47                | 68                |  4.317 us | 0.0806 us | 0.1156 us |    4.5 KB |

## Run 2 (**47-Vertex / 68-Edge Graph is irrelevant as NWC was unreachable**)

* Bellman-Ford using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>;
* Dependency-Lists using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code> and <code style="color: #92D050">DependencyList</code> ref struct to mark dependencies with custom <code style="color: #00F091">Wrapper<span style="color: #FFFFFF">&lt;</span><span style="color: #B2D090">T</span><span style="color: #FFFFFF">&gt;</span></code> to store next enqueue;
* Queues using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>, <code style="color: #00F091">HashSet<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">&gt;</span></code> to queue vertices and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">, <span style="color: #0090C0">int</span><span style="color: #FFFFFF">&gt;</span></code> to count number of enqueues;

| Method          | &#x007c;V&#x007c; | &#x007c;E&#x007c; | Mean      | Error     | StdDev    | Allocated |
|---------------- |------------------:|------------------:|----------:|----------:|----------:|----------:|
| BellmanFord     | 8                 | 11                |  8.759 us | 0.1641 us | 0.1756 us |    1.3 KB |
| DependencyLists | 8                 | 11                | 10.749 us | 0.0874 us | 0.0730 us |   1.64 KB |
| Queues          | 8                 | 11                | 14.565 us | 0.2796 us | 0.2747 us |   4.35 KB |
| BellmanFord     | 23                | 35                | 26.203 us | 0.4066 us | 0.3993 us |   7.53 KB |
| DependencyLists | 23                | 35                | 10.973 us | 0.2175 us | 0.3923 us |   2.47 KB |
| Queues          | 23                | 35                | 56.205 us | 0.3728 us | 0.3113 us |  18.17 KB |
| BellmanFord     | 47                | 68                |  3.744 us | 0.0510 us | 0.0426 us |   2.67 KB |
| DependencyLists | 47                | 68                |  5.354 us | 0.0467 us | 0.0437 us |   4.45 KB |
| Queues          | 47                | 68                |  4.262 us | 0.0477 us | 0.0423 us |    4.5 KB |

## Run 3 (**47-Vertex / 68-Edge Graph is irrelevant as NWC was unreachable**)

* Bellman-Ford using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>;
* Dependency-Lists using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code> and <code style="color: #92D050">DependencyList</code> ref struct to mark dependencies with custom <code style="color: #00F091">Wrapper<span style="color: #FFFFFF">&lt;</span><span style="color: #B2D090">T</span><span style="color: #FFFFFF">&gt;</span></code> to store next enqueue;
* Queues using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>, <code style="color: #00F091">HashSet<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">&gt;</span></code> to queue vertices and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">, <span style="color: #0090C0">int</span><span style="color: #FFFFFF">&gt;</span></code> to count number of enqueues both with initial capacity set to number of vertices;

| Method          | &#x007c;V&#x007c; | &#x007c;E&#x007c; | Mean      | Error     | StdDev    | Median    | Allocated |
|---------------- |------------------:|------------------:|----------:|----------:|----------:|----------:|----------:|
| BellmanFord     | 8                 | 11                |  8.334 us | 0.0389 us | 0.0325 us |  8.334 us |    1.3 KB |
| DependencyLists | 8                 | 11                | 11.530 us | 0.2297 us | 0.4023 us | 11.350 us |   1.64 KB |
| Queues          | 8                 | 11                | 15.619 us | 0.1629 us | 0.1272 us | 15.647 us |   3.99 KB |
| BellmanFord     | 23                | 35                | 26.709 us | 0.5256 us | 0.8182 us | 26.435 us |   7.53 KB |
| DependencyLists | 23                | 35                | 10.390 us | 0.0902 us | 0.0800 us | 10.365 us |   2.47 KB |
| Queues          | 23                | 35                | 55.275 us | 0.4950 us | 0.4388 us | 55.336 us |  17.31 KB |
| BellmanFord     | 47                | 68                |  4.317 us | 0.0674 us | 0.0563 us |  4.319 us |   2.67 KB |
| DependencyLists | 47                | 68                |  5.411 us | 0.0458 us | 0.0383 us |  5.430 us |   4.45 KB |
| Queues          | 47                | 68                |  4.373 us | 0.0844 us | 0.0866 us |  4.336 us |   6.37 KB |

## Run 4 (**47-Vertex / 68-Edge Graph is irrelevant as NWC was unreachable**)

* Bellman-Ford using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>;
* Dependency-Lists using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code> and <code style="color: #92D050">DependencyList</code> ref struct to mark dependencies with custom <code style="color: #00F091">Wrapper<span style="color: #FFFFFF">&lt;</span><span style="color: #B2D090">T</span><span style="color: #FFFFFF">&gt;</span></code> to store next enqueue, <code><span style="color: #00F091">DependencyList</span>::AddDependency</code> method changed to <code style="color: #0090C0">void</code>;
* Queues using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>, <code style="color: #00F091">HashSet<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">&gt;</span></code> to queue vertices and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">, <span style="color: #0090C0">int</span><span style="color: #FFFFFF">&gt;</span></code> to count number of enqueues both with initial capacity set to number of vertices;

| Method          | &#x007c;V&#x007c; | &#x007c;E&#x007c; | Mean      | Error     | StdDev    | Allocated |
|---------------- |------------------:|------------------:|----------:|----------:|----------:|----------:|
| BellmanFord     | 8                 | 11                |  9.349 us | 0.1692 us | 0.2964 us |    1.3 KB |
| DependencyLists | 8                 | 11                | 10.348 us | 0.0859 us | 0.0717 us |   1.64 KB |
| Queues          | 8                 | 11                | 15.639 us | 0.1140 us | 0.1067 us |   3.99 KB |
| BellmanFord     | 23                | 35                | 27.219 us | 0.5166 us | 0.4579 us |   7.53 KB |
| DependencyLists | 23                | 35                | 10.464 us | 0.0779 us | 0.0608 us |   2.47 KB |
| Queues          | 23                | 35                | 58.175 us | 0.7449 us | 0.6220 us |  17.31 KB |
| BellmanFord     | 47                | 68                |  3.746 us | 0.0686 us | 0.0642 us |   2.67 KB |
| DependencyLists | 47                | 68                |  4.477 us | 0.0469 us | 0.0439 us |   4.45 KB |
| Queues          | 47                | 68                |  4.253 us | 0.0491 us | 0.0410 us |   6.37 KB |

## Run 5

* **Ordered edges by Depth-First Search**

* Bellman-Ford using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>;
* Dependency-Lists using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code> and <code style="color: #92D050">DependencyList</code> ref struct to mark dependencies with custom <code style="color: #00F091">Wrapper<span style="color: #FFFFFF">&lt;</span><span style="color: #B2D090">T</span><span style="color: #FFFFFF">&gt;</span></code> to store next enqueue, <code><span style="color: #00F091">DependencyList</span>::AddDependency</code> method changed to <code style="color: #0090C0">void</code>;
* Queues using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>, <code style="color: #00F091">HashSet<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">&gt;</span></code> to queue vertices and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">, <span style="color: #0090C0">int</span><span style="color: #FFFFFF">&gt;</span></code> to count number of enqueues both with initial capacity set to number of vertices;

| Method          | Id | Mean       | Error     | StdDev    | Allocated |
|---------------- |--- |-----------:|----------:|----------:|----------:|
| BellmanFord     | 0  |   8.599 us | 0.1457 us | 0.1363 us |    1.3 KB |
| DependencyLists | 0  |  10.304 us | 0.1145 us | 0.1071 us |   1.64 KB |
| Queues          | 0  |  15.508 us | 0.1573 us | 0.1471 us |   3.99 KB |
| BellmanFord     | 1  |  28.666 us | 0.4344 us | 0.4063 us |  12.02 KB |
| DependencyLists | 1  |  10.089 us | 0.1259 us | 0.1178 us |   2.38 KB |
| Queues          | 1  |  55.497 us | 0.5312 us | 0.4436 us |  17.31 KB |
| BellmanFord     | 2  |  86.301 us | 1.4312 us | 1.8610 us |  41.64 KB |
| DependencyLists | 2  |  11.678 us | 0.1136 us | 0.1063 us |   5.51 KB |
| Queues          | 2  | 177.420 us | 1.5503 us | 1.2946 us |  73.24 KB |