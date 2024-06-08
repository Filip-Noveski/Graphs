namespace Graphs.Extensions;

public static class ListExtensions
{
    public static bool Contains<T>(this List<T> list, Func<T, bool> predicate)
    {
        return list.Where(predicate).Any();
    }

    public static void Remove<T>(this List<T> list, Func<T, bool> predicate)
    {
        T val = list.First(predicate);
        list.Remove(val);
    }
}
