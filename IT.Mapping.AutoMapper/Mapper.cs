using System;

namespace IT.Mapping.AutoMapper;

public class Mapper : IMapper
{
    private readonly global::AutoMapper.IMapperBase _mapper;

    public Mapper(global::AutoMapper.IMapperBase mapper)
    {
        _mapper = mapper;
    }

    public TTo Map<TTo>(object from) => _mapper.Map<TTo>(from);

    public TTo Map<TFrom, TTo>(TFrom from) => _mapper.Map<TFrom, TTo>(from);

#pragma warning disable CS8603 // Possible null reference return.
    public TTo Map<TFrom, TTo>(TFrom from, TTo? to) => _mapper.Map(from, to);
#pragma warning restore CS8603 // Possible null reference return.

    public object Map(Type fromType, object from, Type toType) => _mapper.Map(from, fromType, toType);

    public object Map(Type fromType, object from, Type toType, object? to) => _mapper.Map(from, to, fromType, toType);
}