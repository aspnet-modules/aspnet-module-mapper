# Модуль маппинга

Модуль регистрирует IMapper для маппинга данных.

```sh
# для доступа к IMapper
dotnet add package AspNet.Module.Mapper.Abstractions

# для регистрации модуля в Host
dotnet add package AspNet.Module.Mapper
```

## Конфигурация

Создаем конфигурацию от базового класса TypeAdapterConfig

```cs
public class MapperConfig : TypeAdapterConfig
{
    public MapperConfig()
    {
        ForType<SomeEntity, SomeDto>();
    }
}
```

## Регистрация модуля с указанной конфигурацией в Program

Добавляем в Host проект nuget пакет `AspNet.Module.Mapper`.

```cs
using AspNet.Module.Mapper;

var builder = AspNetWebApplication.CreateBuilder(args);
builder.RegisterModule<MapperModule<MapperConfig>>();
```
