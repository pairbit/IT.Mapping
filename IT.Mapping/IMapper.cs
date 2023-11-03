using System;

namespace IT.Mapping;

public interface IMapper
{
    TTo Map<TTo>(object from);

    TTo Map<TFrom, TTo>(TFrom from);

    TTo Map<TFrom, TTo>(TFrom from, TTo? to);

    object Map(Type fromType, object from, Type toType);

    object Map(Type fromType, object from, Type toType, object? to);
}