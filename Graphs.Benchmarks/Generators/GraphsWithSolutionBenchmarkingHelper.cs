using Graphs.Benchmarks.Extensions;
using Graphs.DataStructures;

namespace Graphs.Benchmarks.Generators;

internal class GraphsWithSolutionBenchmarkingHelper
{
    public static Graph GraphWith8VerticesAnd11Edges
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

    public static Graph GraphWith23VerticesAnd35Edges
    {
        get
        {
            Random random = new(19);
            Graph g = new();
            for (char c = 'A'; c < 'A' + 23; c++)
            {
                g.CreateVertex(c);
            }

            char id = '\u0000';
            g.CreateEdge(id++, 'A', 'B', Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, 'B', 'D', Math.Sign(random.NextDouble() - 0.5) * 14);
            g.CreateEdge(id++, 'B', 'E', Math.Sign(random.NextDouble() - 0.5) * 58);
            g.CreateEdge(id++, 'C', 'D', Math.Sign(random.NextDouble() - 0.5) * 7);
            g.CreateEdge(id++, 'C', 'E', Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, 'C', 'F', Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, 'C', 'G', Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, 'C', 'H', Math.Sign(random.NextDouble() - 0.5) * 4);
            g.CreateEdge(id++, 'D', 'E', Math.Sign(random.NextDouble() - 0.5) * 6);
            g.CreateEdge(id++, 'E', 'F', Math.Sign(random.NextDouble() - 0.5) * 2);
            g.CreateEdge(id++, 'F', 'G', Math.Sign(random.NextDouble() - 0.5) * 2);
            g.CreateEdge(id++, 'F', 'V', Math.Sign(random.NextDouble() - 0.5) * 25);
            g.CreateEdge(id++, 'G', 'H', Math.Sign(random.NextDouble() - 0.5) * 1);
            g.CreateEdge(id++, 'G', 'K', Math.Sign(random.NextDouble() - 0.5) * 37);
            g.CreateEdge(id++, 'H', 'I', Math.Sign(random.NextDouble() - 0.5) * 10);
            g.CreateEdge(id++, 'I', 'J', Math.Sign(random.NextDouble() - 0.5) * 2);
            g.CreateEdge(id++, 'I', 'W', Math.Sign(random.NextDouble() - 0.5) * 2);
            g.CreateEdge(id++, 'J', 'W', Math.Sign(random.NextDouble() - 0.5) * 2);
            g.CreateEdge(id++, 'J', 'L', Math.Sign(random.NextDouble() - 0.5) * 22);
            g.CreateEdge(id++, 'K', 'L', Math.Sign(random.NextDouble() - 0.5) * 18);
            g.CreateEdge(id++, 'K', 'O', Math.Sign(random.NextDouble() - 0.5) * 9);
            g.CreateEdge(id++, 'L', 'M', Math.Sign(random.NextDouble() - 0.5) * 26);
            g.CreateEdge(id++, 'M', 'N', Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, 'M', 'O', Math.Sign(random.NextDouble() - 0.5) * 1);
            g.CreateEdge(id++, 'N', 'O', Math.Sign(random.NextDouble() - 0.5) * 4);
            g.CreateEdge(id++, 'N', 'P', Math.Sign(random.NextDouble() - 0.5) * 16);
            g.CreateEdge(id++, 'O', 'U', Math.Sign(random.NextDouble() - 0.5) * 31);
            g.CreateEdge(id++, 'P', 'Q', Math.Sign(random.NextDouble() - 0.5) * 10);
            g.CreateEdge(id++, 'P', 'R', Math.Sign(random.NextDouble() - 0.5) * 33);
            g.CreateEdge(id++, 'R', 'T', Math.Sign(random.NextDouble() - 0.5) * 19);
            g.CreateEdge(id++, 'S', 'T', Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, 'S', 'U', Math.Sign(random.NextDouble() - 0.5) * 1);
            g.CreateEdge(id++, 'S', 'V', Math.Sign(random.NextDouble() - 0.5) * 1);
            g.CreateEdge(id++, 'U', 'T', Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, 'U', 'V', Math.Sign(random.NextDouble() - 0.5) * 2);

            return g;
        }
    }

    public static Graph GraphWith47VerticesAnd68Edges
    {
        get
        {
            Random random = new(63);
            static char GetId(int x) => (char)('A' + x);
            Graph g = new();
            for (char c = 'A'; c < 'A' + 49; c++)
            {
                g.CreateVertex(c);
            }

            char id = '\u0000';
            g.CreateEdge(id++, GetId(0), GetId(1), Math.Sign(random.NextDouble() - 0.5) * 7);
            g.CreateEdge(id++, GetId(0), GetId(47), Math.Sign(random.NextDouble() - 0.5) * 52);
            g.CreateEdge(id++, GetId(1), GetId(2), Math.Sign(random.NextDouble() - 0.5) * 8);
            g.CreateEdge(id++, GetId(1), GetId(11), Math.Sign(random.NextDouble() - 0.5) * 49);
            g.CreateEdge(id++, GetId(2), GetId(4), Math.Sign(random.NextDouble() - 0.5) * 63);
            g.CreateEdge(id++, GetId(3), GetId(4), Math.Sign(random.NextDouble() - 0.5) * 6);
            g.CreateEdge(id++, GetId(3), GetId(5), Math.Sign(random.NextDouble() - 0.5) * 4);
            g.CreateEdge(id++, GetId(4), GetId(5), Math.Sign(random.NextDouble() - 0.5) * 8);
            g.CreateEdge(id++, GetId(5), GetId(7), Math.Sign(random.NextDouble() - 0.5) * 31);
            g.CreateEdge(id++, GetId(5), GetId(9), Math.Sign(random.NextDouble() - 0.5) * 26);
            g.CreateEdge(id++, GetId(6), GetId(7), Math.Sign(random.NextDouble() - 0.5) * 4);
            g.CreateEdge(id++, GetId(6), GetId(8), Math.Sign(random.NextDouble() - 0.5) * 32);
            g.CreateEdge(id++, GetId(6), GetId(36), Math.Sign(random.NextDouble() - 0.5) * 64);
            g.CreateEdge(id++, GetId(7), GetId(38), Math.Sign(random.NextDouble() - 0.5) * 57);
            g.CreateEdge(id++, GetId(8), GetId(9), Math.Sign(random.NextDouble() - 0.5) * 20);
            g.CreateEdge(id++, GetId(9), GetId(11), Math.Sign(random.NextDouble() - 0.5) * 42);
            g.CreateEdge(id++, GetId(10), GetId(11), Math.Sign(random.NextDouble() - 0.5) * 4);
            g.CreateEdge(id++, GetId(10), GetId(48), Math.Sign(random.NextDouble() - 0.5) * 33);
            g.CreateEdge(id++, GetId(12), GetId(14), Math.Sign(random.NextDouble() - 0.5) * 20);
            g.CreateEdge(id++, GetId(12), GetId(48), Math.Sign(random.NextDouble() - 0.5) * 13);
            g.CreateEdge(id++, GetId(13), GetId(14), Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, GetId(13), GetId(15), Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, GetId(14), GetId(15), Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, GetId(15), GetId(17), Math.Sign(random.NextDouble() - 0.5) * 31);
            g.CreateEdge(id++, GetId(16), GetId(17), Math.Sign(random.NextDouble() - 0.5) * 8);
            g.CreateEdge(id++, GetId(16), GetId(18), Math.Sign(random.NextDouble() - 0.5) * 5);
            g.CreateEdge(id++, GetId(16), GetId(19), Math.Sign(random.NextDouble() - 0.5) * 11);
            g.CreateEdge(id++, GetId(17), GetId(18), Math.Sign(random.NextDouble() - 0.5) * 9);
            g.CreateEdge(id++, GetId(18), GetId(19), Math.Sign(random.NextDouble() - 0.5) * 16);
            g.CreateEdge(id++, GetId(19), GetId(20), Math.Sign(random.NextDouble() - 0.5) * 10);
            g.CreateEdge(id++, GetId(19), GetId(21), Math.Sign(random.NextDouble() - 0.5) * 10);
            g.CreateEdge(id++, GetId(20), GetId(21), Math.Sign(random.NextDouble() - 0.5) * 5);
            g.CreateEdge(id++, GetId(20), GetId(37), Math.Sign(random.NextDouble() - 0.5) * 33);
            g.CreateEdge(id++, GetId(37), GetId(20), Math.Sign(random.NextDouble() - 0.5) * 28);
            g.CreateEdge(id++, GetId(21), GetId(23), Math.Sign(random.NextDouble() - 0.5) * 19);
            g.CreateEdge(id++, GetId(21), GetId(35), Math.Sign(random.NextDouble() - 0.5) * 27);
            g.CreateEdge(id++, GetId(22), GetId(23), Math.Sign(random.NextDouble() - 0.5) * 2);
            g.CreateEdge(id++, GetId(22), GetId(24), Math.Sign(random.NextDouble() - 0.5) * 31);
            g.CreateEdge(id++, GetId(22), GetId(35), Math.Sign(random.NextDouble() - 0.5) * 43);
            g.CreateEdge(id++, GetId(24), GetId(25), Math.Sign(random.NextDouble() - 0.5) * 26);
            g.CreateEdge(id++, GetId(24), GetId(33), Math.Sign(random.NextDouble() - 0.5) * 55);
            g.CreateEdge(id++, GetId(26), GetId(27), Math.Sign(random.NextDouble() - 0.5) * 1);
            g.CreateEdge(id++, GetId(26), GetId(28), Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, GetId(27), GetId(28), Math.Sign(random.NextDouble() - 0.5) * 2);
            g.CreateEdge(id++, GetId(27), GetId(41), Math.Sign(random.NextDouble() - 0.5) * 56);
            g.CreateEdge(id++, GetId(28), GetId(33), Math.Sign(random.NextDouble() - 0.5) * 14);
            g.CreateEdge(id++, GetId(29), GetId(30), Math.Sign(random.NextDouble() - 0.5) * 5);
            g.CreateEdge(id++, GetId(29), GetId(31), Math.Sign(random.NextDouble() - 0.5) * 3);
            g.CreateEdge(id++, GetId(29), GetId(32), Math.Sign(random.NextDouble() - 0.5) * 5);
            g.CreateEdge(id++, GetId(30), GetId(31), Math.Sign(random.NextDouble() - 0.5) * 6);
            g.CreateEdge(id++, GetId(30), GetId(40), Math.Sign(random.NextDouble() - 0.5) * 15);
            g.CreateEdge(id++, GetId(31), GetId(32), Math.Sign(random.NextDouble() - 0.5) * 2);
            g.CreateEdge(id++, GetId(31), GetId(34), Math.Sign(random.NextDouble() - 0.5) * 11);
            g.CreateEdge(id++, GetId(32), GetId(33), Math.Sign(random.NextDouble() - 0.5) * 9);
            g.CreateEdge(id++, GetId(34), GetId(35), Math.Sign(random.NextDouble() - 0.5) * 11);
            g.CreateEdge(id++, GetId(34), GetId(37), Math.Sign(random.NextDouble() - 0.5) * 23);
            g.CreateEdge(id++, GetId(36), GetId(37), Math.Sign(random.NextDouble() - 0.5) * 2);
            g.CreateEdge(id++, GetId(37), GetId(38), Math.Sign(random.NextDouble() - 0.5) * 25);
            g.CreateEdge(id++, GetId(38), GetId(39), Math.Sign(random.NextDouble() - 0.5) * 15);
            g.CreateEdge(id++, GetId(39), GetId(40), Math.Sign(random.NextDouble() - 0.5) * 29);
            g.CreateEdge(id++, GetId(39), GetId(44), Math.Sign(random.NextDouble() - 0.5) * 44);
            g.CreateEdge(id++, GetId(40), GetId(42), Math.Sign(random.NextDouble() - 0.5) * 44);
            g.CreateEdge(id++, GetId(41), GetId(42), Math.Sign(random.NextDouble() - 0.5) * 54);
            g.CreateEdge(id++, GetId(42), GetId(46), Math.Sign(random.NextDouble() - 0.5) * 20);
            g.CreateEdge(id++, GetId(43), GetId(45), Math.Sign(random.NextDouble() - 0.5) * 2);
            g.CreateEdge(id++, GetId(44), GetId(45), Math.Sign(random.NextDouble() - 0.5) * 13);
            g.CreateEdge(id++, GetId(44), GetId(46), Math.Sign(random.NextDouble() - 0.5) * 13);
            g.CreateEdge(id++, GetId(45), GetId(46), Math.Sign(random.NextDouble() - 0.5) * 29);
            g.CreateEdge(id++, GetId(47), GetId(48), Math.Sign(random.NextDouble() - 0.5) * 55);

            return g;
        }
    }
}
