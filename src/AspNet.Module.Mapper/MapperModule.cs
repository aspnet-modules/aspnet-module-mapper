using AspNet.Module.Common;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AspNet.Module.Mapper;

/// <summary>
///     Mapper Модуль
/// </summary>
public class MapperModule : IAspNetModule
{
    private readonly TypeAdapterConfig _config;

    public MapperModule()
    {
        _config = TypeAdapterConfig.GlobalSettings;
    }

    public MapperModule(TypeAdapterConfig config)
    {
        _config = config;
    }

    public void Configure(AspNetModuleContext ctx)
    {
        ctx.Services.AddSingleton(_config);
        ctx.Services.AddScoped<IMapper, ServiceMapper>();
    }
}

/// <summary>
///     Mapper Модуль
/// </summary>
public class MapperModule<TConfig> : MapperModule
    where TConfig : TypeAdapterConfig, new()
{
    public MapperModule() : base(new TConfig())
    {
    }
}