using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abstraction.Exceptions;

namespace TravelManagement.Domain.Exceptions
{
    public class TravelerItemAlreadyExistsException:TravelerCheckListException
    {
        public string ListName { get; set; }
        public string ItemName { get; set; }

        public TravelerItemAlreadyExistsException(string listName,string itemName)
        :base($"Traveler Check list:'{listName}' already defined item'{itemName}'")
        {
            ListName = listName;
            ItemName = itemName;
        }
    }
}
