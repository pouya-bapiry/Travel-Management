using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelManagement.Application.Dto;
using TravelManagement.Shared.Abstraction.Queries;

namespace TravelManagement.Application.Queries
{
    public class SearchTravelerCheckList:IQuery<IEnumerable<TravelerCheckListDto>>
    {
        public string SearchPhrase { get; set; }
    
    }
}
