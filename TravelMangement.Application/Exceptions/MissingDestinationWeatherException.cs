
using TravelManagement.Domain.ValueObjects;
using TravelManagement.Shared.Abstraction.Exceptions;

namespace TravelManagement.Application.Exceptions
{
    public class MissingDestinationWeatherException : TravelerCheckListException
    {
        public Destination Destination { get; }

        public MissingDestinationWeatherException(Destination destination)
            : base($"Couldn't fetch weather data for Destination '{destination.Country}/{destination.City}'.")
        {
            Destination = destination;
        }
    }
}
