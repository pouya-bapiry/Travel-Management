using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Application.Dto.External;
using TravelManagement.Application.Services;
using TravelManagement.Domain.ValueObjects;

namespace TravelManagement.Infrastructure.Services
{
    internal sealed class DumbWeatherService : IWeatherService
    {
        public Task<WeatherDto> GetWeatherAsync(Destination destination)
            => Task.FromResult(new WeatherDto(new Random().Next(5, 30)));
    }
}
