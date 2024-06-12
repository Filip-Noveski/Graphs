using System.Numerics;

namespace Graphs.Models;

internal sealed class Wrapper<T> where T : INumber<T>
{
    public T Value { get; set; }

    public Wrapper(T value)
    {
        Value = value;
    }

    public static implicit operator T(Wrapper<T> wrapper) => wrapper.Value;
    public static implicit operator Wrapper<T>(T value) => new(value);

    public static Wrapper<T> operator +(Wrapper<T> wrapper, T value)
    {
        wrapper.Value += value;
        return wrapper;
    }
}
