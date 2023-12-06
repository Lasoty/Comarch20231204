using Bibliotekarz.Client.Services;
using Microsoft.AspNetCore.Components;

namespace Bibliotekarz.Client.Pages;

public partial class Dashboard
{

    [Inject]
    public IWeatherForecastService ForecastService { get; set; }

    public IMessageService Messages { get; set; }

    protected override void OnInitialized()
    {
        //var data = ForecastService.Forecast();
        base.OnInitialized();
    }
}