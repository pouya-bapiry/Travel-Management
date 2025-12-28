using Microsoft.EntityFrameworkCore;
using TravelManagement.Application.Dto;
using TravelManagement.Application.Queries;
using TravelManagement.Domain.Repositories;
using TravelManagement.Infrastructure.EF.Contexts;
using TravelManagement.Infrastructure.EF.Models;
using TravelManagement.Shared.Abstraction.Queries;

namespace TravelManagement.Infrastructure.EF.Queries.Handlers
{
    internal sealed class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelerCheckListDto>
    {
        private readonly DbSet<TravelerCheckListReadModel> _TravelerCheckLists;

        public GetTravelerCheckListHandler(ReadDbContext context)
            => _TravelerCheckLists = context.TravelerCheckList;

        public Task<TravelerCheckListDto> HandleAsync(GetTravelerCheckList query)
            => _TravelerCheckLists
                .Include(pl => pl.Items)
                .Where(pl => pl.Id == query.Id)
                .Select(pl => pl.AsDto())
                .AsNoTracking()
                .SingleOrDefaultAsync();
    }
}
