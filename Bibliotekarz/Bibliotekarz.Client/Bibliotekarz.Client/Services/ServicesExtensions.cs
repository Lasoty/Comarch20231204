namespace Bibliotekarz.Client.Services;

public static class ServicesExtensions
{
    public static IServiceCollection AddLocalServices(this IServiceCollection services)
    {
        //TODO: Rejestracja lokalnych serwisów.
        services.AddScoped<IWeatherForecastService, WeatherForecastService>();
        services.AddScoped<IBookService, BookService>();

        return services;
    }
}