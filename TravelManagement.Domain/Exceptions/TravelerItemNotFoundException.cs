using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abstraction.Exceptions;

namespace TravelManagement.Domain.Exceptions
{
    public class TravelerItemNotFoundException : TravelerCheckListException
    {
        public string ItemName { get; }

        public TravelerItemNotFoundException(string itemName) : base($"Traveler item '{itemName}' was not found.")
            => ItemName = itemName;
    }
}
