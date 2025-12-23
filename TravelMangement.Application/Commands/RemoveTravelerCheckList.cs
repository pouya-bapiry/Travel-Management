using TravelManagement.Shared.Abstraction.Commands;

namespace TravelManagement.Application.Commands
{
    public record RemoveTravelerCheckList(Guid Id) : ICommand;
}

