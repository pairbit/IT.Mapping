using System;

namespace IT.Mapping.Mapster;

public class Mapper : IMapper
{
    private readonly MapsterMapper.IMapper _mapper;

    public Mapper(MapsterMapper.IMapper mapper)
    {
        _mapper = mapper;
    }

    public TTo Map<TTo>(object from) => _mapper.Map<TTo>(from);

    public TTo Map<TFrom, TTo>(TFrom from) => _mapper.Map<TFrom, TTo>(from);

#pragma warning disable CS8603 // Possible null reference return.
    public TTo Map<TFrom, TTo>(TFrom from, TTo? to) => _mapper.Map(from, to);
#pragma warning restore CS8603 // Possible null reference return.

    public object Map(Type fromType, object from, Type toType) => _mapper.Map(from, fromType, toType);

#pragma warning disable CS8604 // Possible null reference argument.
    public object Map(Type fromType, object from, Type toType, object? to) => _mapper.Map(from, to, fromType, toType);
#pragma warning restore CS8604 // Possible null reference argument.
}