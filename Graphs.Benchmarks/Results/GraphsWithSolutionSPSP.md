## Run 1

* Bellman-Ford using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>;
* Dependency-Lists using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code> and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span><span style="color: #0090C0">char</span><span style="color: #FFFFFF">, </span>List<span style="color: #FFFFFF">&lt;</span>Edge<span style="color: #FFFFFF">&gt;&gt;</span></code> to mark dependencies;
* Queues using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>, <code style="color: #00F091">HashSet<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">&gt;</span></code> to queue vertices and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">, <span style="color: #0090C0">int</span><span style="color: #FFFFFF">&gt;</span></code> to count number of enqueues;

| Method          | Id | Mean       | Error     | StdDev    | Allocated |
|---------------- |--- |-----------:|----------:|----------:|----------:|
| BellmanFord     | 0  |   954.2 ns |  18.99 ns |  18.65 ns |     608 B |
| DependencyLists | 0  | 1,210.4 ns |  11.53 ns |   9.00 ns |    2560 B |
| Queues          | 0  | 1,832.9 ns |  17.88 ns |  15.85 ns |    2288 B |
| BellmanFord     | 1  | 2,479.1 ns |  43.22 ns |  64.69 ns |    2456 B |
| DependencyLists | 1  | 3,535.9 ns |  24.42 ns |  20.39 ns |    9096 B |
| Queues          | 1  | 6,065.4 ns | 121.20 ns | 107.44 ns |    5936 B |
| BellmanFord     | 2  | 3,767.6 ns |  45.90 ns |  40.69 ns |    2736 B |
| DependencyLists | 2  | 6,578.6 ns |  91.91 ns |  81.47 ns |   26176 B |
| Queues          | 2  | 4,509.4 ns |  45.83 ns |  40.63 ns |    4648 B |

## Run 2

* Bellman-Ford using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>;
* Dependency-Lists using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code> and <code style="color: #92D050">DependencyList</code> ref struct to mark dependencies with custom <code style="color: #00F091">Wrapper<span style="color: #FFFFFF">&lt;</span><span style="color: #B2D090">T</span><span style="color: #FFFFFF">&gt;</span></code> to store next enqueue;
* Queues using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>, <code style="color: #00F091">HashSet<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">&gt;</span></code> to queue vertices and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">, <span style="color: #0090C0">int</span><span style="color: #FFFFFF">&gt;</span></code> to count number of enqueues;

| Method          | Id | Mean       | Error    | StdDev   | Allocated |
|---------------- |--- |-----------:|---------:|---------:|----------:|
| BellmanFord     | 0  |   935.2 ns | 10.00 ns |  8.35 ns |     608 B |
| DependencyLists | 0  | 1,093.7 ns |  5.82 ns |  5.44 ns |    1000 B |
| Queues          | 0  | 1,837.2 ns | 29.05 ns | 34.58 ns |    2288 B |
| BellmanFord     | 1  | 2,467.9 ns | 45.32 ns | 42.39 ns |    2456 B |
| DependencyLists | 1  | 3,376.5 ns | 50.53 ns | 47.27 ns |    3424 B |
| Queues          | 1  | 6,211.8 ns | 91.37 ns | 85.47 ns |    5936 B |
| BellmanFord     | 2  | 3,807.9 ns | 51.82 ns | 43.27 ns |    2736 B |
| DependencyLists | 2  | 5,330.9 ns | 39.58 ns | 37.02 ns |    4560 B |
| Queues          | 2  | 4,498.8 ns | 39.14 ns | 30.56 ns |    4648 B |

## Run 3

* Bellman-Ford using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>;
* Dependency-Lists using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code> and <code style="color: #92D050">DependencyList</code> ref struct to mark dependencies with custom <code style="color: #00F091">Wrapper<span style="color: #FFFFFF">&lt;</span><span style="color: #B2D090">T</span><span style="color: #FFFFFF">&gt;</span></code> to store next enqueue;
* Queues using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>, <code style="color: #00F091">HashSet<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">&gt;</span></code> to queue vertices and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">, <span style="color: #0090C0">int</span><span style="color: #FFFFFF">&gt;</span></code> to count number of enqueues both with initial capacity set to number of vertices;

| Method          | Id | Mean       | Error    | StdDev    | Allocated |
|---------------- |--- |-----------:|---------:|----------:|----------:|
| BellmanFord     | 0  |   951.4 ns |  9.66 ns |   9.04 ns |     608 B |
| DependencyLists | 0  | 1,089.5 ns |  6.18 ns |   5.48 ns |    1000 B |
| Queues          | 0  | 1,591.2 ns |  4.73 ns |   4.42 ns |    1704 B |
| BellmanFord     | 1  | 2,532.9 ns | 50.57 ns |  70.90 ns |    2456 B |
| DependencyLists | 1  | 3,395.1 ns | 29.95 ns |  25.01 ns |    3424 B |
| Queues          | 1  | 5,668.8 ns | 38.00 ns |  31.73 ns |    4840 B |
| BellmanFord     | 2  | 3,980.0 ns | 77.75 ns |  95.48 ns |    2736 B |
| DependencyLists | 2  | 5,404.8 ns | 95.74 ns | 121.08 ns |    4560 B |
| Queues          | 2  | 4,460.7 ns | 27.81 ns |  23.22 ns |    6560 B |