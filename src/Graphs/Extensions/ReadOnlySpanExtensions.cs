namespace Graphs.Extensions;

public static class ReadOnlySpanExtensions
{
    public static T Dequeue<T>(this ReadOnlySpan<T> span, out ReadOnlySpan<T> newSpan)
    {
        newSpan = span[1..];
        return span[0];
    }
}
