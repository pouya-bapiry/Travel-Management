
using TravelManagement.Shared.Abstraction.Commands;

namespace Final_SophieTravelManagement.Application.Commands
{
    public record RemoveTravelerItem(Guid TravelerCheckListId, string Name) : ICommand;
}
