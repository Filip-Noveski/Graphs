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