using TravelManagement.Domain.Entities;
using TravelManagement.Domain.ValueObjects;
using TravelManagement.Shared.Abstraction.Domain;


namespace TravelManagement.Domain.Events
{
    public record TravelerItemRemoved(TravelerCheckList TravelerCheckList, TravelerItem TravelerItem) : IDomainEvent;

}
