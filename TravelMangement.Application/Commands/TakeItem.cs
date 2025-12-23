using TravelManagement.Shared.Abstraction.Commands;

namespace Final_SophieTravelManagement.Application.Commands
{
    public record TakeItem(Guid TravelerCheckListId, string Name) : ICommand;
}
