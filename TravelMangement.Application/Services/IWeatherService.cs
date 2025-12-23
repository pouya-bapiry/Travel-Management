
using TravelManagement.Application.Dto.External;
using TravelManagement.Domain.ValueObjects;


namespace TravelManagement.Application.Services
{
    public interface IWeatherService
    {
        Task<WeatherDto> GetWeatherAsync(Destination localization);
    }
}
