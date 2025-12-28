
using Microsoft.EntityFrameworkCore;
using TravelManagement.Application.Services;
using TravelManagement.Infrastructure.EF.Contexts;
using TravelManagement.Infrastructure.EF.Models;


namespace TravelManagement.Infrastructure.EF.Services
{
    internal sealed class TravelerCheckListReadService : ITravelerCheckListReadService
    {
        private readonly DbSet<TravelerCheckListReadModel> _travelerCheckList;

        public TravelerCheckListReadService(ReadDbContext context)
            => _travelerCheckList = context.TravelerCheckList;

        public Task<bool> ExistsByNameAsync(string name)
            => _travelerCheckList.AnyAsync(pl => pl.Name == name);
    }
}
