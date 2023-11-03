# IT.Mapping

## How to use

```csharp
    public Person2 Map(IMapper mapper, Person person)
    {
        return mapper.Map<Person2>(person);
    }

    public Person2 Map2(IMapper mapper, Person person)
    {
        return mapper.Map<Person, Person2>(person);
    }

    public Person2 Map3(IMapper mapper, Person person)
    {
        var person2 = new Person2();
        return mapper.Map(person, person2);
    }

    public Person2 Map(IMapper<Person, Person2> mapper, Person person)
    {
        return mapper.Map(person);
    }

    public Person2 Map2(IMapper<Person, Person2> mapper, Person person)
    {
        var person2 = new Person2();
        return mapper.Map(person, person2);
    }
```
