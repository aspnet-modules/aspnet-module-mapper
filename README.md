# AspNet.Module.Mapper

Packages for registering `IMapper` and configuring Mapster-based object mapping.

## Installation

```sh
# IMapper abstractions
dotnet add package AspNet.Module.Mapper.Abstractions

# host integration
dotnet add package AspNet.Module.Mapper
```

## Mapper Configuration

```cs
public class MapperConfig : TypeAdapterConfig
{
    public MapperConfig()
    {
        ForType<SomeEntity, SomeDto>();
    }
}
```

## Module Registration

```cs
using AspNet.Module.Mapper;

var builder = AspNetWebApplication.CreateBuilder(args);
builder.RegisterModule<MapperModule<MapperConfig>>();
```

## Source Code

- Repository: [github.com/aspnet-modules/aspnet-module-mapper](https://github.com/aspnet-modules/aspnet-module-mapper)
