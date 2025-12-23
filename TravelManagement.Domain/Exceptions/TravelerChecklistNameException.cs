using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Shared.Abstraction.Exceptions;

namespace TravelManagement.Domain.Exceptions
{
    public class TravelerChecklistNameException : TravelerCheckListException
    {
        public TravelerChecklistNameException() : base("Traveler Checklist list name cannot be empty.")
        {

        }
    }
}
