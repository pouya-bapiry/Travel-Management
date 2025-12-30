using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TravelManagement.Application.Services;
using TravelManagement.Infrastructure.EF;
using TravelManagement.Infrastructure.Logging;
using TravelManagement.Infrastructure.Services;
using TravelManagement.Shared.Abstractions.Commands;
using TravelManagement.Shared.Queries;

namespace TravelManagement.Infrastructure
{
    public static class Etensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSQLDB(configuration);
            services.AddQueries();
            services.AddSingleton<IWeatherService, DumbWeatherService>();

            services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

            return services;



        }

    }
}
