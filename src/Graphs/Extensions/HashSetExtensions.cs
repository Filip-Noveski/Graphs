namespace Graphs.Extensions;

public static class HashSetExtensions
{
    public static T Dequeue<T>(this HashSet<T> set)
    {
        T value = set.Last();
        set.Remove(value);
        return value;
    }
}
