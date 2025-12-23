using TravelManagement.Shared.Abstraction.Commands;

namespace TravelManagement.Application.Commands
{
    public record AddTravelerItem(Guid TravelerCheckListId, string Name, uint Quantity) : ICommand;
}
