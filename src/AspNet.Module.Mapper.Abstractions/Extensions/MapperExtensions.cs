using System.Reflection;
using Mapster;

namespace AspNet.Module.Mapper.Extensions;

/// <summary>
///     Расширения для <see cref="TypeAdapterSetter" />
/// </summary>
public static class MapperExtensions
{
    /// <summary>
    ///     Маппинг приватного конструктора
    /// </summary>
    public static TypeAdapterSetter<TSource, TDestination> MapToPrivateConstructor<TSource, TDestination>(
        this TypeAdapterSetter<TSource, TDestination> config)
    {
        var ctor = typeof(TDestination)
            .GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null,
                Array.Empty<Type>(), null);
        ArgumentNullException.ThrowIfNull(ctor);

        return config.MapToConstructor(ctor);
    }
}