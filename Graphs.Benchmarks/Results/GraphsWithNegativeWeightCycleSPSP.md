## Run 1

* Bellman-Ford using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>;
* Dependency-Lists using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code> and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span><span style="color: #0090C0">char</span><span style="color: #FFFFFF">, </span>List<span style="color: #FFFFFF">&lt;</span>Edge<span style="color: #FFFFFF">&gt;&gt;</span></code> to mark dependencies;
* Queues using <code style="color: #92D050">ReadOnlySpan</code> to <code style="color: #00F091">Edge<span style="color: #FFFFFF">[]</span></code> and <code style="color: #00F091">Vertex<span style="color: #FFFFFF">[]</span></code> in <code style="color: #00F091">Graph</code>, <code style="color: #00F091">HashSet<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">&gt;</span></code> to queue vertices and <code style="color: #00F091">Dictionary<span style="color: #FFFFFF">&lt;</span>Vertex<span style="color: #FFFFFF">, <span style="color: #0090C0">int</span><span style="color: #FFFFFF">&gt;</span></code> to count number of enqueues;

| Method          | Id | Mean      | Error     | StdDev    | Allocated |
|---------------- |--- |----------:|----------:|----------:|----------:|
| BellmanFord     | 0  |  8.538 us | 0.0539 us | 0.0450 us |    1.3 KB |
| DependencyLists | 0  | 10.914 us | 0.0907 us | 0.0757 us |   3.16 KB |
| Queues          | 0  | 14.621 us | 0.2924 us | 0.4002 us |   4.35 KB |
| BellmanFord     | 1  | 26.176 us | 0.2755 us | 0.2442 us |   7.53 KB |
| DependencyLists | 1  | 11.128 us | 0.1271 us | 0.1061 us |   3.15 KB |
| Queues          | 1  | 56.650 us | 0.5265 us | 0.4925 us |  18.17 KB |
| BellmanFord     | 2  |  3.738 us | 0.0525 us | 0.0465 us |   2.67 KB |
| DependencyLists | 2  |  6.866 us | 0.0783 us | 0.0654 us |  26.44 KB |
| Queues          | 2  |  4.317 us | 0.0806 us | 0.1156 us |    4.5 KB |